﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTMovie
{
    public class User
    {
        public User()
        {

        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private int isadmin;

        public int isAdmin
        {
            get { return isadmin; }
            set { isadmin = value; }
        }

        public User(int id, string name, string password, int isadmin)
        {
            this.Id = id;
            this.Name = name;
            this.Password = password;
            this.isAdmin = isadmin;
        }

    }
}
