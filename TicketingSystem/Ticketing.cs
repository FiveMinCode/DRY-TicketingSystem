using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem
{
    public class Ticketing
    {
        public string PrintTicket(string type, int id)
        {
            if (type == "Movie")
            {
                var print = ($"Your Movie Ticket id is {0}", id);
                return print.ToString();
            }

            if (type == "Conference")
            {
                var print = ($"Your Conference Ticket id is {0}", id);
                return print.ToString();
            }

            if (type == "Event")
            {
                var print = ($"Your Event Ticket id is {0}", id);
                return print.ToString();
            }

            return null;
        }
    }
}
