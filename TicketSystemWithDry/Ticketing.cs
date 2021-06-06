using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemWithDry
{
    public class Ticketing
    {
        public string PrintTicket(string type, int id)
        {
            var print = ($"Your {1} Ticket id is {0}", type , id);
            return print.ToString();
        }
    }
}
