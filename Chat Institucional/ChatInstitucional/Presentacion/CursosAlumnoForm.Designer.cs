
namespace ChatInstitucional.Presentacion
{
    partial class CursosAlumnoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_Materias = new System.Windows.Forms.DataGridView();
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.Btn_Unirse = new System.Windows.Forms.Button();
            this.Text_NomDocente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Materias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materias";
            // 
            // Dgv_Materias
            // 
            this.Dgv_Materias.AllowUserToAddRows = false;
            this.Dgv_Materias.AllowUserToDeleteRows = false;
            this.Dgv_Materias.AllowUserToResizeColumns = false;
            this.Dgv_Materias.AllowUserToResizeRows = false;
            this.Dgv_Materias.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Materias.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Materias.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Materias.GridColor = System.Drawing.Color.White;
            this.Dgv_Materias.Location = new System.Drawing.Point(44, 62);
            this.Dgv_Materias.Name = "Dgv_Materias";
            this.Dgv_Materias.ReadOnly = true;
            this.Dgv_Materias.RowHeadersVisible = false;
            this.Dgv_Materias.RowHeadersWidth = 240;
            this.Dgv_Materias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Materias.Size = new System.Drawing.Size(240, 336);
            this.Dgv_Materias.TabIndex = 1;
            this.Dgv_Materias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Materias_CellContentClick);
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.Enabled = false;
            this.Btn_Crear.Location = new System.Drawing.Point(457, 62);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(158, 23);
            this.Btn_Crear.TabIndex = 2;
            this.Btn_Crear.Text = "CREAR CHAT";
            this.Btn_Crear.UseVisualStyleBackColor = true;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // Btn_Unirse
            // 
            this.Btn_Unirse.Enabled = false;
            this.Btn_Unirse.Location = new System.Drawing.Point(457, 91);
            this.Btn_Unirse.Name = "Btn_Unirse";
            this.Btn_Unirse.Size = new System.Drawing.Size(158, 23);
            this.Btn_Unirse.TabIndex = 3;
            this.Btn_Unirse.Text = "UNIRSE AL CHAT";
            this.Btn_Unirse.UseVisualStyleBackColor = true;
            this.Btn_Unirse.Click += new System.EventHandler(this.Btn_Unirse_Click);
            // 
            // Text_NomDocente
            // 
            this.Text_NomDocente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_NomDocente.Location = new System.Drawing.Point(457, 293);
            this.Text_NomDocente.Name = "Text_NomDocente";
            this.Text_NomDocente.ReadOnly = true;
            this.Text_NomDocente.Size = new System.Drawing.Size(158, 13);
            this.Text_NomDocente.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Docente";
            // 
            // CursosAlumnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 428);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Text_NomDocente);
            this.Controls.Add(this.Btn_Unirse);
            this.Controls.Add(this.Btn_Crear);
            this.Controls.Add(this.Dgv_Materias);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CursosAlumnoForm";
            this.Text = "CursosAlumnoForm";
            this.Load += new System.EventHandler(this.CursosAlumnoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Materias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_Materias;
        private System.Windows.Forms.Button Btn_Crear;
        private System.Windows.Forms.Button Btn_Unirse;
        private System.Windows.Forms.TextBox Text_NomDocente;
        private System.Windows.Forms.Label label2;
    }
}