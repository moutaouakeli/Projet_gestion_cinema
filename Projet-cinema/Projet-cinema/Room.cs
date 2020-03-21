using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_cinema
{
    public class Room
    {
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string cinema_id;

        public string Cinema_id
        {
            get { return cinema_id; }
            set { cinema_id = value; }
        }



        public Room(int number, int capacity,string name, string cinema_id)
        {
            this.number = number;
            this.capacity = capacity;
            this.name = name;
            this.cinema_id = cinema_id;

        }


    }
}
