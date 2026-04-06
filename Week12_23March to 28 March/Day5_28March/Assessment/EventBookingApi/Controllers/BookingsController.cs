using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/bookings")]
public class BookingsController : ControllerBase
{
    private readonly AppDbContext _context;

    public BookingsController(AppDbContext context)
    {
        _context = context;
    }

    [Authorize]
    [HttpPost]
    public IActionResult Book(BookingDto dto)
    {
        var userIdClaim = User.FindFirst("UserId")?.Value;
        int userId = 0;
        string username = User.Identity.Name;

        if (int.TryParse(userIdClaim, out var parsedUserId))
        {
            userId = parsedUserId;
        }

        var booking = new Booking
        {
            EventId = dto.EventId,
            SeatsBooked = dto.SeatsBooked,
            UserId = userId > 0 ? userId : null,
            UsernameDisplay = username
        };
        
        var ev = _context.Events.Find(dto.EventId);

        if (ev == null)
            return NotFound(new { message = "Event not found" });

        if (dto.SeatsBooked > ev.AvailableSeats)
            return BadRequest(new { message = "Not enough seats available" });

        ev.AvailableSeats -= dto.SeatsBooked;

        _context.Bookings.Add(booking);

        // Log booking if user has ID
        if (userId > 0)
        {
            var log = new UserLog
            {
                UserId = userId,
                Action = "Booking",
                Details = $"Booked {dto.SeatsBooked} seats for event: {ev.Title}"
            };
            _context.UserLogs.Add(log);
        }

        _context.SaveChanges();

        return Ok(new { message = "Booking Successful", bookingId = booking.Id });
    }

    [Authorize]
    [HttpGet]
    public IActionResult GetBookings()
    {
        var userIdClaim = User.FindFirst("UserId")?.Value;
        int userId = 0;

        if (int.TryParse(userIdClaim, out var parsedUserId))
        {
            userId = parsedUserId;
        }

        var bookings = _context.Bookings
            .Where(b => b.UserId == userId)
            .Include(b => b.Event)
            .Select(b => new
            {
                b.Id,
                EventName = b.Event.Title,
                b.SeatsBooked,
                b.BookedAt
            })
            .ToList();

        return Ok(bookings);
    }

    [Authorize]
    [HttpDelete("{id}")]
    public IActionResult Cancel(int id)
    {
        var booking = _context.Bookings.Include(b => b.Event).FirstOrDefault(b => b.Id == id);
        if (booking == null) 
            return NotFound(new { message = "Booking not found" });

        var userIdClaim = User.FindFirst("UserId")?.Value;
        if (int.TryParse(userIdClaim, out var userId) && booking.UserId != userId)
            return Forbid();

        // Return seats to event
        var ev = booking.Event;
        if (ev != null)
        {
            ev.AvailableSeats += booking.SeatsBooked;
        }

        // Log cancellation
        if (booking.UserId > 0)
        {
            var log = new UserLog
            {
                UserId = booking.UserId.Value,
                Action = "CancelBooking",
                Details = $"Cancelled booking for event: {ev?.Title}"
            };
            _context.UserLogs.Add(log);
        }

        _context.Bookings.Remove(booking);
        _context.SaveChanges();

        return Ok(new { message = "Booking cancelled successfully" });
    }
}
