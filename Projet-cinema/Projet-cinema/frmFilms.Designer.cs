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
            this.txtActors2 = new System.Windows.Forms.TextBox();
            this.btnAddActors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(3, 439);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(147, 29);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description :";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblproducer
            // 
            this.lblproducer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblproducer.AutoSize = true;
            this.lblproducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproducer.Location = new System.Drawing.Point(3, 199);
            this.lblproducer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblproducer.Name = "lblproducer";
            this.lblproducer.Size = new System.Drawing.Size(147, 29);
            this.lblproducer.TabIndex = 1;
            this.lblproducer.Text = "Réalisateur :";
            this.lblproducer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActors
            // 
            this.lblActors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActors.AutoSize = true;
            this.lblActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActors.Location = new System.Drawing.Point(3, 315);
            this.lblActors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(105, 29);
            this.lblActors.TabIndex = 2;
            this.lblActors.Text = "Acteurs :";
            this.lblActors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameFilm
            // 
            this.lblNameFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameFilm.AutoSize = true;
            this.lblNameFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFilm.Location = new System.Drawing.Point(3, 96);
            this.lblNameFilm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameFilm.Name = "lblNameFilm";
            this.lblNameFilm.Size = new System.Drawing.Size(154, 29);
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
            this.dgvListeFilms.Location = new System.Drawing.Point(528, 95);
            this.dgvListeFilms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListeFilms.Name = "dgvListeFilms";
            this.dgvListeFilms.RowHeadersWidth = 51;
            this.dgvListeFilms.Size = new System.Drawing.Size(885, 660);
            this.dgvListeFilms.TabIndex = 12;
            this.dgvListeFilms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeFilms_CellClick);
            this.dgvListeFilms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeFilms_CellContentClick);
            this.dgvListeFilms.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvListeFilms_MouseClick);
            // 
            // btnRemoveFilm
            // 
            this.btnRemoveFilm.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnRemoveFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFilm.Location = new System.Drawing.Point(1180, 4);
            this.btnRemoveFilm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveFilm.Name = "btnRemoveFilm";
            this.btnRemoveFilm.Size = new System.Drawing.Size(233, 73);
            this.btnRemoveFilm.TabIndex = 11;
            this.btnRemoveFilm.Text = "Supprimer";
            this.btnRemoveFilm.UseVisualStyleBackColor = false;
            this.btnRemoveFilm.Click += new System.EventHandler(this.btnSupprimerFilm_Click);
            // 
            // btnUpdateFilm
            // 
            this.btnUpdateFilm.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnUpdateFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFilm.Location = new System.Drawing.Point(857, 4);
            this.btnUpdateFilm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateFilm.Name = "btnUpdateFilm";
            this.btnUpdateFilm.Size = new System.Drawing.Size(233, 73);
            this.btnUpdateFilm.TabIndex = 10;
            this.btnUpdateFilm.Text = "Modifier";
            this.btnUpdateFilm.UseVisualStyleBackColor = false;
            this.btnUpdateFilm.Click += new System.EventHandler(this.btnModifierFilm_Click);
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAddFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFilm.Location = new System.Drawing.Point(528, 4);
            this.btnAddFilm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(233, 73);
            this.btnAddFilm.TabIndex = 9;
            this.btnAddFilm.Text = "Ajouter";
            this.btnAddFilm.UseVisualStyleBackColor = false;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAjouterFilm_Click_1);
            // 
            // txtActors
            // 
            this.txtActors.Location = new System.Drawing.Point(163, 318);
            this.txtActors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtActors.Name = "txtActors";
            this.txtActors.Size = new System.Drawing.Size(196, 22);
            this.txtActors.TabIndex = 16;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(163, 436);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(352, 318);
            this.txtDescription.TabIndex = 15;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtActeurs_TextChanged);
            // 
            // txtProducer
            // 
            this.txtProducer.Location = new System.Drawing.Point(163, 202);
            this.txtProducer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Size = new System.Drawing.Size(352, 22);
            this.txtProducer.TabIndex = 14;
            // 
            // txtNameFilm
            // 
            this.txtNameFilm.Location = new System.Drawing.Point(163, 96);
            this.txtNameFilm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameFilm.Name = "txtNameFilm";
            this.txtNameFilm.Size = new System.Drawing.Size(352, 22);
            this.txtNameFilm.TabIndex = 13;
            this.txtNameFilm.TextChanged += new System.EventHandler(this.txtNomFilm_TextChanged);
            // 
            // btnChercherActeur
            // 
            this.btnChercherActeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChercherActeur.Location = new System.Drawing.Point(368, 315);
            this.btnChercherActeur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChercherActeur.Name = "btnChercherActeur";
            this.btnChercherActeur.Size = new System.Drawing.Size(148, 28);
            this.btnChercherActeur.TabIndex = 17;
            this.btnChercherActeur.Text = "Chercher";
            this.btnChercherActeur.UseVisualStyleBackColor = true;
            this.btnChercherActeur.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtActors2
            // 
            this.txtActors2.Location = new System.Drawing.Point(163, 348);
            this.txtActors2.Margin = new System.Windows.Forms.Padding(4);
            this.txtActors2.Name = "txtActors2";
            this.txtActors2.Size = new System.Drawing.Size(196, 22);
            this.txtActors2.TabIndex = 18;
            // 
            // btnAddActors
            // 
            this.btnAddActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddActors.Location = new System.Drawing.Point(367, 348);
            this.btnAddActors.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddActors.Name = "btnAddActors";
            this.btnAddActors.Size = new System.Drawing.Size(148, 28);
            this.btnAddActors.TabIndex = 19;
            this.btnAddActors.Text = "Ajouter";
            this.btnAddActors.UseVisualStyleBackColor = true;
            // 
            // frmFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1431, 768);
            this.Controls.Add(this.btnAddActors);
            this.Controls.Add(this.txtActors2);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtActors2;
        private System.Windows.Forms.Button btnAddActors;
    }
}