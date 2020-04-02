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
        

        private void frmFilms_Load(object sender, EventArgs e)
        {

            //En-têtes
            //dgvListeFilms.Columns[1].Name = "id";
           /* table.Columns[0].Name = "Nom";
            table.Columns[1].Name = "Prénom du réalisateur";
            table.Columns[2].Name = "Nom du réalisateur";
            dgvListeFilms.Columns[3].Name = "Prénom de l'acteur";
            dgvListeFilms.Columns[4].Name = "Nom de l'acteur";
            dgvListeFilms.Columns[5].Name = "Description";*/

            /*table.Columns[0].ColumnName = "Nom";
            table.Columns[1].ColumnName = "Prénom du réalisateur";
            table.Columns[2].ColumnName = "Nom du réalisateur";
            table.Columns[3].ColumnName = "Prénom de l'acteur";
            table.Columns[4].ColumnName = "Nom de l'acteur";
            table.Columns[5].ColumnName = "Description";*/


            dgvListeFilms.ReadOnly = true;
            dgvListeFilms.AllowUserToAddRows = false;
            dgvListeFilms.AllowUserToDeleteRows = false;
            dgvListeFilms.AllowUserToOrderColumns = false;
            dgvListeFilms.AllowUserToResizeColumns = false;
            dgvListeFilms.AllowUserToResizeRows = false;

            // table.Columns.Add("id", typeof(int));
            table.Columns.Add("ID ", typeof(string));
            table.Columns.Add("Nom du film", typeof(string));
            table.Columns.Add("Nom du réalisateur", typeof(string));
            table.Columns.Add("Prénom du réalisateur", typeof(string));
            table.Columns.Add("Nom d'acteur", typeof(string));
            table.Columns.Add("Prénom d'acteur", typeof(string));
            table.Columns.Add("Description", typeof(string));

            DBconnection conn = new DBconnection();
            SQLiteDataReader reader = conn.GetFilms();

            string id = "";
            int i = 1;
            while (reader.Read())
            {
                if (id != reader[0].ToString())
                {
                    i = 1;
                    table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), i.ToString() + "." + reader[4].ToString(), i.ToString() + "." + reader[5].ToString(), reader[6].ToString());
                    dgvListeFilms.DataSource = table;
                }
                else
                {
                    index = dgvListeFilms.Rows.Count - 1;
                    i++;
                    //Console.WriteLine(dgvListeFilms.Rows[1].Cells[1].Value.ToString());
                    dgvListeFilms.Rows[index].Cells[4].Value = dgvListeFilms.Rows[index].Cells[4].Value + " | " + i.ToString() + "." + reader[4].ToString();
                    dgvListeFilms.Rows[index].Cells[5].Value = dgvListeFilms.Rows[index].Cells[5].Value + " | " + i.ToString() + "." + reader[5].ToString();
                    //newRows.Cells[4].Value = newRows.Cells[4].Value + reader[4].ToString();
                    //newRows.Cells[5].Value = newRows.Cells[5].Value + reader[5].ToString();
                }

                id = reader[0].ToString();
            }


            // Pour faire le test des fonctionnalités (Ajout, supression et modification)
            /*table.Rows.Add("Film1", "Réalisateur1", "Acteur1", "Description1");
            table.Rows.Add("Film2", "Réalisateur2", "Acteur2", "Description2");
            table.Rows.Add("Film3", "Réalisateur3", "Acteur3", "Description3");
            table.Rows.Add("Film4", "Réalisateur4", "Acteur4", "Description4");*/

            //dgvListeFilms.DataSource = table;

            
        }

        

       

        private void btnAjouterFilm_Click_1(object sender, EventArgs e)
        {

            
            DBconnection conn = new DBconnection();
            conn.AddFilm(txtNameFilm.Text, txtDescription.Text, txtFnameProducer.Text,txtLnameProducer.Text, txtFnameActors.Text,txtLnameActors.Text );
            //table.Rows.Add(txtNameFilm.Text, txtLnameProducer.Text, txtFnameProducer.Text, txtLnameActors.Text, txtFnameActors.Text,  txtDescription.Text);
            table = new DataTable();
            // table.Columns.Add("id", typeof(int));
            table.Columns.Add("ID Film", typeof(string));
            table.Columns.Add("Nom du film", typeof(string));
            table.Columns.Add("Nom du réalisateur", typeof(string));
            table.Columns.Add("Prénom du réalisateur", typeof(string));
            table.Columns.Add("Nom d'acteur", typeof(string));
            table.Columns.Add("Prénom d'acteur", typeof(string));
            table.Columns.Add("Description", typeof(string));
            SQLiteDataReader reader = conn.GetFilms();
            string id = "";
            int i = 1;
            while (reader.Read())
            {
                if (id != reader[0].ToString())
                {
                    i = 1;
                    table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), i.ToString() + "." + reader[4].ToString(), i.ToString() + "." + reader[5].ToString(), reader[6].ToString());
                    dgvListeFilms.DataSource = table;
                }
                else
                {
                    index = dgvListeFilms.Rows.Count - 1;
                    i++;
                    //Console.WriteLine(dgvListeFilms.Rows[1].Cells[1].Value.ToString());
                    dgvListeFilms.Rows[index].Cells[4].Value = dgvListeFilms.Rows[index].Cells[4].Value + " | " + i.ToString() + "." + reader[4].ToString();
                    dgvListeFilms.Rows[index].Cells[5].Value = dgvListeFilms.Rows[index].Cells[5].Value + " | " + i.ToString() + "." + reader[5].ToString();
                    //newRows.Cells[4].Value = newRows.Cells[4].Value + reader[4].ToString();
                    //newRows.Cells[5].Value = newRows.Cells[5].Value + reader[5].ToString();
                }

                id = reader[0].ToString();
            }




            //conn.GetFilmsName(txtProducer.Text);

            //conn.AddFilm(txtNameFilm.Text,txtDescription.Text,txtProducer.text );

        }

        

        private void dgvListeFilms_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Mettre les valeurs de la ligne qui est selectionnée dans les cases vide et qui correspondent à la valeur du titre

             index = e.RowIndex;
            DataGridViewRow selectesRow = dgvListeFilms.Rows[index];
            txtNameFilm.Text = selectesRow.Cells[1].Value.ToString();
            txtFnameProducer.Text = selectesRow.Cells[2].Value.ToString();
            txtLnameProducer.Text = selectesRow.Cells[3].Value.ToString();
            txtFnameActors.Text = selectesRow.Cells[4].Value.ToString();
            txtLnameActors.Text = selectesRow.Cells[5].Value.ToString();
            txtDescription.Text = selectesRow.Cells[6].Value.ToString();
            DBconnection conn = new DBconnection();
            //conn.RemoveFilms(txtNameFilm.Text);




        }

        private void btnModifierFilm_Click(object sender, EventArgs e)
        {
            DBconnection conn = new DBconnection();
            DataGridViewRow  newRows = dgvListeFilms.Rows[index];
            newRows.Cells[1].Value = txtNameFilm.Text;
            newRows.Cells[2].Value = txtFnameProducer.Text;
            newRows.Cells[3].Value = txtLnameProducer.Text;
            newRows.Cells[4].Value = txtFnameActors.Text;
            newRows.Cells[5].Value = txtLnameActors.Text;
            newRows.Cells[6].Value = txtDescription.Text;
            //conn.UpdateFilms(txtNameFilm.Text, txtDescription.Text, txtFnameProducer.Text, txtLnameProducer.Text, txtFnameActors.Text, txtLnameActors.Text);

        }

        private void btnSupprimerFilm_Click(object sender, EventArgs e)
        {
            DBconnection conn = new DBconnection();
            conn.RemoveFilms(dgvListeFilms.CurrentCell.Value.ToString());
            index = dgvListeFilms.CurrentCell.RowIndex;
            dgvListeFilms.Rows.RemoveAt(index);

        }

        private void btnAddActors_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            // table.Columns.Add("id", typeof(int));
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Nom du film", typeof(string));
            table.Columns.Add("Nom du réalisateur", typeof(string));
            table.Columns.Add("Prénom du réalisateur", typeof(string));
            table.Columns.Add("Nom d'acteur", typeof(string));
            table.Columns.Add("Prénom d'acteur", typeof(string));
            table.Columns.Add("Description", typeof(string));
            DBconnection conn = new DBconnection();
            conn.AddActors(txtFnameActors.Text, txtLnameActors.Text);
            SQLiteDataReader reader = conn.GetFilms();
            string id = "";
            int i = 1;
            while (reader.Read())
            {
                if (id != reader[0].ToString())
                {
                    i = 1;
                    table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), i.ToString() + "." + reader[4].ToString(), i.ToString() + "." + reader[5].ToString(), reader[6].ToString());
                    dgvListeFilms.DataSource = table;
                }
                else
                {
                    index = dgvListeFilms.Rows.Count - 1;
                    i++;
                    //Console.WriteLine(dgvListeFilms.Rows[1].Cells[1].Value.ToString());
                    dgvListeFilms.Rows[index].Cells[4].Value = dgvListeFilms.Rows[index].Cells[4].Value + " | " + i.ToString() + "." + reader[4].ToString();
                    dgvListeFilms.Rows[index].Cells[5].Value = dgvListeFilms.Rows[index].Cells[5].Value + " | " + i.ToString() + "." + reader[5].ToString();
                    //newRows.Cells[4].Value = newRows.Cells[4].Value + reader[4].ToString();
                    //newRows.Cells[5].Value = newRows.Cells[5].Value + reader[5].ToString();
                }

                id = reader[0].ToString();
            }
        }
    }
}
