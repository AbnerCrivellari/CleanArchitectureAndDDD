using AutoMapper;
using ThisneyTicket.Application.ViewModel;
using ThisneyTicket.Domain.Model;

namespace ThisneyTicket.Application.AutoMapper
{
    public class DomainToViewMappingProfile : Profile
    {
        public DomainToViewMappingProfile()
        {   
            CreateMap<Event, EventViewModel>();
        }
    }
}
