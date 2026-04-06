using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization; 
using AutoMapper;

[ApiController]
[Route("api/events")]
public class EventsController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public EventsController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    

   [Authorize(Roles = "Admin")]
[HttpPost]
public IActionResult CreateEvent(EventDto dto)
{
    var ev = new Event
    {
        Title = dto.Title,
        Description = dto.Description,
        Date = dto.Date,
        Location = dto.Location,
        AvailableSeats = dto.AvailableSeats
    };

    _context.Events.Add(ev);
    _context.SaveChanges();

    return Ok(new { message = "Event Created Successfully", eventId = ev.Id });
}

    [HttpGet]
    public IActionResult GetEvents()
    {
        var events = _context.Events.ToList();
        return Ok(_mapper.Map<List<EventDto>>(events));
    }
}