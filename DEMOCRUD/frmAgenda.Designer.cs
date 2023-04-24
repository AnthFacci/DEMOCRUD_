namespace DEMOCRUD
{
    partial class frmAgenda
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
            this.Agenda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Agenda
            // 
            this.Agenda.AutoSize = true;
            this.Agenda.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Agenda.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Agenda.ForeColor = System.Drawing.SystemColors.Control;
            this.Agenda.Location = new System.Drawing.Point(287, 212);
            this.Agenda.Name = "Agenda";
            this.Agenda.Size = new System.Drawing.Size(167, 47);
            this.Agenda.TabIndex = 0;
            this.Agenda.Text = "AGENDA ";
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Agenda);
            this.Name = "frmAgenda";
            this.Text = "frmAgenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Agenda;
    }
}