using System;

namespace TicketSystemWithDry
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string[] Presenters { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Genre { get; set; }
    }
}
