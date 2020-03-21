using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_cinema
{
    public class Cinema
    {
        private string name;
        private string address;
        private DateTime openingTime;
        private string CP;
        private string locality;

        //private List<Salle> lstSalle;


        public string Name
        {
            get { return name; }
            
        }
       /* public Cinema(string nom, string adresse, DateTime horraire)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.horraire = horraire;
            //lstSalle = new List<Salle>();

        }*/
        public string AfficherInfo()
        {
            return name + ", " + address + ", " + openingTime;
        }
    }
}
