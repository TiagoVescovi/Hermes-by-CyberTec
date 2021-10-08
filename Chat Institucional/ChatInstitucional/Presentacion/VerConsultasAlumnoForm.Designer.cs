namespace ChatInstitucional.Presentacion
{
    partial class VerConsultasAlumnoForm
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
            this.Text_Consulta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Text_Consulta
            // 
            this.Text_Consulta.Location = new System.Drawing.Point(33, 18);
            this.Text_Consulta.Multiline = true;
            this.Text_Consulta.Name = "Text_Consulta";
            this.Text_Consulta.ReadOnly = true;
            this.Text_Consulta.Size = new System.Drawing.Size(729, 405);
            this.Text_Consulta.TabIndex = 0;
            // 
            // VerConsultasAlumnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Text_Consulta);
            this.Name = "VerConsultasAlumnoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerConsultasAlumnoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_Consulta;
    }
}