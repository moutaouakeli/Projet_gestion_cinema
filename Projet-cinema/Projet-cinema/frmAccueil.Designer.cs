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
            this.btnAchatBillets = new System.Windows.Forms.Button();
            this.btnFilm = new System.Windows.Forms.Button();
            this.btnProjection = new System.Windows.Forms.Button();
            this.btnRecette = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAchatBillets
            // 
            this.btnAchatBillets.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAchatBillets.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAchatBillets.Location = new System.Drawing.Point(58, 29);
            this.btnAchatBillets.Name = "btnAchatBillets";
            this.btnAchatBillets.Size = new System.Drawing.Size(264, 75);
            this.btnAchatBillets.TabIndex = 0;
            this.btnAchatBillets.Text = "Billets";
            this.btnAchatBillets.UseVisualStyleBackColor = false;
            this.btnAchatBillets.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFilm
            // 
            this.btnFilm.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilm.Location = new System.Drawing.Point(58, 142);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(264, 75);
            this.btnFilm.TabIndex = 1;
            this.btnFilm.Text = "Films";
            this.btnFilm.UseVisualStyleBackColor = false;
            // 
            // btnProjection
            // 
            this.btnProjection.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnProjection.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjection.Location = new System.Drawing.Point(58, 257);
            this.btnProjection.Name = "btnProjection";
            this.btnProjection.Size = new System.Drawing.Size(264, 75);
            this.btnProjection.TabIndex = 2;
            this.btnProjection.Text = "Projections";
            this.btnProjection.UseVisualStyleBackColor = false;
            // 
            // btnRecette
            // 
            this.btnRecette.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecette.Location = new System.Drawing.Point(58, 369);
            this.btnRecette.Name = "btnRecette";
            this.btnRecette.Size = new System.Drawing.Size(264, 75);
            this.btnRecette.TabIndex = 3;
            this.btnRecette.Text = "Recettes";
            this.btnRecette.UseVisualStyleBackColor = false;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(395, 473);
            this.Controls.Add(this.btnRecette);
            this.Controls.Add(this.btnProjection);
            this.Controls.Add(this.btnFilm);
            this.Controls.Add(this.btnAchatBillets);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAchatBillets;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Button btnProjection;
        private System.Windows.Forms.Button btnRecette;
    }
}

