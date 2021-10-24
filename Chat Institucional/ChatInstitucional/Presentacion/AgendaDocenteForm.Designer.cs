namespace ChatInstitucional.Presentacion
{
    partial class AgendaDocenteForm
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
            this.Combo_Materias = new System.Windows.Forms.ComboBox();
            this.Combo_Grupos = new System.Windows.Forms.ComboBox();
            this.Combo_Dias = new System.Windows.Forms.ComboBox();
            this.Combo_HoraIni_HH = new System.Windows.Forms.ComboBox();
            this.Combo_HoraIni_MM = new System.Windows.Forms.ComboBox();
            this.Combo_HoraFin_MM = new System.Windows.Forms.ComboBox();
            this.Combo_HoraFin_HH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dgv_Horarios = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Combo_Orientacion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Combo_Materias
            // 
            this.Combo_Materias.Enabled = false;
            this.Combo_Materias.FormattingEnabled = true;
            this.Combo_Materias.Location = new System.Drawing.Point(356, 132);
            this.Combo_Materias.Name = "Combo_Materias";
            this.Combo_Materias.Size = new System.Drawing.Size(121, 21);
            this.Combo_Materias.TabIndex = 0;
            this.Combo_Materias.SelectedIndexChanged += new System.EventHandler(this.Combo_Materias_SelectedIndexChanged);
            // 
            // Combo_Grupos
            // 
            this.Combo_Grupos.Enabled = false;
            this.Combo_Grupos.FormattingEnabled = true;
            this.Combo_Grupos.Location = new System.Drawing.Point(356, 92);
            this.Combo_Grupos.Name = "Combo_Grupos";
            this.Combo_Grupos.Size = new System.Drawing.Size(121, 21);
            this.Combo_Grupos.TabIndex = 1;
            this.Combo_Grupos.SelectedIndexChanged += new System.EventHandler(this.Combo_Grupos_SelectedIndexChanged);
            // 
            // Combo_Dias
            // 
            this.Combo_Dias.Enabled = false;
            this.Combo_Dias.FormattingEnabled = true;
            this.Combo_Dias.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.Combo_Dias.Location = new System.Drawing.Point(356, 172);
            this.Combo_Dias.Name = "Combo_Dias";
            this.Combo_Dias.Size = new System.Drawing.Size(121, 21);
            this.Combo_Dias.TabIndex = 2;
            this.Combo_Dias.SelectedIndexChanged += new System.EventHandler(this.Combo_Dias_SelectedIndexChanged);
            // 
            // Combo_HoraIni_HH
            // 
            this.Combo_HoraIni_HH.Enabled = false;
            this.Combo_HoraIni_HH.FormattingEnabled = true;
            this.Combo_HoraIni_HH.Location = new System.Drawing.Point(229, 212);
            this.Combo_HoraIni_HH.Name = "Combo_HoraIni_HH";
            this.Combo_HoraIni_HH.Size = new System.Drawing.Size(40, 21);
            this.Combo_HoraIni_HH.TabIndex = 3;
            // 
            // Combo_HoraIni_MM
            // 
            this.Combo_HoraIni_MM.Enabled = false;
            this.Combo_HoraIni_MM.FormattingEnabled = true;
            this.Combo_HoraIni_MM.Location = new System.Drawing.Point(293, 212);
            this.Combo_HoraIni_MM.Name = "Combo_HoraIni_MM";
            this.Combo_HoraIni_MM.Size = new System.Drawing.Size(40, 21);
            this.Combo_HoraIni_MM.TabIndex = 4;
            // 
            // Combo_HoraFin_MM
            // 
            this.Combo_HoraFin_MM.Enabled = false;
            this.Combo_HoraFin_MM.FormattingEnabled = true;
            this.Combo_HoraFin_MM.Location = new System.Drawing.Point(471, 212);
            this.Combo_HoraFin_MM.Name = "Combo_HoraFin_MM";
            this.Combo_HoraFin_MM.Size = new System.Drawing.Size(40, 21);
            this.Combo_HoraFin_MM.TabIndex = 6;
            this.Combo_HoraFin_MM.SelectedIndexChanged += new System.EventHandler(this.Combo_HoraFin_MM_SelectedIndexChanged);
            // 
            // Combo_HoraFin_HH
            // 
            this.Combo_HoraFin_HH.Enabled = false;
            this.Combo_HoraFin_HH.FormattingEnabled = true;
            this.Combo_HoraFin_HH.Location = new System.Drawing.Point(406, 212);
            this.Combo_HoraFin_HH.Name = "Combo_HoraFin_HH";
            this.Combo_HoraFin_HH.Size = new System.Drawing.Size(40, 21);
            this.Combo_HoraFin_HH.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(275, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(452, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "HASTA";
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Enabled = false;
            this.Btn_Agregar.Location = new System.Drawing.Point(545, 70);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(125, 43);
            this.Btn_Agregar.TabIndex = 10;
            this.Btn_Agregar.Text = "AGREGAR";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "AGREGAR HORARIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "TUS HORARIOS";
            // 
            // Dgv_Horarios
            // 
            this.Dgv_Horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Horarios.Location = new System.Drawing.Point(12, 279);
            this.Dgv_Horarios.Name = "Dgv_Horarios";
            this.Dgv_Horarios.RowHeadersVisible = false;
            this.Dgv_Horarios.Size = new System.Drawing.Size(499, 137);
            this.Dgv_Horarios.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(255, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Grupo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(255, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Materia";
            // 
            // Combo_Orientacion
            // 
            this.Combo_Orientacion.FormattingEnabled = true;
            this.Combo_Orientacion.Location = new System.Drawing.Point(356, 52);
            this.Combo_Orientacion.Name = "Combo_Orientacion";
            this.Combo_Orientacion.Size = new System.Drawing.Size(121, 21);
            this.Combo_Orientacion.TabIndex = 16;
            this.Combo_Orientacion.SelectedIndexChanged += new System.EventHandler(this.Combo_Orientacion_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(255, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Orientación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(255, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Día";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Enabled = false;
            this.Btn_Eliminar.Location = new System.Drawing.Point(517, 279);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(195, 45);
            this.Btn_Eliminar.TabIndex = 19;
            this.Btn_Eliminar.Text = "ELIMINAR";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // AgendaDocenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 428);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Combo_Orientacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Dgv_Horarios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Combo_HoraFin_MM);
            this.Controls.Add(this.Combo_HoraFin_HH);
            this.Controls.Add(this.Combo_HoraIni_MM);
            this.Controls.Add(this.Combo_HoraIni_HH);
            this.Controls.Add(this.Combo_Dias);
            this.Controls.Add(this.Combo_Grupos);
            this.Controls.Add(this.Combo_Materias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgendaDocenteForm";
            this.Text = "AgendaDocente";
            this.Load += new System.EventHandler(this.AgendaDocenteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Horarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Combo_Materias;
        private System.Windows.Forms.ComboBox Combo_Grupos;
        private System.Windows.Forms.ComboBox Combo_Dias;
        private System.Windows.Forms.ComboBox Combo_HoraIni_HH;
        private System.Windows.Forms.ComboBox Combo_HoraIni_MM;
        private System.Windows.Forms.ComboBox Combo_HoraFin_MM;
        private System.Windows.Forms.ComboBox Combo_HoraFin_HH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Dgv_Horarios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Combo_Orientacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Btn_Eliminar;
    }
}