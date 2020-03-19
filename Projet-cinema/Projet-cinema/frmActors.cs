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
    public partial class frmActors : Form
    {
        public frmActors()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstActors.Items.Add("Acteur1");
            lstActors.Items.Add("Acteur2");
            lstActors.Items.Add("Acteur3");
            lstActors.Items.Add("Acteur4");
            lstActors.Items.Add("Acteur5");
            lstActors.Items.Add("Acteur6");
            
        }
    }
}
