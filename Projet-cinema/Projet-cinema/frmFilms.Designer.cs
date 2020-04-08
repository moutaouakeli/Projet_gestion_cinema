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
            this.lblFnameproducer = new System.Windows.Forms.Label();
            this.lblFnameActors = new System.Windows.Forms.Label();
            this.lblNameFilm = new System.Windows.Forms.Label();
            this.dgvListeFilms = new System.Windows.Forms.DataGridView();
            this.btnRemoveFilm = new System.Windows.Forms.Button();
            this.btnUpdateFilm = new System.Windows.Forms.Button();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.txtFnameActors = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtFnameProducer = new System.Windows.Forms.TextBox();
            this.txtNameFilm = new System.Windows.Forms.TextBox();
            this.btnAddActors = new System.Windows.Forms.Button();
            this.txtLnameProducer = new System.Windows.Forms.TextBox();
            this.lblLnameProducer = new System.Windows.Forms.Label();
            this.txtLnameActors = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(3, 561);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(147, 29);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description :";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFnameproducer
            // 
            this.lblFnameproducer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFnameproducer.AutoSize = true;
            this.lblFnameproducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFnameproducer.Location = new System.Drawing.Point(3, 199);
            this.lblFnameproducer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFnameproducer.Name = "lblFnameproducer";
            this.lblFnameproducer.Size = new System.Drawing.Size(262, 29);
            this.lblFnameproducer.TabIndex = 1;
            this.lblFnameproducer.Text = "Prénom du réalisateur :";
            this.lblFnameproducer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFnameActors
            // 
            this.lblFnameActors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFnameActors.AutoSize = true;
            this.lblFnameActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFnameActors.Location = new System.Drawing.Point(3, 315);
            this.lblFnameActors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFnameActors.Name = "lblFnameActors";
            this.lblFnameActors.Size = new System.Drawing.Size(226, 29);
            this.lblFnameActors.TabIndex = 2;
            this.lblFnameActors.Text = "Prénom de l\'acteur :";
            this.lblFnameActors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // dgvListeFilms
            // 
            this.dgvListeFilms.AllowUserToOrderColumns = true;
            this.dgvListeFilms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListeFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeFilms.Location = new System.Drawing.Point(528, 95);
            this.dgvListeFilms.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListeFilms.Name = "dgvListeFilms";
            this.dgvListeFilms.RowHeadersWidth = 51;
            this.dgvListeFilms.Size = new System.Drawing.Size(885, 660);
            this.dgvListeFilms.TabIndex = 12;
            this.dgvListeFilms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeFilms_CellClick);
            
            // 
            // btnRemoveFilm
            // 
            this.btnRemoveFilm.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnRemoveFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFilm.Location = new System.Drawing.Point(1180, 4);
            this.btnRemoveFilm.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnUpdateFilm.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnAddFilm.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(233, 73);
            this.btnAddFilm.TabIndex = 9;
            this.btnAddFilm.Text = "Ajouter";
            this.btnAddFilm.UseVisualStyleBackColor = false;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAjouterFilm_Click_1);
            // 
            // txtFnameActors
            // 
            this.txtFnameActors.Location = new System.Drawing.Point(273, 322);
            this.txtFnameActors.Margin = new System.Windows.Forms.Padding(4);
            this.txtFnameActors.Name = "txtFnameActors";
            this.txtFnameActors.Size = new System.Drawing.Size(242, 22);
            this.txtFnameActors.TabIndex = 16;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(163, 561);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(352, 193);
            this.txtDescription.TabIndex = 15;
            // 
            // txtFnameProducer
            // 
            this.txtFnameProducer.Location = new System.Drawing.Point(273, 202);
            this.txtFnameProducer.Margin = new System.Windows.Forms.Padding(4);
            this.txtFnameProducer.Name = "txtFnameProducer";
            this.txtFnameProducer.Size = new System.Drawing.Size(242, 22);
            this.txtFnameProducer.TabIndex = 14;
            // 
            // txtNameFilm
            // 
            this.txtNameFilm.Location = new System.Drawing.Point(163, 96);
            this.txtNameFilm.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameFilm.Name = "txtNameFilm";
            this.txtNameFilm.Size = new System.Drawing.Size(352, 22);
            this.txtNameFilm.TabIndex = 13;
            // 
            // btnAddActors
            // 
            this.btnAddActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddActors.Location = new System.Drawing.Point(367, 435);
            this.btnAddActors.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddActors.Name = "btnAddActors";
            this.btnAddActors.Size = new System.Drawing.Size(148, 28);
            this.btnAddActors.TabIndex = 19;
            this.btnAddActors.Text = "Ajouter";
            this.btnAddActors.UseVisualStyleBackColor = true;
            this.btnAddActors.Click += new System.EventHandler(this.btnAddActors_Click);
            // 
            // txtLnameProducer
            // 
            this.txtLnameProducer.Location = new System.Drawing.Point(273, 249);
            this.txtLnameProducer.Margin = new System.Windows.Forms.Padding(4);
            this.txtLnameProducer.Name = "txtLnameProducer";
            this.txtLnameProducer.Size = new System.Drawing.Size(242, 22);
            this.txtLnameProducer.TabIndex = 21;
            // 
            // lblLnameProducer
            // 
            this.lblLnameProducer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLnameProducer.AutoSize = true;
            this.lblLnameProducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLnameProducer.Location = new System.Drawing.Point(3, 246);
            this.lblLnameProducer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLnameProducer.Name = "lblLnameProducer";
            this.lblLnameProducer.Size = new System.Drawing.Size(229, 29);
            this.lblLnameProducer.TabIndex = 20;
            this.lblLnameProducer.Text = "Nom du réalisateur :";
            this.lblLnameProducer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLnameActors
            // 
            this.txtLnameActors.Location = new System.Drawing.Point(273, 379);
            this.txtLnameActors.Margin = new System.Windows.Forms.Padding(4);
            this.txtLnameActors.Name = "txtLnameActors";
            this.txtLnameActors.Size = new System.Drawing.Size(242, 22);
            this.txtLnameActors.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 372);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nom de l\'acteur :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1431, 768);
            this.Controls.Add(this.txtLnameActors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLnameProducer);
            this.Controls.Add(this.lblLnameProducer);
            this.Controls.Add(this.btnAddActors);
            this.Controls.Add(this.txtFnameActors);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtFnameProducer);
            this.Controls.Add(this.txtNameFilm);
            this.Controls.Add(this.dgvListeFilms);
            this.Controls.Add(this.btnRemoveFilm);
            this.Controls.Add(this.btnUpdateFilm);
            this.Controls.Add(this.btnAddFilm);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblFnameActors);
            this.Controls.Add(this.lblFnameproducer);
            this.Controls.Add(this.lblNameFilm);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label lblFnameproducer;
        private System.Windows.Forms.Label lblFnameActors;
        private System.Windows.Forms.DataGridView dgvListeFilms;
        private System.Windows.Forms.Button btnRemoveFilm;
        private System.Windows.Forms.Button btnUpdateFilm;
        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.TextBox txtFnameActors;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtFnameProducer;
        private System.Windows.Forms.TextBox txtNameFilm;
        private System.Windows.Forms.Button btnAddActors;
        private System.Windows.Forms.TextBox txtLnameProducer;
        private System.Windows.Forms.Label lblLnameProducer;
        private System.Windows.Forms.TextBox txtLnameActors;
        private System.Windows.Forms.Label label1;
    }
}