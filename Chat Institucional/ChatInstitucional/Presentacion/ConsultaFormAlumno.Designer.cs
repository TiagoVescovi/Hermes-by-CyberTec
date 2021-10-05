namespace ChatInstitucional.Presentacion
{
    partial class ConsultaFormAlumno
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
            this.Pnl_Pendiente = new System.Windows.Forms.Panel();
            this.Pnl_EnProceso = new System.Windows.Forms.Panel();
            this.Pnl_Resueltas = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Combo_Materia = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(52, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado de las consultas";
            // 
            // Pnl_Pendiente
            // 
            this.Pnl_Pendiente.BackColor = System.Drawing.Color.Red;
            this.Pnl_Pendiente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Pendiente.Location = new System.Drawing.Point(12, 174);
            this.Pnl_Pendiente.Name = "Pnl_Pendiente";
            this.Pnl_Pendiente.Size = new System.Drawing.Size(227, 241);
            this.Pnl_Pendiente.TabIndex = 1;
            // 
            // Pnl_EnProceso
            // 
            this.Pnl_EnProceso.BackColor = System.Drawing.Color.Yellow;
            this.Pnl_EnProceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_EnProceso.Location = new System.Drawing.Point(245, 174);
            this.Pnl_EnProceso.Name = "Pnl_EnProceso";
            this.Pnl_EnProceso.Size = new System.Drawing.Size(227, 241);
            this.Pnl_EnProceso.TabIndex = 2;
            // 
            // Pnl_Resueltas
            // 
            this.Pnl_Resueltas.BackColor = System.Drawing.Color.Green;
            this.Pnl_Resueltas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Resueltas.Location = new System.Drawing.Point(478, 174);
            this.Pnl_Resueltas.Name = "Pnl_Resueltas";
            this.Pnl_Resueltas.Size = new System.Drawing.Size(227, 241);
            this.Pnl_Resueltas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(22, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Materia";
            // 
            // Combo_Materia
            // 
            this.Combo_Materia.BackColor = System.Drawing.Color.Blue;
            this.Combo_Materia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Combo_Materia.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Materia.ForeColor = System.Drawing.Color.White;
            this.Combo_Materia.FormattingEnabled = true;
            this.Combo_Materia.Location = new System.Drawing.Point(26, 70);
            this.Combo_Materia.Name = "Combo_Materia";
            this.Combo_Materia.Size = new System.Drawing.Size(172, 27);
            this.Combo_Materia.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 93);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Redacta la consulta aquí";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(579, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "ENVIAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ConsultaFormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Combo_Materia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pnl_Resueltas);
            this.Controls.Add(this.Pnl_EnProceso);
            this.Controls.Add(this.Pnl_Pendiente);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaFormAlumno";
            this.ShowInTaskbar = false;
            this.Text = "ConsultaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnl_Pendiente;
        private System.Windows.Forms.Panel Pnl_EnProceso;
        private System.Windows.Forms.Panel Pnl_Resueltas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Combo_Materia;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}