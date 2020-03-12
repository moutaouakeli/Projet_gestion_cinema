using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_cinema
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBillets frmBillets = new frmBillets();
            frmBillets.Show();
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            frmFilms frmFilms = new frmFilms();
            frmFilms.Show();
        }

        private void btnProjection_Click(object sender, EventArgs e)
        {
            frmProjections frmProjections = new frmProjections();
            frmProjections.Show();
        }

        private void btnRecette_Click(object sender, EventArgs e)
        {
            frmRecette frmRecette = new frmRecette();
            frmRecette.Show();
        }
    }
}
