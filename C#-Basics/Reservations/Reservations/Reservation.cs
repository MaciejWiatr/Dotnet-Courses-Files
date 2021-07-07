using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class Reservation
    {
        public DateTime From;
        public DateTime To;

        public Reservation(DateTime @from, DateTime to)
        {
            From = @from;
            To = to;
        }
    }
}
