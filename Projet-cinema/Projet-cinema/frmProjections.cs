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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DBconnection conn = new DBconnection();
            conn.RemoveFilms(cbNomFilmProj.Text);

        }

        private void lblNomFilm_Click(object sender, EventArgs e)
        {

        }

        private void lblDateDebut_Click(object sender, EventArgs e)
        {

        }

        private void dtpDateDebut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmProjections_Load(object sender, EventArgs e)
        {
            DBconnection conn = new DBconnection();
            conn.RemoveProjectionsAuto();

            //En-têtes
            table.Columns.Add("Nom du film", typeof(string));
            table.Columns.Add("Qualité", typeof(string));
            table.Columns.Add("Date de projections", typeof(string));
            table.Columns.Add("Date de fin ", typeof(string));
            table.Columns.Add("Salle ", typeof(string));


            SQLiteDataReader reader = conn.GetProjections();

            while (reader.Read())
            {
                table.Rows.Add(reader[0].ToString(), reader[1].ToString(), "15/12/2020", "15/12/2020", reader[4].ToString());
                //name = reader["firstname" + " " + "lastname"].ToString();
            }

            dgvFilm.DataSource = table;
            //dgvListeFilms.DataSource = table;


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
        }

        private void btnAjouterFilm_Click(object sender, EventArgs e)
        {

            DBconnection conn = new DBconnection();
            
            conn.AddProjection(cbNomFilmProj.Text, cbQualiteProj.Text,dtpDateDebut.Value, dtpDateFin.Value, cbSalleProj.Text);
            table.Rows.Add(cbNomFilmProj.Text, cbQualiteProj.Text, dtpDateDebut.Value, dtpDateFin.Value, cbSalleProj.Text);

        }

        private void cbNomFilmProj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DBconnection conn = new DBconnection();
            conn.RemoveProjections(dgvFilm.CurrentCell.Value.ToString());
            index = dgvFilm.CurrentCell.RowIndex;
            dgvFilm.Rows.RemoveAt(index);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            DBconnection conn = new DBconnection();
            DataGridViewRow newRows = dgvFilm.Rows[index];
            
            newRows.Cells[0].Value = cbNomFilmProj.Text;
            newRows.Cells[1].Value = cbQualiteProj.Text;
            newRows.Cells[2].Value = dtpDateDebut.Value;
            newRows.Cells[3].Value = dtpDateFin.Value;
            newRows.Cells[4].Value = cbSalleProj.Text;
            conn.UpdateProj(cbNomFilmProj.Text, cbQualiteProj.Text, dtpDateDebut.Value, dtpDateFin.Value,cbSalleProj.Text);

        }
    }
}