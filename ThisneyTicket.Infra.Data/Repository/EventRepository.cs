using System;
using System.Collections.Generic;
using System.Text;
using ThisneyTicket.Domain.Interface;
using ThisneyTicket.Domain.Model;
using ThisneyTicket.Infra.Data.Config;
using ThisneyTicket.Infra.Data.Context;

namespace ThisneyTicket.Infra.Data.Repository
{
    public class EventRepository : GenericRepository<Event>, IEventRepository
    {
        public EventRepository(BaseContext dbContext) : base(dbContext)
        {
        }
    }
}
