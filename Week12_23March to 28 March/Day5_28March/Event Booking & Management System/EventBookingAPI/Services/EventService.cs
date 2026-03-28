using EventBookingAPI.Data;
using EventBookingAPI.DTOs;
using EventBookingAPI.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EventBookingAPI.Services
{
    public interface IEventService
    {
        Task<List<EventDto>> GetAllEventsAsync();
        Task<EventDto> GetEventByIdAsync(int id);
        Task<EventDto> CreateEventAsync(CreateEventDto createEventDto);
        Task<EventDto> UpdateEventAsync(int id, UpdateEventDto updateEventDto);
        Task<bool> DeleteEventAsync(int id);
    }

    public class EventService : IEventService
    {
        private readonly EventBookingDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<EventService> _logger;

        public EventService(EventBookingDbContext context, IMapper mapper, ILogger<EventService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<List<EventDto>> GetAllEventsAsync()
        {
            try
            {
                var events = await _context.Events.ToListAsync();
                return _mapper.Map<List<EventDto>>(events);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Get all events error: {ex.Message}");
                throw;
            }
        }

        public async Task<EventDto> GetEventByIdAsync(int id)
        {
            try
            {
                var eventItem = await _context.Events.FirstOrDefaultAsync(e => e.Id == id);
                if (eventItem == null)
                {
                    throw new Exception("Event not found");
                }
                return _mapper.Map<EventDto>(eventItem);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Get event by id error: {ex.Message}");
                throw;
            }
        }

        public async Task<EventDto> CreateEventAsync(CreateEventDto createEventDto)
        {
            try
            {
                var eventItem = _mapper.Map<Event>(createEventDto);
                _context.Events.Add(eventItem);
                await _context.SaveChangesAsync();
                return _mapper.Map<EventDto>(eventItem);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Create event error: {ex.Message}");
                throw;
            }
        }

        public async Task<EventDto> UpdateEventAsync(int id, UpdateEventDto updateEventDto)
        {
            try
            {
                var eventItem = await _context.Events.FirstOrDefaultAsync(e => e.Id == id);
                if (eventItem == null)
                {
                    throw new Exception("Event not found");
                }

                _mapper.Map(updateEventDto, eventItem);
                _context.Events.Update(eventItem);
                await _context.SaveChangesAsync();
                return _mapper.Map<EventDto>(eventItem);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Update event error: {ex.Message}");
                throw;
            }
        }

        public async Task<bool> DeleteEventAsync(int id)
        {
            try
            {
                var eventItem = await _context.Events.FirstOrDefaultAsync(e => e.Id == id);
                if (eventItem == null)
                {
                    return false;
                }

                _context.Events.Remove(eventItem);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Delete event error: {ex.Message}");
                throw;
            }
        }
    }
}
