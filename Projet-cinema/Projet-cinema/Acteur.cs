using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_cinema
{
    public class Acteur
    {
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public Acteur(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;

        }

        
    }
}
