using AutoMapper;
using Domain.Entities;
using WebUi.Controllers;
using WebUi.Models;

namespace WebUi.Infrastructure
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Escort, HomeViewItem>();
            CreateMap<Escort, ProfileViewModel>();
            CreateMap<Escort, BookingViewItem>();
        }
    }
}
