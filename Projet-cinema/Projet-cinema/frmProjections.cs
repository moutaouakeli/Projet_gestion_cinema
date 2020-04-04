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
    public partial class frmProjections : Form
    {
        public frmProjections()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        int index;
        static int ligne = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DBconnection conn = new DBconnection();
           
            index = e.RowIndex;
            DataGridViewRow selectesRow = dgvFilm.Rows[index];
            cbNomFilmProj.SelectedIndex = cbNomFilmProj.FindString(selectesRow.Cells[1].Value.ToString());
            cbQualiteProj.SelectedIndex = cbQualiteProj.FindString(selectesRow.Cells[2].Value.ToString());
            cbSalleProj.SelectedIndex = cbSalleProj.FindString(selectesRow.Cells[5].Value.ToString());

            btnModifier.Enabled = true;

        }

        

        private void frmProjections_Load(object sender, EventArgs e)
        {
            DBconnection conn = new DBconnection();
            conn.RemoveProjectionsAuto();

            dgvFilm.ReadOnly = true;
            dgvFilm.AllowUserToAddRows = false;
            dgvFilm.AllowUserToDeleteRows = false;
            dgvFilm.AllowUserToOrderColumns = false;
            dgvFilm.AllowUserToResizeColumns = false;
            dgvFilm.AllowUserToResizeRows = false;

            //En-têtes
            table.Columns.Add("Id projection", typeof(string));
            table.Columns.Add("Nom du film", typeof(string));
            table.Columns.Add("Qualité", typeof(string));
            table.Columns.Add("Date de projections", typeof(string));
            table.Columns.Add("Date de fin ", typeof(string));
            table.Columns.Add("Salle ", typeof(string));

            SQLiteDataReader reader = conn.GetProjections();

            while (reader.Read())
            {
                Console.WriteLine("OK PROJECTIONS");
                table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
                //name = reader["firstname" + " " + "lastname"].ToString();
            }

            dgvFilm.DataSource = table;
            


            List<string> lstFilmsDB = conn.GetListFilms();
            foreach (string name in lstFilmsDB)
            {
                cbNomFilmProj.Items.Add(name);
                
            }

            List<string> lstRoomsDB = conn.GetListRooms();
            foreach (string name in lstRoomsDB)
            {
                cbSalleProj.Items.Add(name);
                

            }
            cbQualiteProj.Items.Add("3D");
            cbQualiteProj.Items.Add("4K");
            cbQualiteProj.Items.Add("FHD");
            cbQualiteProj.Items.Add("HD");

            dtpDateDebut.Format = DateTimePickerFormat.Custom;
            dtpDateDebut.CustomFormat = "dd/MM/yyyy hh:mm:ss";

            dtpDateFin.Format = DateTimePickerFormat.Custom;
            dtpDateFin.CustomFormat = "dd/MM/yyyy hh:mm:ss";

            btnModifier.Enabled = false;
        }

        private void btnAjouterFilm_Click(object sender, EventArgs e)
        {

            DBconnection conn = new DBconnection();
            
            conn.AddProjection(cbNomFilmProj.Text, cbQualiteProj.Text,dtpDateDebut.Value, dtpDateFin.Value, cbSalleProj.Text);
            // table.Rows.Add(cbNomFilmProj.Text, cbQualiteProj.Text, dtpDateDebut.Value, dtpDateFin.Value, cbSalleProj.Text);

            dgvFilm.ReadOnly = true;
            dgvFilm.AllowUserToAddRows = false;
            dgvFilm.AllowUserToDeleteRows = false;
            dgvFilm.AllowUserToOrderColumns = false;
            dgvFilm.AllowUserToResizeColumns = false;
            dgvFilm.AllowUserToResizeRows = false;

            //En-têtes
            table = new DataTable();
            table.Columns.Add("Id projection", typeof(string));
            table.Columns.Add("Nom du film", typeof(string));
            table.Columns.Add("Qualité", typeof(string));
            table.Columns.Add("Date de projections", typeof(string));
            table.Columns.Add("Date de fin ", typeof(string));
            table.Columns.Add("Salle ", typeof(string));


            SQLiteDataReader reader = conn.GetProjections();

            while (reader.Read())
            {
                Console.WriteLine("OK PROJECTIONS");
                table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
                
            }

            dgvFilm.DataSource = table;

        }

        

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DBconnection conn = new DBconnection();
            conn.RemoveProjections(dgvFilm.CurrentCell.Value.ToString());
            index = dgvFilm.CurrentCell.RowIndex;
            dgvFilm.Rows.RemoveAt(index);

            dgvFilm.ReadOnly = true;
            dgvFilm.AllowUserToAddRows = false;
            dgvFilm.AllowUserToDeleteRows = false;
            dgvFilm.AllowUserToOrderColumns = false;
            dgvFilm.AllowUserToResizeColumns = false;
            dgvFilm.AllowUserToResizeRows = false;

            //En-têtes
            table = new DataTable();
            table.Columns.Add("Id projection", typeof(string));
            table.Columns.Add("Nom du film", typeof(string));
            table.Columns.Add("Qualité", typeof(string));
            table.Columns.Add("Date de projections", typeof(string));
            table.Columns.Add("Date de fin ", typeof(string));
            table.Columns.Add("Salle ", typeof(string));


            SQLiteDataReader reader = conn.GetProjections();

            while (reader.Read())
            {
                Console.WriteLine("OK PROJECTIONS");
                table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
                //name = reader["firstname" + " " + "lastname"].ToString();
            }

            dgvFilm.DataSource = table;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            DBconnection conn = new DBconnection();
            DataGridViewRow selectesRow = dgvFilm.Rows[index];
            DataGridViewRow newRows = dgvFilm.Rows[index];
            
            newRows.Cells[0].Value = cbNomFilmProj.Text;
            newRows.Cells[1].Value = cbQualiteProj.Text;
            newRows.Cells[2].Value = dtpDateDebut.Value;
            newRows.Cells[3].Value = dtpDateFin.Value;
            newRows.Cells[4].Value = cbSalleProj.Text;
            conn.UpdateProj(selectesRow.Cells[0].Value.ToString(), cbNomFilmProj.Text, cbQualiteProj.Text, dtpDateDebut.Value, dtpDateFin.Value, cbSalleProj.Text);
            


            dgvFilm.ReadOnly = true;
            dgvFilm.AllowUserToAddRows = false;
            dgvFilm.AllowUserToDeleteRows = false;
            dgvFilm.AllowUserToOrderColumns = false;
            dgvFilm.AllowUserToResizeColumns = false;
            dgvFilm.AllowUserToResizeRows = false;

            //En-têtes
            table = new DataTable();
            table.Columns.Add("Id projection", typeof(string));
            table.Columns.Add("Nom du film", typeof(string));
            table.Columns.Add("Qualité", typeof(string));
            table.Columns.Add("Date de projections", typeof(string));
            table.Columns.Add("Date de fin ", typeof(string));
            table.Columns.Add("Salle ", typeof(string));


            SQLiteDataReader reader = conn.GetProjections();

            while (reader.Read())
            {
                Console.WriteLine("OK PROJECTIONS");
                table.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());
                //name = reader["firstname" + " " + "lastname"].ToString();
            }

            dgvFilm.DataSource = table;

        }
    }
}