namespace ChatInstitucional.Presentacion
{
    partial class Exit
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "¿Qué desea hacer?";
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.Location = new System.Drawing.Point(15, 44);
            this.Btn_LogOut.Name = "Btn_LogOut";
            this.Btn_LogOut.Size = new System.Drawing.Size(152, 23);
            this.Btn_LogOut.TabIndex = 4;
            this.Btn_LogOut.Text = "CERRAR SESIÓN";
            this.Btn_LogOut.UseVisualStyleBackColor = true;
            this.Btn_LogOut.Click += new System.EventHandler(this.Btn_LogOut_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(54, 102);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Exit.TabIndex = 5;
            this.Btn_Exit.Text = "SALIR";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(54, 73);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 3;
            this.Btn_Cancel.Text = "CANCELAR";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Exit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(182, 132);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_LogOut);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Exit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exit";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_LogOut;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}