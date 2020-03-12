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
        private List<Acteur> lstActeur;
        private Acteur acteur;
       
        

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
        public void AjouterFilm(string nom, string description, string acteur, string realisateur)
        {
            //string infoActeur= acteur.Nom + acteur.Prenom;

             
           
            



        }
        public void ModifierFilm()
        {
           

        }
        public void SupprimerFilm()
        {


        }
        

    }
}
