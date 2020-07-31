using System;
using System.Collections.Generic;
using System.Text;
using ThisneyTicket.Domain.Utilities;

namespace ThisneyTicket.Application.ViewModel
{
    public class EventViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public Enums.EventType TypeEvent { get; set; }
        public bool Blocked { get; set; }
        public DateTime Date { get; set; }
        public void ValidateInformation()
        {
            if (string.IsNullOrEmpty(Name))
                throw new ArgumentException("The event name cannot be null.");
            if (Quantity <= 0)
                throw new ArgumentException("The quantity has to be more than 0.");
            if (string.IsNullOrEmpty(Description))
                throw new ArgumentException("The event Description cannot be null.");
        }
    }
}
