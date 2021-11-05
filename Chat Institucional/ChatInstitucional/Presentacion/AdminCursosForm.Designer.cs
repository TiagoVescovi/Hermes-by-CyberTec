namespace ChatInstitucional.Presentacion
{
    partial class AdminCursosForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Mod_Mat = new System.Windows.Forms.Button();
            this.Btn_Del_Mat = new System.Windows.Forms.Button();
            this.Btn_Add_Mat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_Ori = new System.Windows.Forms.DataGridView();
            this.Dgv_Grupos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_Materias = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Mod_Gr = new System.Windows.Forms.Button();
            this.Btn_Del_Gr = new System.Windows.Forms.Button();
            this.Btn_Add_Gr = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Mod_Ori = new System.Windows.Forms.Button();
            this.Btn_Del_Ori = new System.Windows.Forms.Button();
            this.Btn_Add_Ori = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Grupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Materias)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_Mod_Mat);
            this.panel2.Controls.Add(this.Btn_Del_Mat);
            this.panel2.Controls.Add(this.Btn_Add_Mat);
            this.panel2.Location = new System.Drawing.Point(494, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 165);
            this.panel2.TabIndex = 48;
            // 
            // Btn_Mod_Mat
            // 
            this.Btn_Mod_Mat.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Mod_Mat.Enabled = false;
            this.Btn_Mod_Mat.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mod_Mat.Location = new System.Drawing.Point(0, 108);
            this.Btn_Mod_Mat.Name = "Btn_Mod_Mat";
            this.Btn_Mod_Mat.Size = new System.Drawing.Size(217, 54);
            this.Btn_Mod_Mat.TabIndex = 8;
            this.Btn_Mod_Mat.Text = "MODIFICAR";
            this.Btn_Mod_Mat.UseVisualStyleBackColor = true;
            this.Btn_Mod_Mat.Click += new System.EventHandler(this.Btn_Mod_Mat_Click);
            // 
            // Btn_Del_Mat
            // 
            this.Btn_Del_Mat.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Del_Mat.Enabled = false;
            this.Btn_Del_Mat.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Del_Mat.Location = new System.Drawing.Point(0, 54);
            this.Btn_Del_Mat.Name = "Btn_Del_Mat";
            this.Btn_Del_Mat.Size = new System.Drawing.Size(217, 54);
            this.Btn_Del_Mat.TabIndex = 6;
            this.Btn_Del_Mat.Text = "ELIMINAR";
            this.Btn_Del_Mat.UseVisualStyleBackColor = true;
            this.Btn_Del_Mat.Click += new System.EventHandler(this.Btn_Del_Mat_Click);
            // 
            // Btn_Add_Mat
            // 
            this.Btn_Add_Mat.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Add_Mat.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add_Mat.Location = new System.Drawing.Point(0, 0);
            this.Btn_Add_Mat.Name = "Btn_Add_Mat";
            this.Btn_Add_Mat.Size = new System.Drawing.Size(217, 54);
            this.Btn_Add_Mat.TabIndex = 5;
            this.Btn_Add_Mat.Text = "AÑADIR";
            this.Btn_Add_Mat.UseVisualStyleBackColor = true;
            this.Btn_Add_Mat.Click += new System.EventHandler(this.Btn_Add_Mat_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "ORIENTACIONES";
            // 
            // Dgv_Ori
            // 
            this.Dgv_Ori.AllowUserToAddRows = false;
            this.Dgv_Ori.AllowUserToDeleteRows = false;
            this.Dgv_Ori.AllowUserToResizeColumns = false;
            this.Dgv_Ori.AllowUserToResizeRows = false;
            this.Dgv_Ori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Ori.ColumnHeadersVisible = false;
            this.Dgv_Ori.Location = new System.Drawing.Point(8, 45);
            this.Dgv_Ori.MultiSelect = false;
            this.Dgv_Ori.Name = "Dgv_Ori";
            this.Dgv_Ori.ReadOnly = true;
            this.Dgv_Ori.RowHeadersVisible = false;
            this.Dgv_Ori.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Ori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Ori.Size = new System.Drawing.Size(217, 178);
            this.Dgv_Ori.TabIndex = 11;
            this.Dgv_Ori.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_Ori_MouseClick);
            // 
            // Dgv_Grupos
            // 
            this.Dgv_Grupos.AllowUserToAddRows = false;
            this.Dgv_Grupos.AllowUserToDeleteRows = false;
            this.Dgv_Grupos.AllowUserToResizeColumns = false;
            this.Dgv_Grupos.AllowUserToResizeRows = false;
            this.Dgv_Grupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Grupos.ColumnHeadersVisible = false;
            this.Dgv_Grupos.Location = new System.Drawing.Point(251, 45);
            this.Dgv_Grupos.MultiSelect = false;
            this.Dgv_Grupos.Name = "Dgv_Grupos";
            this.Dgv_Grupos.ReadOnly = true;
            this.Dgv_Grupos.RowHeadersVisible = false;
            this.Dgv_Grupos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Grupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Grupos.Size = new System.Drawing.Size(217, 178);
            this.Dgv_Grupos.TabIndex = 49;
            this.Dgv_Grupos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_Grupos_MouseClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "GRUPOS";
            // 
            // Dgv_Materias
            // 
            this.Dgv_Materias.AllowUserToAddRows = false;
            this.Dgv_Materias.AllowUserToDeleteRows = false;
            this.Dgv_Materias.AllowUserToResizeColumns = false;
            this.Dgv_Materias.AllowUserToResizeRows = false;
            this.Dgv_Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Materias.ColumnHeadersVisible = false;
            this.Dgv_Materias.Location = new System.Drawing.Point(494, 45);
            this.Dgv_Materias.MultiSelect = false;
            this.Dgv_Materias.Name = "Dgv_Materias";
            this.Dgv_Materias.ReadOnly = true;
            this.Dgv_Materias.RowHeadersVisible = false;
            this.Dgv_Materias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Materias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Materias.Size = new System.Drawing.Size(217, 178);
            this.Dgv_Materias.TabIndex = 51;
            this.Dgv_Materias.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_Materias_MouseClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(551, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "MATERIAS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Mod_Gr);
            this.panel1.Controls.Add(this.Btn_Del_Gr);
            this.panel1.Controls.Add(this.Btn_Add_Gr);
            this.panel1.Location = new System.Drawing.Point(251, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 165);
            this.panel1.TabIndex = 49;
            // 
            // Btn_Mod_Gr
            // 
            this.Btn_Mod_Gr.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Mod_Gr.Enabled = false;
            this.Btn_Mod_Gr.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mod_Gr.Location = new System.Drawing.Point(0, 108);
            this.Btn_Mod_Gr.Name = "Btn_Mod_Gr";
            this.Btn_Mod_Gr.Size = new System.Drawing.Size(217, 54);
            this.Btn_Mod_Gr.TabIndex = 8;
            this.Btn_Mod_Gr.Text = "MODIFICAR";
            this.Btn_Mod_Gr.UseVisualStyleBackColor = true;
            this.Btn_Mod_Gr.Click += new System.EventHandler(this.Btn_Mod_Gr_Click);
            // 
            // Btn_Del_Gr
            // 
            this.Btn_Del_Gr.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Del_Gr.Enabled = false;
            this.Btn_Del_Gr.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Del_Gr.Location = new System.Drawing.Point(0, 54);
            this.Btn_Del_Gr.Name = "Btn_Del_Gr";
            this.Btn_Del_Gr.Size = new System.Drawing.Size(217, 54);
            this.Btn_Del_Gr.TabIndex = 6;
            this.Btn_Del_Gr.Text = "ELIMINAR";
            this.Btn_Del_Gr.UseVisualStyleBackColor = true;
            this.Btn_Del_Gr.Click += new System.EventHandler(this.Btn_Del_Gr_Click);
            // 
            // Btn_Add_Gr
            // 
            this.Btn_Add_Gr.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Add_Gr.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add_Gr.Location = new System.Drawing.Point(0, 0);
            this.Btn_Add_Gr.Name = "Btn_Add_Gr";
            this.Btn_Add_Gr.Size = new System.Drawing.Size(217, 54);
            this.Btn_Add_Gr.TabIndex = 5;
            this.Btn_Add_Gr.Text = "AÑADIR";
            this.Btn_Add_Gr.UseVisualStyleBackColor = true;
            this.Btn_Add_Gr.Click += new System.EventHandler(this.Btn_Add_Gr_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Btn_Mod_Ori);
            this.panel3.Controls.Add(this.Btn_Del_Ori);
            this.panel3.Controls.Add(this.Btn_Add_Ori);
            this.panel3.Location = new System.Drawing.Point(8, 262);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 165);
            this.panel3.TabIndex = 49;
            // 
            // Btn_Mod_Ori
            // 
            this.Btn_Mod_Ori.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Mod_Ori.Enabled = false;
            this.Btn_Mod_Ori.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mod_Ori.Location = new System.Drawing.Point(0, 108);
            this.Btn_Mod_Ori.Name = "Btn_Mod_Ori";
            this.Btn_Mod_Ori.Size = new System.Drawing.Size(217, 54);
            this.Btn_Mod_Ori.TabIndex = 8;
            this.Btn_Mod_Ori.Text = "MODIFICAR";
            this.Btn_Mod_Ori.UseVisualStyleBackColor = true;
            this.Btn_Mod_Ori.Click += new System.EventHandler(this.Btn_Mod_Ori_Click);
            // 
            // Btn_Del_Ori
            // 
            this.Btn_Del_Ori.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Del_Ori.Enabled = false;
            this.Btn_Del_Ori.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Del_Ori.Location = new System.Drawing.Point(0, 54);
            this.Btn_Del_Ori.Name = "Btn_Del_Ori";
            this.Btn_Del_Ori.Size = new System.Drawing.Size(217, 54);
            this.Btn_Del_Ori.TabIndex = 6;
            this.Btn_Del_Ori.Text = "ELIMINAR";
            this.Btn_Del_Ori.UseVisualStyleBackColor = true;
            this.Btn_Del_Ori.Click += new System.EventHandler(this.Btn_Del_Ori_Click);
            // 
            // Btn_Add_Ori
            // 
            this.Btn_Add_Ori.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Add_Ori.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add_Ori.Location = new System.Drawing.Point(0, 0);
            this.Btn_Add_Ori.Name = "Btn_Add_Ori";
            this.Btn_Add_Ori.Size = new System.Drawing.Size(217, 54);
            this.Btn_Add_Ori.TabIndex = 5;
            this.Btn_Add_Ori.Text = "AÑADIR";
            this.Btn_Add_Ori.UseVisualStyleBackColor = true;
            this.Btn_Add_Ori.Click += new System.EventHandler(this.Btn_Add_Ori_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Refresh.BackgroundImage = global::Hermes.Properties.Resources.refresh;
            this.Btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Refresh.FlatAppearance.BorderSize = 0;
            this.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Refresh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.Btn_Refresh.Location = new System.Drawing.Point(677, 3);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(36, 27);
            this.Btn_Refresh.TabIndex = 45;
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // AdminCursosForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 428);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dgv_Materias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dgv_Grupos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dgv_Ori);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Refresh);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminCursosForm";
            this.Text = "AdminUsersForm";
            this.Load += new System.EventHandler(this.AdminCursosForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Grupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Materias)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Mod_Mat;
        private System.Windows.Forms.Button Btn_Del_Mat;
        private System.Windows.Forms.Button Btn_Add_Mat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_Ori;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.DataGridView Dgv_Grupos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_Materias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Mod_Gr;
        private System.Windows.Forms.Button Btn_Del_Gr;
        private System.Windows.Forms.Button Btn_Add_Gr;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_Mod_Ori;
        private System.Windows.Forms.Button Btn_Del_Ori;
        private System.Windows.Forms.Button Btn_Add_Ori;
    }
}