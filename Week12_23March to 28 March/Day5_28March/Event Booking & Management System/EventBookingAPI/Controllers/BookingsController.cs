using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using EventBookingAPI.DTOs;
using EventBookingAPI.Services;

namespace EventBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly ILogger<BookingsController> _logger;

        public BookingsController(IBookingService bookingService, ILogger<BookingsController> logger)
        {
            _bookingService = bookingService;
            _logger = logger;
        }

        /// <summary>
        /// Create a new booking
        /// </summary>
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<BookingDto>> CreateBooking(CreateBookingDto createBookingDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized("User not authenticated");
                }

                // Validate seats
                if (createBookingDto.SeatsBooked <= 0 || createBookingDto.SeatsBooked > 100)
                {
                    return BadRequest("Invalid number of seats");
                }

                var booking = await _bookingService.CreateBookingAsync(userId, createBookingDto);
                return CreatedAtAction(nameof(GetBookingById), new { id = booking.Id }, booking);
            }
            catch (Exception ex)
            {
                _logger.LogError($"CreateBooking error: {ex.Message}");
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Get user's bookings
        /// </summary>
        [HttpGet("my-bookings")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<BookingDto>>> GetUserBookings()
        {
            try
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized("User not authenticated");
                }

                var bookings = await _bookingService.GetUserBookingsAsync(userId);
                return Ok(bookings);
            }
            catch (Exception ex)
            {
                _logger.LogError($"GetUserBookings error: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Get booking by id
        /// </summary>
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<BookingDto>> GetBookingById(int id)
        {
            try
            {
                var booking = await _bookingService.GetBookingByIdAsync(id);
                return Ok(booking);
            }
            catch (Exception ex)
            {
                _logger.LogError($"GetBookingById error: {ex.Message}");
                return NotFound("Booking not found");
            }
        }

        /// <summary>
        /// Cancel a booking
        /// </summary>
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult> CancelBooking(int id)
        {
            try
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized("User not authenticated");
                }

                var result = await _bookingService.CancelBookingAsync(id);
                if (!result)
                {
                    return NotFound("Booking not found");
                }

                return Ok("Booking cancelled successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError($"CancelBooking error: {ex.Message}");
                return StatusCode(500, ex.Message);
            }
        }
    }
}
