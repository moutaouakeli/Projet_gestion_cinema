namespace Projet_cinema
{
    partial class frmActors
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
            this.lstActors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstActors
            // 
            this.lstActors.FormattingEnabled = true;
            this.lstActors.ItemHeight = 16;
            this.lstActors.Items.AddRange(new object[] {
            "Acteur1",
            "Acteur2",
            "Acteur3",
            "Acteur4"});
            this.lstActors.Location = new System.Drawing.Point(91, 12);
            this.lstActors.Name = "lstActors";
            this.lstActors.Size = new System.Drawing.Size(380, 404);
            this.lstActors.TabIndex = 0;
            this.lstActors.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // frmActors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstActors);
            this.Name = "frmActors";
            this.Text = "frmActors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstActors;
    }
}