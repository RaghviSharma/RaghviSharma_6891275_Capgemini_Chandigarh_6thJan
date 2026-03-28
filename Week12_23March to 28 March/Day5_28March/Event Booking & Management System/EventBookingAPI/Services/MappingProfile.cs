using AutoMapper;
using EventBookingAPI.DTOs;
using EventBookingAPI.Models;

namespace EventBookingAPI.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Event mappings
            CreateMap<Event, EventDto>().ReverseMap();
            CreateMap<CreateEventDto, Event>();
            CreateMap<UpdateEventDto, Event>();

            // Booking mappings
            CreateMap<Booking, BookingDto>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()))
                .ForMember(dest => dest.Event, opt => opt.MapFrom(src => src.Event));
            CreateMap<CreateBookingDto, Booking>();

            // Auth mappings
            CreateMap<RegisterDto, AppUser>();
            CreateMap<AppUser, AuthResponseDto>();
        }
    }
}
