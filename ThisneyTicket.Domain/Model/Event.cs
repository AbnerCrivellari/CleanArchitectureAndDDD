using System;
using System.Collections.Generic;
using System.Text;

namespace ThisneyTicket.Domain.Model
{
    public class Event : Base
    {

        public string Name { get; private set; }
        public string Photo { get; private set; }
        public int TypeEvent { get; private set; }
        public int Quantity { get; private set; }
        public string Description { get; private set; }
        public bool Blocked { get; private set; }
        public DateTime Date { get; private set; }
        public IList<Ticket> Ticket { get; set; }

        protected Event() { }

        public Event(string name, string photo, int type, int quantity, bool blocked, string description, DateTime date)
        {
            Name = name;
            Photo = photo;
            TypeEvent = type;
            Quantity = quantity;
            Blocked = blocked;
            Description = description;
            Date = date;
        }
        
    }
}
