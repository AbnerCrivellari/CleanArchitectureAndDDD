using System;
using System.Collections.Generic;
using System.Text;
using ThisneyTicket.Domain.Model;

namespace ThisneyTicket.Domain.Interface
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
    }
}
