using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTMovie
{
    class SoldTicket
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int ticketid;

        public int TicketId
        {
            get { return ticketid; }
            set { ticketid = value; }
        }

        private int userid;

        public int UserId
        {
            get { return userid; }
            set { userid = value; }
        }

        public SoldTicket()
        {

        }
    }
}
