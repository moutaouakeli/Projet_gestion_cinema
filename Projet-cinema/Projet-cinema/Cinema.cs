using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_cinema
{
    public class Cinema
    {
        private string nom;
        private string adresse;
        private DateTime horraire;
        private string CP;
        private string localisation;

        private List<Salle> lstSalle;


        public string Nom
        {
            get { return nom; }
            
        }
        public Cinema(string nom, string adresse, DateTime horraire)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.horraire = horraire;
            lstSalle = new List<Salle>();

        }
        public string AfficherInfo()
        {
            return nom + ", " + adresse + ", " + horraire;
        }
    }
}
