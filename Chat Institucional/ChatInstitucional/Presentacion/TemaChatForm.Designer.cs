namespace ChatInstitucional.Presentacion
{
    partial class TemaChatForm
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
            this.Dgv_Participantes = new System.Windows.Forms.DataGridView();
            this.Btn_Volver = new System.Windows.Forms.Button();
            this.Btn_Fin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Participantes)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Participantes
            // 
            this.Dgv_Participantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Participantes.Location = new System.Drawing.Point(21, 29);
            this.Dgv_Participantes.Name = "Dgv_Participantes";
            this.Dgv_Participantes.Size = new System.Drawing.Size(284, 429);
            this.Dgv_Participantes.TabIndex = 0;
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.Location = new System.Drawing.Point(21, 496);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(284, 29);
            this.Btn_Volver.TabIndex = 1;
            this.Btn_Volver.Text = "VOLVER";
            this.Btn_Volver.UseVisualStyleBackColor = true;
            this.Btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // Btn_Fin
            // 
            this.Btn_Fin.Enabled = false;
            this.Btn_Fin.Location = new System.Drawing.Point(21, 464);
            this.Btn_Fin.Name = "Btn_Fin";
            this.Btn_Fin.Size = new System.Drawing.Size(284, 29);
            this.Btn_Fin.TabIndex = 2;
            this.Btn_Fin.Text = "FINALIZAR CHAT";
            this.Btn_Fin.UseVisualStyleBackColor = true;
            this.Btn_Fin.Click += new System.EventHandler(this.Btn_Fin_Click);
            // 
            // TemaChatForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(325, 537);
            this.Controls.Add(this.Btn_Fin);
            this.Controls.Add(this.Btn_Volver);
            this.Controls.Add(this.Dgv_Participantes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TemaChatForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TemaChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Participantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Participantes;
        private System.Windows.Forms.Button Btn_Volver;
        private System.Windows.Forms.Button Btn_Fin;
    }
}