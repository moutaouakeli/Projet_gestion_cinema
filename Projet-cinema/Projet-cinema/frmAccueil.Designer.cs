namespace Projet_cinema
{
    partial class frmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnFilm = new System.Windows.Forms.Button();
            this.btnProjection = new System.Windows.Forms.Button();
            this.btnRecette = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.Location = new System.Drawing.Point(77, 36);
            this.btnTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(352, 92);
            this.btnTicket.TabIndex = 0;
            this.btnTicket.Text = "Billets";
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFilm
            // 
            this.btnFilm.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilm.Location = new System.Drawing.Point(77, 175);
            this.btnFilm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(352, 92);
            this.btnFilm.TabIndex = 1;
            this.btnFilm.Text = "Films";
            this.btnFilm.UseVisualStyleBackColor = false;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // btnProjection
            // 
            this.btnProjection.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnProjection.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjection.Location = new System.Drawing.Point(77, 316);
            this.btnProjection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProjection.Name = "btnProjection";
            this.btnProjection.Size = new System.Drawing.Size(352, 92);
            this.btnProjection.TabIndex = 2;
            this.btnProjection.Text = "Projections";
            this.btnProjection.UseVisualStyleBackColor = false;
            this.btnProjection.Click += new System.EventHandler(this.btnProjection_Click);
            // 
            // btnRecette
            // 
            this.btnRecette.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecette.Location = new System.Drawing.Point(77, 454);
            this.btnRecette.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecette.Name = "btnRecette";
            this.btnRecette.Size = new System.Drawing.Size(352, 92);
            this.btnRecette.TabIndex = 3;
            this.btnRecette.Text = "Recette";
            this.btnRecette.UseVisualStyleBackColor = false;
            this.btnRecette.Click += new System.EventHandler(this.btnRecette_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(527, 582);
            this.Controls.Add(this.btnRecette);
            this.Controls.Add(this.btnProjection);
            this.Controls.Add(this.btnFilm);
            this.Controls.Add(this.btnTicket);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Button btnProjection;
        private System.Windows.Forms.Button btnRecette;
    }
}

