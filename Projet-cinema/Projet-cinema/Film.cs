using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_cinema
{
    public class Film
    {
        private string nom;
        //private List<Acteur> lstActeur;
        private Acteur acteur;
        

        private DBconnection dbcinema = new DBconnection();
       

        private string realisateur;

        public string Realisateur
        {
            get { return realisateur; }
            set { realisateur = value; }
        }

        


        public string Nom
        {
            get { return nom; }
            set { nom = value; }
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
