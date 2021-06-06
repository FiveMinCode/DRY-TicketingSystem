using System;

namespace TicketingSystem
{
    public class MovieTicket
    {
        public int MovieId { get; set; }
        public string Moviename { get; set; }
        public decimal Price { get; set; }
        public string[] Artists { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Genre { get; set; }
    }
}
