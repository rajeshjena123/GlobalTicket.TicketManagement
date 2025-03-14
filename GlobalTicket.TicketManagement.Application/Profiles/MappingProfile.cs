using AutoMapper;
using GlobalTicket.TicketManagement.Application.Features.Categories.Quries.GetCategoryList;
using GlobalTicket.TicketManagement.Application.Features.Categories.Quries.GetCategpriesListWithEvent;
using GlobalTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using GlobalTicket.TicketManagement.Application.Features.Events.Queries.GetEventList;
using GlobalTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<Category, CategoryListVm>().ReverseMap();
            CreateMap<Category, CategoryEventListVm>().ReverseMap();
        }
    }
}
