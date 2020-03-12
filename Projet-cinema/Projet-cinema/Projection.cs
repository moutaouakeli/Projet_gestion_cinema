using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_cinema
{
    public class Projection
    {
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private DateTime dateEcheance;

        public DateTime DateEcheance
        {
            get { return dateEcheance; }
            set { dateEcheance = value; }
        }

        private string qualite;

        public string Qualite
        {
            get { return qualite; }
            //set { qualite = value; }
        }

        private List<Film> lstfilm;

        public List<Film> Lstfilm
        {
            get { return lstfilm; }
            set { lstfilm = value; }
        }

        public Projection(DateTime date,DateTime dateEcheance,string qualite, List<Film> lstfilm)
        {
            this.date = date;
            this.dateEcheance = dateEcheance;
            this.qualite = qualite;

        }
        public void AjouterFilm(Film film)
        {


        }
        public void ModifierFilm(Film film)
        {


        }
        public void SupprimerFilm(Film film)
        {


        }

        
    }
}
