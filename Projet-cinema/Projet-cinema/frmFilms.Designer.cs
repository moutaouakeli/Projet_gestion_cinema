namespace Projet_cinema
{
    partial class frmFilms
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblproducer = new System.Windows.Forms.Label();
            this.lblActors = new System.Windows.Forms.Label();
            this.lblNameFilm = new System.Windows.Forms.Label();
            this.dgvListeFilms = new System.Windows.Forms.DataGridView();
            this.btnRemoveFilm = new System.Windows.Forms.Button();
            this.btnUpdateFilm = new System.Windows.Forms.Button();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.txtActors = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtProducer = new System.Windows.Forms.TextBox();
            this.txtNameFilm = new System.Windows.Forms.TextBox();
            this.btnChercherActeur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(2, 357);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(114, 24);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description :";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblproducer
            // 
            this.lblproducer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblproducer.AutoSize = true;
            this.lblproducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproducer.Location = new System.Drawing.Point(2, 162);
            this.lblproducer.Name = "lblproducer";
            this.lblproducer.Size = new System.Drawing.Size(113, 24);
            this.lblproducer.TabIndex = 1;
            this.lblproducer.Text = "Réalisateur :";
            this.lblproducer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActors
            // 
            this.lblActors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActors.AutoSize = true;
            this.lblActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActors.Location = new System.Drawing.Point(2, 256);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(84, 24);
            this.lblActors.TabIndex = 2;
            this.lblActors.Text = "Acteurs :";
            this.lblActors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameFilm
            // 
            this.lblNameFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameFilm.AutoSize = true;
            this.lblNameFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFilm.Location = new System.Drawing.Point(2, 78);
            this.lblNameFilm.Name = "lblNameFilm";
            this.lblNameFilm.Size = new System.Drawing.Size(121, 24);
            this.lblNameFilm.TabIndex = 0;
            this.lblNameFilm.Text = "Nom du film :";
            this.lblNameFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNameFilm.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvListeFilms
            // 
            this.dgvListeFilms.AllowUserToOrderColumns = true;
            this.dgvListeFilms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListeFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeFilms.Location = new System.Drawing.Point(396, 77);
            this.dgvListeFilms.Name = "dgvListeFilms";
            this.dgvListeFilms.Size = new System.Drawing.Size(664, 536);
            this.dgvListeFilms.TabIndex = 12;
            this.dgvListeFilms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeFilms_CellClick);
            this.dgvListeFilms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeFilms_CellContentClick);
            this.dgvListeFilms.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvListeFilms_MouseClick);
            // 
            // btnRemoveFilm
            // 
            this.btnRemoveFilm.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnRemoveFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFilm.Location = new System.Drawing.Point(885, 3);
            this.btnRemoveFilm.Name = "btnRemoveFilm";
            this.btnRemoveFilm.Size = new System.Drawing.Size(175, 59);
            this.btnRemoveFilm.TabIndex = 11;
            this.btnRemoveFilm.Text = "Supprimer";
            this.btnRemoveFilm.UseVisualStyleBackColor = false;
            this.btnRemoveFilm.Click += new System.EventHandler(this.btnSupprimerFilm_Click);
            // 
            // btnUpdateFilm
            // 
            this.btnUpdateFilm.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnUpdateFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFilm.Location = new System.Drawing.Point(643, 3);
            this.btnUpdateFilm.Name = "btnUpdateFilm";
            this.btnUpdateFilm.Size = new System.Drawing.Size(175, 59);
            this.btnUpdateFilm.TabIndex = 10;
            this.btnUpdateFilm.Text = "Modifier";
            this.btnUpdateFilm.UseVisualStyleBackColor = false;
            this.btnUpdateFilm.Click += new System.EventHandler(this.btnModifierFilm_Click);
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAddFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFilm.Location = new System.Drawing.Point(396, 3);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(175, 59);
            this.btnAddFilm.TabIndex = 9;
            this.btnAddFilm.Text = "Ajouter";
            this.btnAddFilm.UseVisualStyleBackColor = false;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAjouterFilm_Click_1);
            // 
            // txtActors
            // 
            this.txtActors.Location = new System.Drawing.Point(122, 258);
            this.txtActors.Name = "txtActors";
            this.txtActors.Size = new System.Drawing.Size(148, 20);
            this.txtActors.TabIndex = 16;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(122, 354);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(265, 259);
            this.txtDescription.TabIndex = 15;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtActeurs_TextChanged);
            // 
            // txtProducer
            // 
            this.txtProducer.Location = new System.Drawing.Point(122, 164);
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Size = new System.Drawing.Size(265, 20);
            this.txtProducer.TabIndex = 14;
            // 
            // txtNameFilm
            // 
            this.txtNameFilm.Location = new System.Drawing.Point(122, 78);
            this.txtNameFilm.Name = "txtNameFilm";
            this.txtNameFilm.Size = new System.Drawing.Size(265, 20);
            this.txtNameFilm.TabIndex = 13;
            this.txtNameFilm.TextChanged += new System.EventHandler(this.txtNomFilm_TextChanged);
            // 
            // btnChercherActeur
            // 
            this.btnChercherActeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChercherActeur.Location = new System.Drawing.Point(276, 256);
            this.btnChercherActeur.Name = "btnChercherActeur";
            this.btnChercherActeur.Size = new System.Drawing.Size(111, 23);
            this.btnChercherActeur.TabIndex = 17;
            this.btnChercherActeur.Text = "Chercher";
            this.btnChercherActeur.UseVisualStyleBackColor = true;
            this.btnChercherActeur.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1073, 624);
            this.Controls.Add(this.btnChercherActeur);
            this.Controls.Add(this.txtActors);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtProducer);
            this.Controls.Add(this.txtNameFilm);
            this.Controls.Add(this.dgvListeFilms);
            this.Controls.Add(this.btnRemoveFilm);
            this.Controls.Add(this.btnUpdateFilm);
            this.Controls.Add(this.btnAddFilm);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblActors);
            this.Controls.Add(this.lblproducer);
            this.Controls.Add(this.lblNameFilm);
            this.Name = "frmFilms";
            this.Text = "Films";
            this.Load += new System.EventHandler(this.frmFilms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeFilms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblNameFilm;
        private System.Windows.Forms.Label lblproducer;
        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.DataGridView dgvListeFilms;
        private System.Windows.Forms.Button btnRemoveFilm;
        private System.Windows.Forms.Button btnUpdateFilm;
        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.TextBox txtActors;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.TextBox txtNameFilm;
        private System.Windows.Forms.Button btnChercherActeur;
    }
}