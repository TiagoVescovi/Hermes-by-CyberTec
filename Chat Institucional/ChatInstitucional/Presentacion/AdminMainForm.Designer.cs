namespace ChatInstitucional.Presentacion
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Minimize = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Pnl_Izq = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Alumnos = new System.Windows.Forms.Button();
            this.Btn_MateGrupOri = new System.Windows.Forms.Button();
            this.Btn_Settings = new System.Windows.Forms.Button();
            this.Btn_Docentes = new System.Windows.Forms.Button();
            this.Btn_Admins = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pnl_User = new System.Windows.Forms.Panel();
            this.Lbl_UserName = new System.Windows.Forms.Label();
            this.Lbl_FormAbierto = new System.Windows.Forms.Label();
            this.Lbl_UserGrupo = new System.Windows.Forms.Label();
            this.Pic_Perfil = new System.Windows.Forms.PictureBox();
            this.Pnl_Der = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.Pnl_Izq.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pnl_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Perfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Btn_Minimize);
            this.panel1.Controls.Add(this.Btn_Close);
            this.panel1.Name = "panel1";
            // 
            // Btn_Minimize
            // 
            resources.ApplyResources(this.Btn_Minimize, "Btn_Minimize");
            this.Btn_Minimize.Name = "Btn_Minimize";
            this.Btn_Minimize.UseVisualStyleBackColor = true;
            this.Btn_Minimize.Click += new System.EventHandler(this.Btn_Minimize_Click);
            // 
            // Btn_Close
            // 
            resources.ApplyResources(this.Btn_Close, "Btn_Close");
            this.Btn_Close.BackColor = System.Drawing.Color.Red;
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Pnl_Izq
            // 
            resources.ApplyResources(this.Pnl_Izq, "Pnl_Izq");
            this.Pnl_Izq.BackColor = System.Drawing.Color.DarkBlue;
            this.Pnl_Izq.Controls.Add(this.panel2);
            this.Pnl_Izq.Controls.Add(this.pictureBox1);
            this.Pnl_Izq.Name = "Pnl_Izq";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.Btn_Alumnos);
            this.panel2.Controls.Add(this.Btn_MateGrupOri);
            this.panel2.Controls.Add(this.Btn_Settings);
            this.panel2.Controls.Add(this.Btn_Docentes);
            this.panel2.Controls.Add(this.Btn_Admins);
            this.panel2.Name = "panel2";
            // 
            // Btn_Alumnos
            // 
            resources.ApplyResources(this.Btn_Alumnos, "Btn_Alumnos");
            this.Btn_Alumnos.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Alumnos.FlatAppearance.BorderSize = 0;
            this.Btn_Alumnos.ForeColor = System.Drawing.Color.White;
            this.Btn_Alumnos.Name = "Btn_Alumnos";
            this.Btn_Alumnos.UseVisualStyleBackColor = false;
            this.Btn_Alumnos.Click += new System.EventHandler(this.Btn_Alumnos_Click);
            // 
            // Btn_MateGrupOri
            // 
            resources.ApplyResources(this.Btn_MateGrupOri, "Btn_MateGrupOri");
            this.Btn_MateGrupOri.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_MateGrupOri.FlatAppearance.BorderSize = 0;
            this.Btn_MateGrupOri.ForeColor = System.Drawing.Color.White;
            this.Btn_MateGrupOri.Name = "Btn_MateGrupOri";
            this.Btn_MateGrupOri.UseVisualStyleBackColor = false;
            this.Btn_MateGrupOri.Click += new System.EventHandler(this.Btn_MateGrupOri_Click);
            // 
            // Btn_Settings
            // 
            resources.ApplyResources(this.Btn_Settings, "Btn_Settings");
            this.Btn_Settings.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Settings.FlatAppearance.BorderSize = 0;
            this.Btn_Settings.ForeColor = System.Drawing.Color.White;
            this.Btn_Settings.Name = "Btn_Settings";
            this.Btn_Settings.UseVisualStyleBackColor = false;
            this.Btn_Settings.Click += new System.EventHandler(this.Btn_Settings_Click);
            // 
            // Btn_Docentes
            // 
            resources.ApplyResources(this.Btn_Docentes, "Btn_Docentes");
            this.Btn_Docentes.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Docentes.FlatAppearance.BorderSize = 0;
            this.Btn_Docentes.ForeColor = System.Drawing.Color.White;
            this.Btn_Docentes.Name = "Btn_Docentes";
            this.Btn_Docentes.UseVisualStyleBackColor = false;
            this.Btn_Docentes.Click += new System.EventHandler(this.Btn_Docentes_Click);
            // 
            // Btn_Admins
            // 
            resources.ApplyResources(this.Btn_Admins, "Btn_Admins");
            this.Btn_Admins.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Admins.FlatAppearance.BorderSize = 0;
            this.Btn_Admins.ForeColor = System.Drawing.Color.White;
            this.Btn_Admins.Name = "Btn_Admins";
            this.Btn_Admins.UseVisualStyleBackColor = false;
            this.Btn_Admins.Click += new System.EventHandler(this.Btn_Admins_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ChatInstitucional.Properties.Resources.HermesLogo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "5";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Pnl_User
            // 
            resources.ApplyResources(this.Pnl_User, "Pnl_User");
            this.Pnl_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_User.Controls.Add(this.Lbl_UserName);
            this.Pnl_User.Controls.Add(this.Lbl_FormAbierto);
            this.Pnl_User.Controls.Add(this.Lbl_UserGrupo);
            this.Pnl_User.Controls.Add(this.Pic_Perfil);
            this.Pnl_User.Name = "Pnl_User";
            // 
            // Lbl_UserName
            // 
            resources.ApplyResources(this.Lbl_UserName, "Lbl_UserName");
            this.Lbl_UserName.Name = "Lbl_UserName";
            // 
            // Lbl_FormAbierto
            // 
            resources.ApplyResources(this.Lbl_FormAbierto, "Lbl_FormAbierto");
            this.Lbl_FormAbierto.ForeColor = System.Drawing.Color.MediumBlue;
            this.Lbl_FormAbierto.Name = "Lbl_FormAbierto";
            // 
            // Lbl_UserGrupo
            // 
            resources.ApplyResources(this.Lbl_UserGrupo, "Lbl_UserGrupo");
            this.Lbl_UserGrupo.Name = "Lbl_UserGrupo";
            // 
            // Pic_Perfil
            // 
            resources.ApplyResources(this.Pic_Perfil, "Pic_Perfil");
            this.Pic_Perfil.Name = "Pic_Perfil";
            this.Pic_Perfil.TabStop = false;
            // 
            // Pnl_Der
            // 
            resources.ApplyResources(this.Pnl_Der, "Pnl_Der");
            this.Pnl_Der.Name = "Pnl_Der";
            // 
            // AdminMainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Pnl_Der);
            this.Controls.Add(this.Pnl_User);
            this.Controls.Add(this.Pnl_Izq);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMainForm";
            this.Load += new System.EventHandler(this.MainFormAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.Pnl_Izq.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pnl_User.ResumeLayout(false);
            this.Pnl_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Perfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Minimize;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Panel Pnl_Izq;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Alumnos;
        private System.Windows.Forms.Button Btn_Settings;
        private System.Windows.Forms.Button Btn_Docentes;
        private System.Windows.Forms.Button Btn_Admins;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Pnl_User;
        private System.Windows.Forms.Label Lbl_UserName;
        private System.Windows.Forms.Label Lbl_FormAbierto;
        private System.Windows.Forms.Label Lbl_UserGrupo;
        private System.Windows.Forms.PictureBox Pic_Perfil;
        private System.Windows.Forms.Panel Pnl_Der;
        private System.Windows.Forms.Button Btn_MateGrupOri;
    }
}