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
    }
}
