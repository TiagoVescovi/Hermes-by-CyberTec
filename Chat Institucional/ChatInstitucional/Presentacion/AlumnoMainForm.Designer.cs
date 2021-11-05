namespace ChatInstitucional.Presentacion
{
    partial class AlumnoMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlumnoMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Minimize = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Pnl_Der = new System.Windows.Forms.Panel();
            this.Pnl_User = new System.Windows.Forms.Panel();
            this.Lbl_UserName = new System.Windows.Forms.Label();
            this.Lbl_FormAbierto = new System.Windows.Forms.Label();
            this.Lbl_UserGrupo = new System.Windows.Forms.Label();
            this.Pic_Perfil = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Cursos = new System.Windows.Forms.Button();
            this.Btn_Settings = new System.Windows.Forms.Button();
            this.Btn_Consultas = new System.Windows.Forms.Button();
            this.Btn_Chats = new System.Windows.Forms.Button();
            this.Pnl_Izq = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.Pnl_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Perfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.Pnl_Izq.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Btn_Minimize);
            this.panel1.Controls.Add(this.Btn_Close);
            resources.ApplyResources(this.panel1, "panel1");
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
            this.Btn_Close.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.Btn_Close, "Btn_Close");
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Pnl_Der
            // 
            resources.ApplyResources(this.Pnl_Der, "Pnl_Der");
            this.Pnl_Der.Name = "Pnl_Der";
            // 
            // Pnl_User
            // 
            this.Pnl_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_User.Controls.Add(this.Lbl_UserName);
            this.Pnl_User.Controls.Add(this.Lbl_FormAbierto);
            this.Pnl_User.Controls.Add(this.Lbl_UserGrupo);
            this.Pnl_User.Controls.Add(this.Pic_Perfil);
            resources.ApplyResources(this.Pnl_User, "Pnl_User");
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
            this.Pic_Perfil.Image = global::Hermes.Properties.Resources.descarga;
            resources.ApplyResources(this.Pic_Perfil, "Pic_Perfil");
            this.Pic_Perfil.Name = "Pic_Perfil";
            this.Pic_Perfil.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Hermes.Properties.Resources.HermesLogo;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "5";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_Cursos);
            this.panel2.Controls.Add(this.Btn_Settings);
            this.panel2.Controls.Add(this.Btn_Consultas);
            this.panel2.Controls.Add(this.Btn_Chats);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // Btn_Cursos
            // 
            this.Btn_Cursos.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Cursos.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Btn_Cursos, "Btn_Cursos");
            this.Btn_Cursos.ForeColor = System.Drawing.Color.White;
            this.Btn_Cursos.Name = "Btn_Cursos";
            this.Btn_Cursos.UseVisualStyleBackColor = false;
            this.Btn_Cursos.Click += new System.EventHandler(this.Btn_Cursos_Click);
            // 
            // Btn_Settings
            // 
            this.Btn_Settings.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Settings.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Btn_Settings, "Btn_Settings");
            this.Btn_Settings.ForeColor = System.Drawing.Color.White;
            this.Btn_Settings.Name = "Btn_Settings";
            this.Btn_Settings.UseVisualStyleBackColor = false;
            this.Btn_Settings.Click += new System.EventHandler(this.Btn_Settings_Click);
            // 
            // Btn_Consultas
            // 
            this.Btn_Consultas.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Consultas.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Btn_Consultas, "Btn_Consultas");
            this.Btn_Consultas.ForeColor = System.Drawing.Color.White;
            this.Btn_Consultas.Name = "Btn_Consultas";
            this.Btn_Consultas.UseVisualStyleBackColor = false;
            this.Btn_Consultas.Click += new System.EventHandler(this.Btn_Consultas_Click);
            // 
            // Btn_Chats
            // 
            this.Btn_Chats.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Chats.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Btn_Chats, "Btn_Chats");
            this.Btn_Chats.ForeColor = System.Drawing.Color.White;
            this.Btn_Chats.Name = "Btn_Chats";
            this.Btn_Chats.UseVisualStyleBackColor = false;
            this.Btn_Chats.Click += new System.EventHandler(this.Btn_Chats_Click);
            // 
            // Pnl_Izq
            // 
            this.Pnl_Izq.BackColor = System.Drawing.Color.DarkBlue;
            this.Pnl_Izq.Controls.Add(this.panel2);
            this.Pnl_Izq.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.Pnl_Izq, "Pnl_Izq");
            this.Pnl_Izq.Name = "Pnl_Izq";
            // 
            // AlumnoMainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Pnl_User);
            this.Controls.Add(this.Pnl_Der);
            this.Controls.Add(this.Pnl_Izq);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlumnoMainForm";
            this.Load += new System.EventHandler(this.MainFormAlumno_Load);
            this.panel1.ResumeLayout(false);
            this.Pnl_User.ResumeLayout(false);
            this.Pnl_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Perfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.Pnl_Izq.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Minimize;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Panel Pnl_Der;
        private System.Windows.Forms.Panel Pnl_User;
        private System.Windows.Forms.PictureBox Pic_Perfil;
        private System.Windows.Forms.Label Lbl_UserName;
        private System.Windows.Forms.Label Lbl_UserGrupo;
        private System.Windows.Forms.Label Lbl_FormAbierto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Cursos;
        private System.Windows.Forms.Button Btn_Settings;
        private System.Windows.Forms.Button Btn_Consultas;
        private System.Windows.Forms.Button Btn_Chats;
        private System.Windows.Forms.Panel Pnl_Izq;
    }
}