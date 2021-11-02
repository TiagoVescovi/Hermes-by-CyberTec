namespace ChatInstitucional.Presentacion
{
    partial class AdminValidarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminValidarForm));
            this.Dgv_Alumnos = new System.Windows.Forms.DataGridView();
            this.Btn_Activar = new System.Windows.Forms.Button();
            this.Btn_Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Alumnos
            // 
            this.Dgv_Alumnos.AllowUserToAddRows = false;
            this.Dgv_Alumnos.AllowUserToDeleteRows = false;
            this.Dgv_Alumnos.AllowUserToResizeColumns = false;
            this.Dgv_Alumnos.AllowUserToResizeRows = false;
            this.Dgv_Alumnos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Alumnos.Location = new System.Drawing.Point(11, 12);
            this.Dgv_Alumnos.MultiSelect = false;
            this.Dgv_Alumnos.Name = "Dgv_Alumnos";
            this.Dgv_Alumnos.ReadOnly = true;
            this.Dgv_Alumnos.RowHeadersVisible = false;
            this.Dgv_Alumnos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Alumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Alumnos.Size = new System.Drawing.Size(260, 326);
            this.Dgv_Alumnos.TabIndex = 0;
            this.Dgv_Alumnos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_Alumnos_MouseClick);
            // 
            // Btn_Activar
            // 
            this.Btn_Activar.Enabled = false;
            this.Btn_Activar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Activar.Location = new System.Drawing.Point(11, 344);
            this.Btn_Activar.Name = "Btn_Activar";
            this.Btn_Activar.Size = new System.Drawing.Size(260, 46);
            this.Btn_Activar.TabIndex = 1;
            this.Btn_Activar.Text = "ACTIVAR";
            this.Btn_Activar.UseVisualStyleBackColor = true;
            this.Btn_Activar.Click += new System.EventHandler(this.Btn_Activar_Click);
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Volver.Location = new System.Drawing.Point(11, 396);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(260, 46);
            this.Btn_Volver.TabIndex = 1;
            this.Btn_Volver.Text = "VOLVER";
            this.Btn_Volver.UseVisualStyleBackColor = true;
            this.Btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // AdminValidarForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(283, 450);
            this.Controls.Add(this.Btn_Volver);
            this.Controls.Add(this.Btn_Activar);
            this.Controls.Add(this.Dgv_Alumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminValidarForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AdminValidarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Alumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Alumnos;
        private System.Windows.Forms.Button Btn_Activar;
        private System.Windows.Forms.Button Btn_Volver;
    }
}