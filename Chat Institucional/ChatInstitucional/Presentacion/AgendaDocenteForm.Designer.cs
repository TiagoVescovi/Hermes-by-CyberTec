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
            this.Btn_Agregar_Horario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dgv_Horarios = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Combo_Orientacion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_Eliminar_Horario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dgv_Materias = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Btn_Eliminar_Materia = new System.Windows.Forms.Button();
            this.Btn_Agregar_Materia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Horarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Materias)).BeginInit();
            this.SuspendLayout();
            // 
            // Combo_Materias
            // 
            this.Combo_Materias.Enabled = false;
            this.Combo_Materias.FormattingEnabled = true;
            this.Combo_Materias.Location = new System.Drawing.Point(168, 118);
            this.Combo_Materias.Name = "Combo_Materias";
            this.Combo_Materias.Size = new System.Drawing.Size(121, 21);
            this.Combo_Materias.TabIndex = 0;
            this.Combo_Materias.SelectedIndexChanged += new System.EventHandler(this.Combo_Materias_SelectedIndexChanged);
            // 
            // Combo_Grupos
            // 
            this.Combo_Grupos.Enabled = false;
            this.Combo_Grupos.FormattingEnabled = true;
            this.Combo_Grupos.Location = new System.Drawing.Point(168, 78);
            this.Combo_Grupos.Name = "Combo_Grupos";
            this.Combo_Grupos.Size = new System.Drawing.Size(121, 21);
            this.Combo_Grupos.TabIndex = 1;
            this.Combo_Grupos.SelectedIndexChanged += new System.EventHandler(this.Combo_Grupos_SelectedIndexChanged);
            // 
            // Combo_Dias
            // 
            this.Combo_Dias.FormattingEnabled = true;
            this.Combo_Dias.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.Combo_Dias.Location = new System.Drawing.Point(122, 55);
            this.Combo_Dias.Name = "Combo_Dias";
            this.Combo_Dias.Size = new System.Drawing.Size(121, 21);
            this.Combo_Dias.TabIndex = 2;
            this.Combo_Dias.SelectedIndexChanged += new System.EventHandler(this.Combo_Dias_SelectedIndexChanged);
            // 
            // Combo_HoraIni_HH
            // 
            this.Combo_HoraIni_HH.Enabled = false;
            this.Combo_HoraIni_HH.FormattingEnabled = true;
            this.Combo_HoraIni_HH.Location = new System.Drawing.Point(26, 93);
            this.Combo_HoraIni_HH.Name = "Combo_HoraIni_HH";
            this.Combo_HoraIni_HH.Size = new System.Drawing.Size(40, 21);
            this.Combo_HoraIni_HH.TabIndex = 3;
            // 
            // Combo_HoraIni_MM
            // 
            this.Combo_HoraIni_MM.Enabled = false;
            this.Combo_HoraIni_MM.FormattingEnabled = true;
            this.Combo_HoraIni_MM.Location = new System.Drawing.Point(90, 93);
            this.Combo_HoraIni_MM.Name = "Combo_HoraIni_MM";
            this.Combo_HoraIni_MM.Size = new System.Drawing.Size(40, 21);
            this.Combo_HoraIni_MM.TabIndex = 4;
            // 
            // Combo_HoraFin_MM
            // 
            this.Combo_HoraFin_MM.Enabled = false;
            this.Combo_HoraFin_MM.FormattingEnabled = true;
            this.Combo_HoraFin_MM.Location = new System.Drawing.Point(268, 93);
            this.Combo_HoraFin_MM.Name = "Combo_HoraFin_MM";
            this.Combo_HoraFin_MM.Size = new System.Drawing.Size(40, 21);
            this.Combo_HoraFin_MM.TabIndex = 6;
            this.Combo_HoraFin_MM.SelectedIndexChanged += new System.EventHandler(this.Combo_HoraFin_MM_SelectedIndexChanged);
            // 
            // Combo_HoraFin_HH
            // 
            this.Combo_HoraFin_HH.Enabled = false;
            this.Combo_HoraFin_HH.FormattingEnabled = true;
            this.Combo_HoraFin_HH.Location = new System.Drawing.Point(203, 93);
            this.Combo_HoraFin_HH.Name = "Combo_HoraFin_HH";
            this.Combo_HoraFin_HH.Size = new System.Drawing.Size(40, 21);
            this.Combo_HoraFin_HH.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(72, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(249, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "HASTA";
            // 
            // Btn_Agregar_Horario
            // 
            this.Btn_Agregar_Horario.Enabled = false;
            this.Btn_Agregar_Horario.Location = new System.Drawing.Point(47, 149);
            this.Btn_Agregar_Horario.Name = "Btn_Agregar_Horario";
            this.Btn_Agregar_Horario.Size = new System.Drawing.Size(103, 28);
            this.Btn_Agregar_Horario.TabIndex = 10;
            this.Btn_Agregar_Horario.Text = "AGREGAR";
            this.Btn_Agregar_Horario.UseVisualStyleBackColor = true;
            this.Btn_Agregar_Horario.Click += new System.EventHandler(this.Btn_Agregar_Horario_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "AGREGAR HORARIO DE ATENCIÓN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(354, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "TUS HORARIOS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dgv_Horarios
            // 
            this.Dgv_Horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Horarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv_Horarios.Location = new System.Drawing.Point(0, 211);
            this.Dgv_Horarios.Name = "Dgv_Horarios";
            this.Dgv_Horarios.RowHeadersVisible = false;
            this.Dgv_Horarios.Size = new System.Drawing.Size(354, 213);
            this.Dgv_Horarios.TabIndex = 13;
            this.Dgv_Horarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Horarios_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Grupo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Materia";
            // 
            // Combo_Orientacion
            // 
            this.Combo_Orientacion.FormattingEnabled = true;
            this.Combo_Orientacion.Location = new System.Drawing.Point(168, 38);
            this.Combo_Orientacion.Name = "Combo_Orientacion";
            this.Combo_Orientacion.Size = new System.Drawing.Size(121, 21);
            this.Combo_Orientacion.TabIndex = 16;
            this.Combo_Orientacion.SelectedIndexChanged += new System.EventHandler(this.Combo_Orientacion_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Orientación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(76, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Día";
            // 
            // Btn_Eliminar_Horario
            // 
            this.Btn_Eliminar_Horario.Enabled = false;
            this.Btn_Eliminar_Horario.Location = new System.Drawing.Point(193, 149);
            this.Btn_Eliminar_Horario.Name = "Btn_Eliminar_Horario";
            this.Btn_Eliminar_Horario.Size = new System.Drawing.Size(103, 28);
            this.Btn_Eliminar_Horario.TabIndex = 19;
            this.Btn_Eliminar_Horario.Text = "ELIMINAR";
            this.Btn_Eliminar_Horario.UseVisualStyleBackColor = true;
            this.Btn_Eliminar_Horario.Click += new System.EventHandler(this.Btn_Eliminar_Horario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Btn_Eliminar_Materia);
            this.panel1.Controls.Add(this.Btn_Agregar_Materia);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Dgv_Materias);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Combo_Orientacion);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Combo_Grupos);
            this.panel1.Controls.Add(this.Combo_Materias);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(359, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 428);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Btn_Eliminar_Horario);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Btn_Agregar_Horario);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Combo_HoraFin_MM);
            this.panel2.Controls.Add(this.Combo_HoraFin_HH);
            this.panel2.Controls.Add(this.Combo_HoraIni_MM);
            this.panel2.Controls.Add(this.Combo_HoraIni_HH);
            this.panel2.Controls.Add(this.Combo_Dias);
            this.panel2.Controls.Add(this.Dgv_Horarios);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 428);
            this.panel2.TabIndex = 21;
            // 
            // Dgv_Materias
            // 
            this.Dgv_Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Materias.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv_Materias.Location = new System.Drawing.Point(0, 211);
            this.Dgv_Materias.Name = "Dgv_Materias";
            this.Dgv_Materias.RowHeadersVisible = false;
            this.Dgv_Materias.Size = new System.Drawing.Size(354, 213);
            this.Dgv_Materias.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(354, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "TUS MATERIAS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(354, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "AGREGAR MATERIA";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Eliminar_Materia
            // 
            this.Btn_Eliminar_Materia.Enabled = false;
            this.Btn_Eliminar_Materia.Location = new System.Drawing.Point(197, 149);
            this.Btn_Eliminar_Materia.Name = "Btn_Eliminar_Materia";
            this.Btn_Eliminar_Materia.Size = new System.Drawing.Size(103, 28);
            this.Btn_Eliminar_Materia.TabIndex = 21;
            this.Btn_Eliminar_Materia.Text = "ELIMINAR";
            this.Btn_Eliminar_Materia.UseVisualStyleBackColor = true;
            this.Btn_Eliminar_Materia.Click += new System.EventHandler(this.Btn_Eliminar_Materia_Click);
            // 
            // Btn_Agregar_Materia
            // 
            this.Btn_Agregar_Materia.Enabled = false;
            this.Btn_Agregar_Materia.Location = new System.Drawing.Point(51, 149);
            this.Btn_Agregar_Materia.Name = "Btn_Agregar_Materia";
            this.Btn_Agregar_Materia.Size = new System.Drawing.Size(103, 28);
            this.Btn_Agregar_Materia.TabIndex = 20;
            this.Btn_Agregar_Materia.Text = "AGREGAR";
            this.Btn_Agregar_Materia.UseVisualStyleBackColor = true;
            this.Btn_Agregar_Materia.Click += new System.EventHandler(this.Btn_Agregar_Materia_Click);
            // 
            // AgendaDocenteForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(717, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgendaDocenteForm";
            this.Text = "AgendaDocente";
            this.Load += new System.EventHandler(this.AgendaDocenteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Horarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Materias)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button Btn_Agregar_Horario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Dgv_Horarios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Combo_Orientacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Btn_Eliminar_Horario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Dgv_Materias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Btn_Eliminar_Materia;
        private System.Windows.Forms.Button Btn_Agregar_Materia;
    }
}