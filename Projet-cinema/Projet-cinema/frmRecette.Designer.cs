namespace Projet_cinema
{
    partial class frmRecette
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
            this.lblDateSemaine = new System.Windows.Forms.Label();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.dgvRecette = new System.Windows.Forms.DataGridView();
            this.DateAchat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecette)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateSemaine
            // 
            this.lblDateSemaine.AutoSize = true;
            this.lblDateSemaine.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSemaine.Location = new System.Drawing.Point(21, 27);
            this.lblDateSemaine.Name = "lblDateSemaine";
            this.lblDateSemaine.Size = new System.Drawing.Size(169, 37);
            this.lblDateSemaine.TabIndex = 5;
            this.lblDateSemaine.Text = "Semaine :";
            // 
            // btnImprimer
            // 
            this.btnImprimer.BackColor = System.Drawing.Color.LightYellow;
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.Location = new System.Drawing.Point(264, 518);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(171, 63);
            this.btnImprimer.TabIndex = 6;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = false;
            // 
            // dgvRecette
            // 
            this.dgvRecette.AllowUserToOrderColumns = true;
            this.dgvRecette.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecette.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateAchat,
            this.PrixTotal});
            this.dgvRecette.Location = new System.Drawing.Point(28, 75);
            this.dgvRecette.Name = "dgvRecette";
            this.dgvRecette.Size = new System.Drawing.Size(641, 429);
            this.dgvRecette.TabIndex = 7;
            this.dgvRecette.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DateAchat
            // 
            this.DateAchat.HeaderText = "Date d\'achat";
            this.DateAchat.Name = "DateAchat";
            this.DateAchat.Width = 300;
            // 
            // PrixTotal
            // 
            this.PrixTotal.HeaderText = "Prix total";
            this.PrixTotal.Name = "PrixTotal";
            this.PrixTotal.Width = 300;
            // 
            // frmRecette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(705, 593);
            this.Controls.Add(this.dgvRecette);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.lblDateSemaine);
            this.Name = "frmRecette";
            this.Text = "Recettes";
            this.Load += new System.EventHandler(this.Recettes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecette)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDateSemaine;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.DataGridView dgvRecette;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixTotal;
    }
}