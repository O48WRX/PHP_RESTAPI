using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTMovie
{
    class Movie
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Movie(int id, string title)
        {
            this.Id = id;
            this.Title = title;
        }

        public Movie()
        {

        }
    }
}
