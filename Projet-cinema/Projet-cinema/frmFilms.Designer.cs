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
            this.lblNomRealisateur = new System.Windows.Forms.Label();
            this.lblActeurs = new System.Windows.Forms.Label();
            this.lblNomFilm = new System.Windows.Forms.Label();
            this.dgvListeFilms = new System.Windows.Forms.DataGridView();
            this.btnSupprimerFilm = new System.Windows.Forms.Button();
            this.btnModifierFilm = new System.Windows.Forms.Button();
            this.btnAjouterFilm = new System.Windows.Forms.Button();
            this.txtActeurs = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtRealisateur = new System.Windows.Forms.TextBox();
            this.txtNomFilm = new System.Windows.Forms.TextBox();
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
            // lblNomRealisateur
            // 
            this.lblNomRealisateur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomRealisateur.AutoSize = true;
            this.lblNomRealisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomRealisateur.Location = new System.Drawing.Point(2, 162);
            this.lblNomRealisateur.Name = "lblNomRealisateur";
            this.lblNomRealisateur.Size = new System.Drawing.Size(113, 24);
            this.lblNomRealisateur.TabIndex = 1;
            this.lblNomRealisateur.Text = "Réalisateur :";
            this.lblNomRealisateur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActeurs
            // 
            this.lblActeurs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActeurs.AutoSize = true;
            this.lblActeurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActeurs.Location = new System.Drawing.Point(2, 256);
            this.lblActeurs.Name = "lblActeurs";
            this.lblActeurs.Size = new System.Drawing.Size(84, 24);
            this.lblActeurs.TabIndex = 2;
            this.lblActeurs.Text = "Acteurs :";
            this.lblActeurs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomFilm
            // 
            this.lblNomFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomFilm.AutoSize = true;
            this.lblNomFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomFilm.Location = new System.Drawing.Point(2, 78);
            this.lblNomFilm.Name = "lblNomFilm";
            this.lblNomFilm.Size = new System.Drawing.Size(121, 24);
            this.lblNomFilm.TabIndex = 0;
            this.lblNomFilm.Text = "Nom du film :";
            this.lblNomFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNomFilm.Click += new System.EventHandler(this.label1_Click);
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
            // btnSupprimerFilm
            // 
            this.btnSupprimerFilm.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnSupprimerFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerFilm.Location = new System.Drawing.Point(885, 3);
            this.btnSupprimerFilm.Name = "btnSupprimerFilm";
            this.btnSupprimerFilm.Size = new System.Drawing.Size(175, 59);
            this.btnSupprimerFilm.TabIndex = 11;
            this.btnSupprimerFilm.Text = "Supprimer";
            this.btnSupprimerFilm.UseVisualStyleBackColor = false;
            this.btnSupprimerFilm.Click += new System.EventHandler(this.btnSupprimerFilm_Click);
            // 
            // btnModifierFilm
            // 
            this.btnModifierFilm.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnModifierFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierFilm.Location = new System.Drawing.Point(643, 3);
            this.btnModifierFilm.Name = "btnModifierFilm";
            this.btnModifierFilm.Size = new System.Drawing.Size(175, 59);
            this.btnModifierFilm.TabIndex = 10;
            this.btnModifierFilm.Text = "Modifier";
            this.btnModifierFilm.UseVisualStyleBackColor = false;
            this.btnModifierFilm.Click += new System.EventHandler(this.btnModifierFilm_Click);
            // 
            // btnAjouterFilm
            // 
            this.btnAjouterFilm.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAjouterFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterFilm.Location = new System.Drawing.Point(396, 3);
            this.btnAjouterFilm.Name = "btnAjouterFilm";
            this.btnAjouterFilm.Size = new System.Drawing.Size(175, 59);
            this.btnAjouterFilm.TabIndex = 9;
            this.btnAjouterFilm.Text = "Ajouter";
            this.btnAjouterFilm.UseVisualStyleBackColor = false;
            this.btnAjouterFilm.Click += new System.EventHandler(this.btnAjouterFilm_Click_1);
            // 
            // txtActeurs
            // 
            this.txtActeurs.Location = new System.Drawing.Point(122, 258);
            this.txtActeurs.Name = "txtActeurs";
            this.txtActeurs.Size = new System.Drawing.Size(148, 20);
            this.txtActeurs.TabIndex = 16;
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
            // txtRealisateur
            // 
            this.txtRealisateur.Location = new System.Drawing.Point(122, 164);
            this.txtRealisateur.Name = "txtRealisateur";
            this.txtRealisateur.Size = new System.Drawing.Size(265, 20);
            this.txtRealisateur.TabIndex = 14;
            // 
            // txtNomFilm
            // 
            this.txtNomFilm.Location = new System.Drawing.Point(122, 78);
            this.txtNomFilm.Name = "txtNomFilm";
            this.txtNomFilm.Size = new System.Drawing.Size(265, 20);
            this.txtNomFilm.TabIndex = 13;
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
            this.Controls.Add(this.txtActeurs);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtRealisateur);
            this.Controls.Add(this.txtNomFilm);
            this.Controls.Add(this.dgvListeFilms);
            this.Controls.Add(this.btnSupprimerFilm);
            this.Controls.Add(this.btnModifierFilm);
            this.Controls.Add(this.btnAjouterFilm);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblActeurs);
            this.Controls.Add(this.lblNomRealisateur);
            this.Controls.Add(this.lblNomFilm);
            this.Name = "frmFilms";
            this.Text = "Films";
            this.Load += new System.EventHandler(this.frmFilms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeFilms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblNomFilm;
        private System.Windows.Forms.Label lblNomRealisateur;
        private System.Windows.Forms.Label lblActeurs;
        private System.Windows.Forms.DataGridView dgvListeFilms;
        private System.Windows.Forms.Button btnSupprimerFilm;
        private System.Windows.Forms.Button btnModifierFilm;
        private System.Windows.Forms.Button btnAjouterFilm;
        private System.Windows.Forms.TextBox txtActeurs;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtRealisateur;
        private System.Windows.Forms.TextBox txtNomFilm;
        private System.Windows.Forms.Button btnChercherActeur;
    }
}