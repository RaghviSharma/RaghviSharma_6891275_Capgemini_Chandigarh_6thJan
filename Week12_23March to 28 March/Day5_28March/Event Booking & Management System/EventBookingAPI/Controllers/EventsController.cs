using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EventBookingAPI.DTOs;
using EventBookingAPI.Services;

namespace EventBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventService _eventService;
        private readonly ILogger<EventsController> _logger;

        public EventsController(IEventService eventService, ILogger<EventsController> logger)
        {
            _eventService = eventService;
            _logger = logger;
        }

        /// <summary>
        /// Get all events
        /// </summary>
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<EventDto>>> GetAllEvents()
        {
            try
            {
                var events = await _eventService.GetAllEventsAsync();
                return Ok(events);
            }
            catch (Exception ex)
            {
                _logger.LogError($"GetAllEvents error: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Get event by id
        /// </summary>
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<EventDto>> GetEventById(int id)
        {
            try
            {
                var eventItem = await _eventService.GetEventByIdAsync(id);
                return Ok(eventItem);
            }
            catch (Exception ex)
            {
                _logger.LogError($"GetEventById error: {ex.Message}");
                return NotFound("Event not found");
            }
        }

        /// <summary>
        /// Create a new event (Admin only)
        /// </summary>
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<EventDto>> CreateEvent(CreateEventDto createEventDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var eventItem = await _eventService.CreateEventAsync(createEventDto);
                return CreatedAtAction(nameof(GetEventById), new { id = eventItem.Id }, eventItem);
            }
            catch (Exception ex)
            {
                _logger.LogError($"CreateEvent error: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Update an event (Admin only)
        /// </summary>
        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<EventDto>> UpdateEvent(int id, UpdateEventDto updateEventDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var eventItem = await _eventService.UpdateEventAsync(id, updateEventDto);
                return Ok(eventItem);
            }
            catch (Exception ex)
            {
                _logger.LogError($"UpdateEvent error: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Delete an event (Admin only)
        /// </summary>
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult> DeleteEvent(int id)
        {
            try
            {
                var result = await _eventService.DeleteEventAsync(id);
                if (!result)
                {
                    return NotFound("Event not found");
                }
                return Ok("Event deleted successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError($"DeleteEvent error: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
