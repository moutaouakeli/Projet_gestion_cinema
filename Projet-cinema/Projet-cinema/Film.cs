using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_cinema
{
    public class Film
    {
        private string name;
        //private List<Acteur> lstActeur;
        //private Acteur acteur;
        

        private DBconnection dbcinema = new DBconnection();
       

        private string producer;

        public string Producer_id
        {
            get { return producer; }
            set { producer = value; }
        }

        


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

       
       /* public Film(string nom, string description)
        {
            this.nom = nom;
            this.description = description;
            lstActeur = new List<Acteur>();

        }*/
       
        

    }
}
