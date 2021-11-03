namespace ChatInstitucional.Presentacion
{
    partial class AdminDocenteForm
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
            this.Btn_Val = new System.Windows.Forms.Button();
            this.Btn_Mod = new System.Windows.Forms.Button();
            this.Btn_Del = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Dgv_Docentes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Materias = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Docentes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Lista de todos los docentes";
            // 
            // Btn_Val
            // 
            this.Btn_Val.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Val.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Val.Location = new System.Drawing.Point(0, 237);
            this.Btn_Val.Name = "Btn_Val";
            this.Btn_Val.Size = new System.Drawing.Size(333, 79);
            this.Btn_Val.TabIndex = 9;
            this.Btn_Val.Text = "VALIDAR INGRESOS";
            this.Btn_Val.UseVisualStyleBackColor = true;
            this.Btn_Val.Click += new System.EventHandler(this.Btn_Val_Click);
            // 
            // Btn_Mod
            // 
            this.Btn_Mod.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Mod.Enabled = false;
            this.Btn_Mod.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mod.Location = new System.Drawing.Point(0, 158);
            this.Btn_Mod.Name = "Btn_Mod";
            this.Btn_Mod.Size = new System.Drawing.Size(333, 79);
            this.Btn_Mod.TabIndex = 8;
            this.Btn_Mod.Text = "MODIFICAR";
            this.Btn_Mod.UseVisualStyleBackColor = true;
            this.Btn_Mod.Click += new System.EventHandler(this.Btn_Mod_Click);
            // 
            // Btn_Del
            // 
            this.Btn_Del.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Del.Enabled = false;
            this.Btn_Del.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Del.Location = new System.Drawing.Point(0, 79);
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(333, 79);
            this.Btn_Del.TabIndex = 6;
            this.Btn_Del.Text = "ELIMINAR";
            this.Btn_Del.UseVisualStyleBackColor = true;
            this.Btn_Del.Click += new System.EventHandler(this.Btn_Del_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.Location = new System.Drawing.Point(0, 0);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(333, 79);
            this.Btn_Add.TabIndex = 5;
            this.Btn_Add.Text = "AÑADIR";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Dgv_Docentes
            // 
            this.Dgv_Docentes.AllowUserToAddRows = false;
            this.Dgv_Docentes.AllowUserToDeleteRows = false;
            this.Dgv_Docentes.AllowUserToResizeColumns = false;
            this.Dgv_Docentes.AllowUserToResizeRows = false;
            this.Dgv_Docentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Docentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Docentes.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Docentes.MultiSelect = false;
            this.Dgv_Docentes.Name = "Dgv_Docentes";
            this.Dgv_Docentes.ReadOnly = true;
            this.Dgv_Docentes.RowHeadersVisible = false;
            this.Dgv_Docentes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Docentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Docentes.Size = new System.Drawing.Size(385, 392);
            this.Dgv_Docentes.TabIndex = 11;
            this.Dgv_Docentes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_Docentes_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dgv_Docentes);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 392);
            this.panel1.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_Materias);
            this.panel2.Controls.Add(this.Btn_Val);
            this.panel2.Controls.Add(this.Btn_Mod);
            this.panel2.Controls.Add(this.Btn_Del);
            this.panel2.Controls.Add(this.Btn_Add);
            this.panel2.Location = new System.Drawing.Point(384, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 392);
            this.panel2.TabIndex = 44;
            // 
            // Btn_Materias
            // 
            this.Btn_Materias.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Materias.Enabled = false;
            this.Btn_Materias.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Materias.Location = new System.Drawing.Point(0, 316);
            this.Btn_Materias.Name = "Btn_Materias";
            this.Btn_Materias.Size = new System.Drawing.Size(333, 76);
            this.Btn_Materias.TabIndex = 10;
            this.Btn_Materias.Text = "VER AGENDA";
            this.Btn_Materias.UseVisualStyleBackColor = true;
            this.Btn_Materias.Click += new System.EventHandler(this.Btn_Materias_Click);
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
            this.Btn_Refresh.Location = new System.Drawing.Point(677, 5);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(36, 27);
            this.Btn_Refresh.TabIndex = 7;
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // AdminDocenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Refresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDocenteForm";
            this.Text = "AdminDocenteForm";
            this.Load += new System.EventHandler(this.AdminDocenteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Docentes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Val;
        private System.Windows.Forms.Button Btn_Mod;
        private System.Windows.Forms.Button Btn_Del;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.DataGridView Dgv_Docentes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Materias;
    }
}