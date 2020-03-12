namespace Projet_cinema
{
    partial class frmBillets
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
            this.cmbListeFilm = new System.Windows.Forms.ComboBox();
            this.lblListeFilms = new System.Windows.Forms.Label();
            this.lblfilm = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.nudQuantite = new System.Windows.Forms.NumericUpDown();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblPrixCalcule = new System.Windows.Forms.Label();
            this.lblCHF = new System.Windows.Forms.Label();
            this.btnPayer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAgeAdulte = new System.Windows.Forms.RadioButton();
            this.rbAgeEnfant = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbListeFilm
            // 
            this.cmbListeFilm.FormattingEnabled = true;
            this.cmbListeFilm.Location = new System.Drawing.Point(181, 83);
            this.cmbListeFilm.Name = "cmbListeFilm";
            this.cmbListeFilm.Size = new System.Drawing.Size(277, 21);
            this.cmbListeFilm.TabIndex = 0;
            // 
            // lblListeFilms
            // 
            this.lblListeFilms.AutoSize = true;
            this.lblListeFilms.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeFilms.Location = new System.Drawing.Point(29, 79);
            this.lblListeFilms.Name = "lblListeFilms";
            this.lblListeFilms.Size = new System.Drawing.Size(70, 25);
            this.lblListeFilms.TabIndex = 1;
            this.lblListeFilms.Text = "Film :";
            this.lblListeFilms.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblfilm
            // 
            this.lblfilm.AutoSize = true;
            this.lblfilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilm.Location = new System.Drawing.Point(28, 12);
            this.lblfilm.Name = "lblfilm";
            this.lblfilm.Size = new System.Drawing.Size(439, 33);
            this.lblfilm.TabIndex = 2;
            this.lblfilm.Text = "Veuillez choisir un film de la liste";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantite.Location = new System.Drawing.Point(29, 152);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(115, 25);
            this.lblQuantite.TabIndex = 3;
            this.lblQuantite.Text = "Quantité :";
            // 
            // nudQuantite
            // 
            this.nudQuantite.Location = new System.Drawing.Point(181, 157);
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(120, 20);
            this.nudQuantite.TabIndex = 4;
            this.nudQuantite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.Location = new System.Drawing.Point(29, 305);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(120, 25);
            this.lblPrix.TabIndex = 5;
            this.lblPrix.Text = "Prix total :";
            // 
            // lblPrixCalcule
            // 
            this.lblPrixCalcule.AutoSize = true;
            this.lblPrixCalcule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixCalcule.Location = new System.Drawing.Point(176, 305);
            this.lblPrixCalcule.Name = "lblPrixCalcule";
            this.lblPrixCalcule.Size = new System.Drawing.Size(24, 25);
            this.lblPrixCalcule.TabIndex = 6;
            this.lblPrixCalcule.Text = "0";
            // 
            // lblCHF
            // 
            this.lblCHF.AutoSize = true;
            this.lblCHF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCHF.Location = new System.Drawing.Point(223, 305);
            this.lblCHF.Name = "lblCHF";
            this.lblCHF.Size = new System.Drawing.Size(55, 25);
            this.lblCHF.TabIndex = 7;
            this.lblCHF.Text = "CHF";
            this.lblCHF.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnPayer
            // 
            this.btnPayer.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnPayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayer.Location = new System.Drawing.Point(34, 362);
            this.btnPayer.Name = "btnPayer";
            this.btnPayer.Size = new System.Drawing.Size(209, 74);
            this.btnPayer.TabIndex = 8;
            this.btnPayer.Text = "Payer";
            this.btnPayer.UseVisualStyleBackColor = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(387, 362);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(209, 74);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Catégorie : ";
            // 
            // rbAgeAdulte
            // 
            this.rbAgeAdulte.AutoSize = true;
            this.rbAgeAdulte.Checked = true;
            this.rbAgeAdulte.Location = new System.Drawing.Point(181, 230);
            this.rbAgeAdulte.Name = "rbAgeAdulte";
            this.rbAgeAdulte.Size = new System.Drawing.Size(55, 17);
            this.rbAgeAdulte.TabIndex = 11;
            this.rbAgeAdulte.TabStop = true;
            this.rbAgeAdulte.Text = "Adulte";
            this.rbAgeAdulte.UseVisualStyleBackColor = true;
            // 
            // rbAgeEnfant
            // 
            this.rbAgeEnfant.AutoSize = true;
            this.rbAgeEnfant.Location = new System.Drawing.Point(267, 230);
            this.rbAgeEnfant.Name = "rbAgeEnfant";
            this.rbAgeEnfant.Size = new System.Drawing.Size(56, 17);
            this.rbAgeEnfant.TabIndex = 12;
            this.rbAgeEnfant.Text = "Enfant";
            this.rbAgeEnfant.UseVisualStyleBackColor = true;
            // 
            // frmBillets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.rbAgeEnfant);
            this.Controls.Add(this.rbAgeAdulte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnPayer);
            this.Controls.Add(this.lblCHF);
            this.Controls.Add(this.lblPrixCalcule);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.nudQuantite);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.lblfilm);
            this.Controls.Add(this.lblListeFilms);
            this.Controls.Add(this.cmbListeFilm);
            this.Name = "frmBillets";
            this.Text = "Billets";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbListeFilm;
        private System.Windows.Forms.Label lblListeFilms;
        private System.Windows.Forms.Label lblfilm;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.NumericUpDown nudQuantite;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblPrixCalcule;
        private System.Windows.Forms.Label lblCHF;
        private System.Windows.Forms.Button btnPayer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAgeAdulte;
        private System.Windows.Forms.RadioButton rbAgeEnfant;
    }
}