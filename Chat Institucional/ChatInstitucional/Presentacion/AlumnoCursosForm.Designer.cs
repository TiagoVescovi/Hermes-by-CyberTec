
namespace ChatInstitucional.Presentacion
{
    partial class AlumnoCursosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_Materias = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.Btn_Unirse = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Materias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 24);
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
            this.Dgv_Materias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Materias.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Materias.GridColor = System.Drawing.Color.White;
            this.Dgv_Materias.Location = new System.Drawing.Point(44, 62);
            this.Dgv_Materias.MultiSelect = false;
            this.Dgv_Materias.Name = "Dgv_Materias";
            this.Dgv_Materias.ReadOnly = true;
            this.Dgv_Materias.RowHeadersVisible = false;
            this.Dgv_Materias.RowHeadersWidth = 240;
            this.Dgv_Materias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Materias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Materias.Size = new System.Drawing.Size(419, 336);
            this.Dgv_Materias.TabIndex = 1;
            this.Dgv_Materias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Materias_CellClick);
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.Enabled = false;
            this.Btn_Crear.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Crear.Location = new System.Drawing.Point(475, 62);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(212, 80);
            this.Btn_Crear.TabIndex = 2;
            this.Btn_Crear.Text = "CREAR CHAT";
            this.Btn_Crear.UseVisualStyleBackColor = true;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // Btn_Unirse
            // 
            this.Btn_Unirse.Enabled = false;
            this.Btn_Unirse.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Unirse.Location = new System.Drawing.Point(475, 148);
            this.Btn_Unirse.Name = "Btn_Unirse";
            this.Btn_Unirse.Size = new System.Drawing.Size(212, 80);
            this.Btn_Unirse.TabIndex = 3;
            this.Btn_Unirse.Text = "UNIRSE AL CHAT";
            this.Btn_Unirse.UseVisualStyleBackColor = true;
            this.Btn_Unirse.Click += new System.EventHandler(this.Btn_Unirse_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Refresh.BackgroundImage = global::ChatInstitucional.Properties.Resources.refresh;
            this.Btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Refresh.FlatAppearance.BorderSize = 0;
            this.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Refresh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.Btn_Refresh.Location = new System.Drawing.Point(12, 12);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(36, 27);
            this.Btn_Refresh.TabIndex = 7;
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // AlumnoCursosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 428);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Btn_Unirse);
            this.Controls.Add(this.Btn_Crear);
            this.Controls.Add(this.Dgv_Materias);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlumnoCursosForm";
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
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}