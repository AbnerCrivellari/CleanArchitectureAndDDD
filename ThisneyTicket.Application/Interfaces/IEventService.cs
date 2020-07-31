using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ThisneyTicket.Application.ViewModel;
using ThisneyTicket.Domain.Model;

namespace ThisneyTicket.Application.Interfaces
{
    public interface IEventService
    {
        Task<IEnumerable<EventViewModel>> GetAll();
        Task<EventViewModel> GetById(int id);
        Task<EventViewModel> Create(EventViewModel eventView);
        Task<EventViewModel> Update(EventViewModel eventView);
        void Delete(EventViewModel eventView);
    }
}
