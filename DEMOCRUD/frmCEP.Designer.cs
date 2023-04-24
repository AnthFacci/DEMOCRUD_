namespace DEMOCRUD
{
    partial class frmCEP
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
            this.CEP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CEP
            // 
            this.CEP.AutoSize = true;
            this.CEP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CEP.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CEP.ForeColor = System.Drawing.SystemColors.Info;
            this.CEP.Location = new System.Drawing.Point(255, 230);
            this.CEP.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(64, 32);
            this.CEP.TabIndex = 0;
            this.CEP.Text = "C.E.P";
            // 
            // frmCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(27F, 65F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 491);
            this.Controls.Add(this.CEP);
            this.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Name = "frmCEP";
            this.Text = "frmCEP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CEP;
    }
}