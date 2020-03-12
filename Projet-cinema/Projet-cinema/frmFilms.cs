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
    public partial class frmFilms : Form
    {

        public Film film;
        public frmFilms()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        
        int index;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterFilm_Click(object sender, EventArgs e)
        {
            



        }

        private void tlbListeFilm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmFilms_Load(object sender, EventArgs e)
        {
            

            //En-têtes
            table.Columns.Add("Nom du film", typeof(string));
            table.Columns.Add("Réalisateur", typeof(string));
            table.Columns.Add("Acteurs", typeof(string));
            table.Columns.Add("Description", typeof(string));


            // Pour faire le test des fonctionnalités (Ajout, supression et modification)
            table.Rows.Add("Film1", "Réalisateur1", "Acteur1", "Description1");
            table.Rows.Add("Film2", "Réalisateur2", "Acteur2", "Description2");
            table.Rows.Add("Film3", "Réalisateur3", "Acteur3", "Description3");
            table.Rows.Add("Film4", "Réalisateur4", "Acteur4", "Description4");

            dgvListeFilms.DataSource = table;
        }

        private void txtActeurs_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvListeFilms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAjouterFilm_Click_1(object sender, EventArgs e)
        {
            table.Rows.Add(txtNomFilm.Text,txtRealisateur.Text,txtActeurs.Text,txtDescription.Text);


        }

        private void dgvListeFilms_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dgvListeFilms_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Mettre les valeurs de la ligne qui est selectionnée dans les cases vide et qui correspondent à la valeur du titre

             index = e.RowIndex;
            DataGridViewRow selectesRow = dgvListeFilms.Rows[index];
            txtNomFilm.Text = selectesRow.Cells[0].Value.ToString();
            txtRealisateur.Text = selectesRow.Cells[1].Value.ToString();
            txtActeurs.Text = selectesRow.Cells[2].Value.ToString();
            txtDescription.Text = selectesRow.Cells[3].Value.ToString();




        }

        private void btnModifierFilm_Click(object sender, EventArgs e)
        {
            DataGridViewRow  newRows = dgvListeFilms.Rows[index];
            newRows.Cells[0].Value = txtNomFilm.Text;
            newRows.Cells[1].Value = txtRealisateur.Text;
            newRows.Cells[2].Value = txtActeurs.Text;
            newRows.Cells[3].Value = txtDescription.Text;

        }

        private void btnSupprimerFilm_Click(object sender, EventArgs e)
        {
            index = dgvListeFilms.CurrentCell.RowIndex;
            dgvListeFilms.Rows.RemoveAt(index);
        }
    }
}
