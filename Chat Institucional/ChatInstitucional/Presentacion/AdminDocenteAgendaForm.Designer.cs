namespace ChatInstitucional.Presentacion
{
    partial class AdminDocenteAgendaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDocenteAgendaForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.Dgv_Materias = new System.Windows.Forms.DataGridView();
            this.Btn_Refresh_Materia = new System.Windows.Forms.Button();
            this.Btn_Eliminar_Materia = new System.Windows.Forms.Button();
            this.Btn_Agregar_Materia = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Combo_Orientacion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Combo_Grupos = new System.Windows.Forms.ComboBox();
            this.Combo_Materias = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Combo_Dias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_Horaios = new System.Windows.Forms.DataGridView();
            this.Btn_Refresh_Horario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Materias)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Horaios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Dgv_Materias);
            this.panel1.Controls.Add(this.Btn_Refresh_Materia);
            this.panel1.Controls.Add(this.Btn_Eliminar_Materia);
            this.panel1.Controls.Add(this.Btn_Agregar_Materia);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Combo_Orientacion);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Combo_Grupos);
            this.panel1.Controls.Add(this.Combo_Materias);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(354, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 450);
            this.panel1.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(353, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "MATERIAS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dgv_Materias
            // 
            this.Dgv_Materias.AllowUserToAddRows = false;
            this.Dgv_Materias.AllowUserToDeleteRows = false;
            this.Dgv_Materias.AllowUserToResizeColumns = false;
            this.Dgv_Materias.AllowUserToResizeRows = false;
            this.Dgv_Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Materias.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv_Materias.Location = new System.Drawing.Point(0, 233);
            this.Dgv_Materias.MultiSelect = false;
            this.Dgv_Materias.Name = "Dgv_Materias";
            this.Dgv_Materias.ReadOnly = true;
            this.Dgv_Materias.RowHeadersVisible = false;
            this.Dgv_Materias.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Dgv_Materias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Materias.Size = new System.Drawing.Size(353, 213);
            this.Dgv_Materias.TabIndex = 18;
            this.Dgv_Materias.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_Materias_MouseClick);
            // 
            // Btn_Refresh_Materia
            // 
            this.Btn_Refresh_Materia.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Refresh_Materia.BackgroundImage = global::ChatInstitucional.Properties.Resources.refresh;
            this.Btn_Refresh_Materia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Refresh_Materia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Refresh_Materia.FlatAppearance.BorderSize = 0;
            this.Btn_Refresh_Materia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Refresh_Materia.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refresh_Materia.ForeColor = System.Drawing.Color.White;
            this.Btn_Refresh_Materia.Location = new System.Drawing.Point(4, 3);
            this.Btn_Refresh_Materia.Name = "Btn_Refresh_Materia";
            this.Btn_Refresh_Materia.Size = new System.Drawing.Size(36, 27);
            this.Btn_Refresh_Materia.TabIndex = 21;
            this.Btn_Refresh_Materia.UseVisualStyleBackColor = false;
            this.Btn_Refresh_Materia.Click += new System.EventHandler(this.Btn_Refresh_Materia_Click);
            // 
            // Btn_Eliminar_Materia
            // 
            this.Btn_Eliminar_Materia.Enabled = false;
            this.Btn_Eliminar_Materia.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar_Materia.Location = new System.Drawing.Point(197, 174);
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
            this.Btn_Agregar_Materia.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar_Materia.Location = new System.Drawing.Point(51, 174);
            this.Btn_Agregar_Materia.Name = "Btn_Agregar_Materia";
            this.Btn_Agregar_Materia.Size = new System.Drawing.Size(103, 28);
            this.Btn_Agregar_Materia.TabIndex = 20;
            this.Btn_Agregar_Materia.Text = "AGREGAR";
            this.Btn_Agregar_Materia.UseVisualStyleBackColor = true;
            this.Btn_Agregar_Materia.Click += new System.EventHandler(this.Btn_Agregar_Materia_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(353, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "AGREGAR MATERIA A DOCENTE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Orientación";
            // 
            // Combo_Orientacion
            // 
            this.Combo_Orientacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Orientacion.FormattingEnabled = true;
            this.Combo_Orientacion.Location = new System.Drawing.Point(168, 49);
            this.Combo_Orientacion.Name = "Combo_Orientacion";
            this.Combo_Orientacion.Size = new System.Drawing.Size(121, 21);
            this.Combo_Orientacion.TabIndex = 16;
            this.Combo_Orientacion.SelectedIndexChanged += new System.EventHandler(this.Combo_Orientacion_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Materia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Grupo";
            // 
            // Combo_Grupos
            // 
            this.Combo_Grupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Grupos.Enabled = false;
            this.Combo_Grupos.FormattingEnabled = true;
            this.Combo_Grupos.Location = new System.Drawing.Point(168, 89);
            this.Combo_Grupos.Name = "Combo_Grupos";
            this.Combo_Grupos.Size = new System.Drawing.Size(121, 21);
            this.Combo_Grupos.TabIndex = 1;
            this.Combo_Grupos.SelectedIndexChanged += new System.EventHandler(this.Combo_Grupos_SelectedIndexChanged);
            // 
            // Combo_Materias
            // 
            this.Combo_Materias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Materias.Enabled = false;
            this.Combo_Materias.FormattingEnabled = true;
            this.Combo_Materias.Location = new System.Drawing.Point(168, 129);
            this.Combo_Materias.Name = "Combo_Materias";
            this.Combo_Materias.Size = new System.Drawing.Size(121, 21);
            this.Combo_Materias.TabIndex = 0;
            this.Combo_Materias.SelectedIndexChanged += new System.EventHandler(this.Combo_Materias_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Btn_Refresh_Horario);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Combo_Dias);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Dgv_Horaios);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 450);
            this.panel2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "HORARIOS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Seleccione de que día quiere ver los horarios";
            // 
            // Combo_Dias
            // 
            this.Combo_Dias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Dias.FormattingEnabled = true;
            this.Combo_Dias.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.Combo_Dias.Location = new System.Drawing.Point(71, 128);
            this.Combo_Dias.Name = "Combo_Dias";
            this.Combo_Dias.Size = new System.Drawing.Size(206, 21);
            this.Combo_Dias.TabIndex = 23;
            this.Combo_Dias.SelectedValueChanged += new System.EventHandler(this.Combo_Dias_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "HORARIOS DOCENTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dgv_Horaios
            // 
            this.Dgv_Horaios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Horaios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv_Horaios.Location = new System.Drawing.Point(0, 233);
            this.Dgv_Horaios.Name = "Dgv_Horaios";
            this.Dgv_Horaios.Size = new System.Drawing.Size(349, 213);
            this.Dgv_Horaios.TabIndex = 1;
            // 
            // Btn_Refresh_Horario
            // 
            this.Btn_Refresh_Horario.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Refresh_Horario.BackgroundImage = global::ChatInstitucional.Properties.Resources.refresh;
            this.Btn_Refresh_Horario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Refresh_Horario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Refresh_Horario.FlatAppearance.BorderSize = 0;
            this.Btn_Refresh_Horario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Refresh_Horario.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refresh_Horario.ForeColor = System.Drawing.Color.White;
            this.Btn_Refresh_Horario.Location = new System.Drawing.Point(313, 3);
            this.Btn_Refresh_Horario.Name = "Btn_Refresh_Horario";
            this.Btn_Refresh_Horario.Size = new System.Drawing.Size(36, 27);
            this.Btn_Refresh_Horario.TabIndex = 26;
            this.Btn_Refresh_Horario.UseVisualStyleBackColor = false;
            this.Btn_Refresh_Horario.Click += new System.EventHandler(this.Btn_Refresh_Horario_Click);
            // 
            // AdminDocenteAgendaForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDocenteAgendaForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AdminDocenteMateriasForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Materias)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Horaios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView Dgv_Materias;
        private System.Windows.Forms.Button Btn_Refresh_Materia;
        private System.Windows.Forms.Button Btn_Eliminar_Materia;
        private System.Windows.Forms.Button Btn_Agregar_Materia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Combo_Orientacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Combo_Grupos;
        private System.Windows.Forms.ComboBox Combo_Materias;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Dgv_Horaios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Combo_Dias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Refresh_Horario;
    }
}