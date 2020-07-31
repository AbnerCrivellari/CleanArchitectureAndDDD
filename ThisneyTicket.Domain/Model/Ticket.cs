using System;
using System.Collections.Generic;
using System.Text;

namespace ThisneyTicket.Domain.Model
{
    public class Ticket: Base
    {
        public Guid Code { get; private set; }
        public int EventId { get; private set; }
        public int UserId { get; private set; }
        public User User { get; set; }
        public Event Event { get; set; }

        protected Ticket() { }
        public Ticket(Guid code, int eventId, int userId)
        {
            Code = code;
            EventId = eventId;
            UserId = userId;
        }
    }
}
