﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_cinema
{
    public class Billet
    {
        private DateTime date;
        private Price tarif;
        private Rabais rabais;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private int quantite;

        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }

        
        public Billet(DateTime date, int quantite, Price tarif, Rabais rabais)
        {
            this.date = date;
            this.quantite = quantite;
            this.tarif = tarif;
            this.rabais = rabais;

        }
        public void AchatBillet(Price tarif,Rabais rabais)
        {


        }

    }
}
