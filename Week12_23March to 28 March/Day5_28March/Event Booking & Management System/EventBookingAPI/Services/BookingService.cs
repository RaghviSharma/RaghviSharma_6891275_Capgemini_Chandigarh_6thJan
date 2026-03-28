using EventBookingAPI.Data;
using EventBookingAPI.DTOs;
using EventBookingAPI.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EventBookingAPI.Services
{
    public interface IBookingService
    {
        Task<BookingDto> CreateBookingAsync(string userId, CreateBookingDto createBookingDto);
        Task<List<BookingDto>> GetUserBookingsAsync(string userId);
        Task<BookingDto> GetBookingByIdAsync(int id);
        Task<bool> CancelBookingAsync(int id);
        Task<bool> IsSeatsAvailableAsync(int eventId, int seatsRequested);
    }

    public class BookingService : IBookingService
    {
        private readonly EventBookingDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<BookingService> _logger;

        public BookingService(EventBookingDbContext context, IMapper mapper, ILogger<BookingService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<BookingDto> CreateBookingAsync(string userId, CreateBookingDto createBookingDto)
        {
            try
            {
                // Get event
                var eventItem = await _context.Events.FirstOrDefaultAsync(e => e.Id == createBookingDto.EventId);
                if (eventItem == null)
                {
                    throw new Exception("Event not found");
                }

                // Check available seats
                int remainingSeats = eventItem.AvailableSeats - eventItem.BookedSeats;
                if (remainingSeats < createBookingDto.SeatsBooked)
                {
                    throw new Exception($"Only {remainingSeats} seats available");
                }

                // Create booking
                var booking = new Booking
                {
                    EventId = createBookingDto.EventId,
                    UserId = userId,
                    SeatsBooked = createBookingDto.SeatsBooked,
                    TotalPrice = eventItem.Price * createBookingDto.SeatsBooked,
                    Status = BookingStatus.Confirmed
                };

                // Update event booked seats
                eventItem.BookedSeats += createBookingDto.SeatsBooked;

                _context.Bookings.Add(booking);
                _context.Events.Update(eventItem);
                await _context.SaveChangesAsync();

                return _mapper.Map<BookingDto>(booking);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Create booking error: {ex.Message}");
                throw;
            }
        }

        public async Task<List<BookingDto>> GetUserBookingsAsync(string userId)
        {
            try
            {
                var bookings = await _context.Bookings
                    .Where(b => b.UserId == userId && b.Status != BookingStatus.Cancelled)
                    .Include(b => b.Event)
                    .ToListAsync();

                return _mapper.Map<List<BookingDto>>(bookings);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Get user bookings error: {ex.Message}");
                throw;
            }
        }

        public async Task<BookingDto> GetBookingByIdAsync(int id)
        {
            try
            {
                var booking = await _context.Bookings
                    .Include(b => b.Event)
                    .FirstOrDefaultAsync(b => b.Id == id);

                if (booking == null)
                {
                    throw new Exception("Booking not found");
                }

                return _mapper.Map<BookingDto>(booking);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Get booking error: {ex.Message}");
                throw;
            }
        }

        public async Task<bool> CancelBookingAsync(int id)
        {
            try
            {
                var booking = await _context.Bookings.FirstOrDefaultAsync(b => b.Id == id);
                if (booking == null)
                {
                    return false;
                }

                if (booking.Status == BookingStatus.Cancelled)
                {
                    throw new Exception("Booking is already cancelled");
                }

                // Update event booked seats
                var eventItem = await _context.Events.FirstOrDefaultAsync(e => e.Id == booking.EventId);
                if (eventItem != null)
                {
                    eventItem.BookedSeats = Math.Max(0, eventItem.BookedSeats - booking.SeatsBooked);
                    _context.Events.Update(eventItem);
                }

                booking.Status = BookingStatus.Cancelled;
                _context.Bookings.Update(booking);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Cancel booking error: {ex.Message}");
                throw;
            }
        }

        public async Task<bool> IsSeatsAvailableAsync(int eventId, int seatsRequested)
        {
            try
            {
                var eventItem = await _context.Events.FirstOrDefaultAsync(e => e.Id == eventId);
                if (eventItem == null)
                {
                    return false;
                }

                int remainingSeats = eventItem.AvailableSeats - eventItem.BookedSeats;
                return remainingSeats >= seatsRequested;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Is seats available error: {ex.Message}");
                return false;
            }
        }
    }
}
