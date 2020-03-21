using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

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
        DBconnection conn = new DBconnection();
        
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

            DBconnection conn = new DBconnection();
            SQLiteDataReader reader = conn.GetFilms();
          
            while (reader.Read())
            {
                table.Rows.Add(reader[0].ToString(), reader[1].ToString()+" "+ reader[2].ToString(), reader[3].ToString()+" "+ reader[4].ToString(), reader[5].ToString());
                //name = reader["firstname" + " " + "lastname"].ToString();
            }
            // Pour faire le test des fonctionnalités (Ajout, supression et modification)
            /*table.Rows.Add("Film1", "Réalisateur1", "Acteur1", "Description1");
            table.Rows.Add("Film2", "Réalisateur2", "Acteur2", "Description2");
            table.Rows.Add("Film3", "Réalisateur3", "Acteur3", "Description3");
            table.Rows.Add("Film4", "Réalisateur4", "Acteur4", "Description4");*/

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

            
            DBconnection conn = new DBconnection();
            conn.AddFilm(txtNameFilm.Text, txtDescription.Text, txtProducer.Text, txtActors.Text );
            table.Rows.Add(txtNameFilm.Text,txtProducer.Text,txtActors.Text,txtDescription.Text);

            //conn.GetFilmsName(txtProducer.Text);

         //conn.AddFilm(txtNameFilm.Text,txtDescription.Text,txtProducer.text );

        }

        private void dgvListeFilms_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dgvListeFilms_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Mettre les valeurs de la ligne qui est selectionnée dans les cases vide et qui correspondent à la valeur du titre

             index = e.RowIndex;
            DataGridViewRow selectesRow = dgvListeFilms.Rows[index];
            txtNameFilm.Text = selectesRow.Cells[0].Value.ToString();
            txtProducer.Text = selectesRow.Cells[1].Value.ToString();
            txtActors.Text = selectesRow.Cells[2].Value.ToString();
            txtDescription.Text = selectesRow.Cells[3].Value.ToString();
            DBconnection conn = new DBconnection();
            conn.RemoveFilms(txtNameFilm.Text);




        }

        private void btnModifierFilm_Click(object sender, EventArgs e)
        {
            DBconnection conn = new DBconnection();
            DataGridViewRow  newRows = dgvListeFilms.Rows[index];
            newRows.Cells[0].Value = txtNameFilm.Text;
            newRows.Cells[1].Value = txtProducer.Text;
            newRows.Cells[2].Value = txtActors.Text;
            newRows.Cells[3].Value = txtDescription.Text;
            conn.UpdateFilms(txtNameFilm.Text, txtDescription.Text, txtProducer.Text, txtActors.Text);

        }

        private void btnSupprimerFilm_Click(object sender, EventArgs e)
        {
            DBconnection conn = new DBconnection();
            conn.RemoveFilms(dgvListeFilms.CurrentCell.Value.ToString());
            index = dgvListeFilms.CurrentCell.RowIndex;
            dgvListeFilms.Rows.RemoveAt(index);

        }

        private void txtNomFilm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
