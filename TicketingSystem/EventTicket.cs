using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem
{
    public class EventTicket
    {
        public int EventId { get; set; }
        public string Eventname { get; set; }
        public decimal Price { get; set; }
        public string[] Organisers { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Genre { get; set; }
    }
}
