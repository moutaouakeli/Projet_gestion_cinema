﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_cinema
{
    public class Actor
    {
        private string firstname;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        private string lastname;

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public Actor(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;

        }

        
    }
}
