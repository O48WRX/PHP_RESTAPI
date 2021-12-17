using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTMovie
{
    class Tickets
    {
        private int ticketId;

        public int TicketId
        {
            get { return ticketId; }
            set { ticketId = value; }
        }

        private int movieId;

        public int MovieId
        {
            get { return movieId; }
            set { movieId = value; }
        }

        private string movieTitle;

        public string MovieTitle
        {
            get { return movieTitle; }
            set { movieTitle = value; }
        }

        private string streamTime;

        public string StreamTime
        {
            get { return streamTime; }
            set { streamTime = value; }
        }

        public Tickets()
        {

        }


    }
}
