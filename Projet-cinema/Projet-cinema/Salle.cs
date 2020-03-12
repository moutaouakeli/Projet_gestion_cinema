using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_cinema
{
    public class Salle
    {
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private int nbplaces;

        public int Nbplaces
        {
            get { return nbplaces; }
            set { nbplaces = value; }
        }

        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }


        public Salle(int numero, int nbplaces,string nom)
        {
            this.numero = numero;
            this.nbplaces = nbplaces;
            this.nom = nom;

        }


    }
}
