using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem
{
    public class ConferenceTicket
    {
        public int ConferenceId { get; set; }
        public string Conferencename { get; set; }
        public decimal Price { get; set; }
        public string[] Presenters { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Genre { get; set; }
    }
}
