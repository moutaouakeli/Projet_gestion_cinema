namespace Projet_cinema
{
    partial class frmProjections
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblsalle = new System.Windows.Forms.Label();
            this.lblQualite = new System.Windows.Forms.Label();
            this.lblNomFilm = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouterFilm = new System.Windows.Forms.Button();
            this.dgvFilm = new System.Windows.Forms.DataGridView();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.cbNomFilmProj = new System.Windows.Forms.ComboBox();
            this.cbSalleProj = new System.Windows.Forms.ComboBox();
            this.cbQualiteProj = new System.Windows.Forms.ComboBox();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateFin
            // 
            this.lblDateFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFin.Location = new System.Drawing.Point(8, 594);
            this.lblDateFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(140, 29);
            this.lblDateFin.TabIndex = 3;
            this.lblDateFin.Text = "Date de fin :";
            this.lblDateFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsalle
            // 
            this.lblsalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsalle.AutoSize = true;
            this.lblsalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalle.Location = new System.Drawing.Point(8, 209);
            this.lblsalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsalle.Name = "lblsalle";
            this.lblsalle.Size = new System.Drawing.Size(80, 29);
            this.lblsalle.TabIndex = 1;
            this.lblsalle.Text = "Salle :";
            this.lblsalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQualite
            // 
            this.lblQualite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQualite.AutoSize = true;
            this.lblQualite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualite.Location = new System.Drawing.Point(8, 337);
            this.lblQualite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQualite.Name = "lblQualite";
            this.lblQualite.Size = new System.Drawing.Size(102, 29);
            this.lblQualite.TabIndex = 2;
            this.lblQualite.Text = "Qualité :";
            this.lblQualite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomFilm
            // 
            this.lblNomFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomFilm.AutoSize = true;
            this.lblNomFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomFilm.Location = new System.Drawing.Point(8, 97);
            this.lblNomFilm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomFilm.Name = "lblNomFilm";
            this.lblNomFilm.Size = new System.Drawing.Size(154, 29);
            this.lblNomFilm.TabIndex = 0;
            this.lblNomFilm.Text = "Nom du film :";
            this.lblNomFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNomFilm.Click += new System.EventHandler(this.lblNomFilm_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(1233, 15);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(233, 73);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(876, 15);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(233, 73);
            this.btnModifier.TabIndex = 5;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouterFilm
            // 
            this.btnAjouterFilm.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAjouterFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterFilm.Location = new System.Drawing.Point(511, 15);
            this.btnAjouterFilm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouterFilm.Name = "btnAjouterFilm";
            this.btnAjouterFilm.Size = new System.Drawing.Size(233, 73);
            this.btnAjouterFilm.TabIndex = 4;
            this.btnAjouterFilm.Text = "Ajouter";
            this.btnAjouterFilm.UseVisualStyleBackColor = false;
            this.btnAjouterFilm.Click += new System.EventHandler(this.btnAjouterFilm_Click);
            // 
            // dgvFilm
            // 
            this.dgvFilm.AllowUserToOrderColumns = true;
            this.dgvFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilm.Location = new System.Drawing.Point(511, 101);
            this.dgvFilm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFilm.Name = "dgvFilm";
            this.dgvFilm.RowHeadersWidth = 51;
            this.dgvFilm.Size = new System.Drawing.Size(956, 660);
            this.dgvFilm.TabIndex = 8;
            this.dgvFilm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDebut.Location = new System.Drawing.Point(8, 470);
            this.lblDateDebut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(141, 29);
            this.lblDateDebut.TabIndex = 9;
            this.lblDateDebut.Text = "Projecté le :";
            this.lblDateDebut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDateDebut.Click += new System.EventHandler(this.lblDateDebut_Click);
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(169, 474);
            this.dtpDateDebut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(324, 22);
            this.dtpDateDebut.TabIndex = 10;
            this.dtpDateDebut.ValueChanged += new System.EventHandler(this.dtpDateDebut_ValueChanged);
            // 
            // cbNomFilmProj
            // 
            this.cbNomFilmProj.FormattingEnabled = true;
            this.cbNomFilmProj.Location = new System.Drawing.Point(169, 103);
            this.cbNomFilmProj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNomFilmProj.Name = "cbNomFilmProj";
            this.cbNomFilmProj.Size = new System.Drawing.Size(324, 24);
            this.cbNomFilmProj.TabIndex = 26;
            this.cbNomFilmProj.SelectedIndexChanged += new System.EventHandler(this.cbNomFilmProj_SelectedIndexChanged);
            // 
            // cbSalleProj
            // 
            this.cbSalleProj.FormattingEnabled = true;
            this.cbSalleProj.Location = new System.Drawing.Point(169, 215);
            this.cbSalleProj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSalleProj.Name = "cbSalleProj";
            this.cbSalleProj.Size = new System.Drawing.Size(324, 24);
            this.cbSalleProj.TabIndex = 25;
            // 
            // cbQualiteProj
            // 
            this.cbQualiteProj.FormattingEnabled = true;
            this.cbQualiteProj.Location = new System.Drawing.Point(169, 343);
            this.cbQualiteProj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbQualiteProj.Name = "cbQualiteProj";
            this.cbQualiteProj.Size = new System.Drawing.Size(324, 24);
            this.cbQualiteProj.TabIndex = 24;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(169, 599);
            this.dtpDateFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(324, 22);
            this.dtpDateFin.TabIndex = 27;
            // 
            // frmProjections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1473, 791);
            this.Controls.Add(this.dtpDateFin);
            this.Controls.Add(this.cbNomFilmProj);
            this.Controls.Add(this.cbSalleProj);
            this.Controls.Add(this.cbQualiteProj);
            this.Controls.Add(this.dtpDateDebut);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.dgvFilm);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblQualite);
            this.Controls.Add(this.lblsalle);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lblNomFilm);
            this.Controls.Add(this.btnAjouterFilm);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProjections";
            this.Text = "Projections";
            this.Load += new System.EventHandler(this.frmProjections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblsalle;
        private System.Windows.Forms.Label lblQualite;
        private System.Windows.Forms.Label lblNomFilm;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouterFilm;
        private System.Windows.Forms.DataGridView dgvFilm;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.ComboBox cbNomFilmProj;
        private System.Windows.Forms.ComboBox cbSalleProj;
        private System.Windows.Forms.ComboBox cbQualiteProj;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
    }
}