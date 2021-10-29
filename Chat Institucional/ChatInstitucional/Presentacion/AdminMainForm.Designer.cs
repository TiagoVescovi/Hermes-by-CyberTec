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
            this.Btn_MateGrupOri = new System.Windows.Forms.Button();
            this.Btn_Users = new System.Windows.Forms.Button();
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
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Btn_Minimize);
            this.panel1.Controls.Add(this.Btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 29);
            this.panel1.TabIndex = 26;
            // 
            // Btn_Minimize
            // 
            this.Btn_Minimize.Font = new System.Drawing.Font("Cambria", 9F);
            this.Btn_Minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Minimize.Location = new System.Drawing.Point(900, 3);
            this.Btn_Minimize.Name = "Btn_Minimize";
            this.Btn_Minimize.Size = new System.Drawing.Size(24, 24);
            this.Btn_Minimize.TabIndex = 10;
            this.Btn_Minimize.Text = "─";
            this.Btn_Minimize.UseVisualStyleBackColor = true;
            this.Btn_Minimize.Click += new System.EventHandler(this.Btn_Minimize_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.Red;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Cambria", 9F);
            this.Btn_Close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Close.Location = new System.Drawing.Point(925, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(24, 24);
            this.Btn_Close.TabIndex = 9;
            this.Btn_Close.Text = "X";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Pnl_Izq
            // 
            this.Pnl_Izq.BackColor = System.Drawing.Color.DarkBlue;
            this.Pnl_Izq.Controls.Add(this.panel2);
            this.Pnl_Izq.Controls.Add(this.pictureBox1);
            this.Pnl_Izq.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_Izq.Location = new System.Drawing.Point(0, 29);
            this.Pnl_Izq.Name = "Pnl_Izq";
            this.Pnl_Izq.Size = new System.Drawing.Size(234, 548);
            this.Pnl_Izq.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_Alumnos);
            this.panel2.Controls.Add(this.Btn_MateGrupOri);
            this.panel2.Controls.Add(this.Btn_Users);
            this.panel2.Controls.Add(this.Btn_Settings);
            this.panel2.Controls.Add(this.Btn_Docentes);
            this.panel2.Controls.Add(this.Btn_Admins);
            this.panel2.Location = new System.Drawing.Point(0, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 326);
            this.panel2.TabIndex = 3;
            // 
            // Btn_Alumnos
            // 
            this.Btn_Alumnos.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Alumnos.FlatAppearance.BorderSize = 0;
            this.Btn_Alumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Alumnos.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.Btn_Alumnos.ForeColor = System.Drawing.Color.White;
            this.Btn_Alumnos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Alumnos.Location = new System.Drawing.Point(0, 8);
            this.Btn_Alumnos.Name = "Btn_Alumnos";
            this.Btn_Alumnos.Size = new System.Drawing.Size(234, 50);
            this.Btn_Alumnos.TabIndex = 1;
            this.Btn_Alumnos.Text = "EDITAR ALUMNOS";
            this.Btn_Alumnos.UseVisualStyleBackColor = false;
            this.Btn_Alumnos.Click += new System.EventHandler(this.Btn_Alumnos_Click);
            // 
            // Btn_Settings
            // 
            this.Btn_Settings.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Settings.FlatAppearance.BorderSize = 0;
            this.Btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Settings.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.Btn_Settings.ForeColor = System.Drawing.Color.White;
            this.Btn_Settings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Settings.Location = new System.Drawing.Point(3, 273);
            this.Btn_Settings.Name = "Btn_Settings";
            this.Btn_Settings.Size = new System.Drawing.Size(234, 50);
            this.Btn_Settings.TabIndex = 4;
            this.Btn_Settings.Text = "CONFIGURACIÓN";
            this.Btn_Settings.UseVisualStyleBackColor = false;
            this.Btn_Settings.Click += new System.EventHandler(this.Btn_Settings_Click);
            // 
            // Btn_Docentes
            // 
            this.Btn_Docentes.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Docentes.FlatAppearance.BorderSize = 0;
            this.Btn_Docentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Docentes.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.Btn_Docentes.ForeColor = System.Drawing.Color.White;
            this.Btn_Docentes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Docentes.Location = new System.Drawing.Point(0, 64);
            this.Btn_Docentes.Name = "Btn_Docentes";
            this.Btn_Docentes.Size = new System.Drawing.Size(234, 50);
            this.Btn_Docentes.TabIndex = 2;
            this.Btn_Docentes.Text = "EDITAR DOCENTES";
            this.Btn_Docentes.UseVisualStyleBackColor = false;
            this.Btn_Docentes.Click += new System.EventHandler(this.Btn_Docentes_Click);
            // 
            // Btn_Admins
            // 
            this.Btn_Admins.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Admins.FlatAppearance.BorderSize = 0;
            this.Btn_Admins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Admins.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.Btn_Admins.ForeColor = System.Drawing.Color.White;
            this.Btn_Admins.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Admins.Location = new System.Drawing.Point(0, 117);
            this.Btn_Admins.Name = "Btn_Admins";
            this.Btn_Admins.Size = new System.Drawing.Size(234, 50);
            this.Btn_Admins.TabIndex = 3;
            this.Btn_Admins.Text = "EDITAR ADMINISTRADORES";
            this.Btn_Admins.UseVisualStyleBackColor = false;
            this.Btn_Admins.Click += new System.EventHandler(this.Btn_Admins_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ChatInstitucional.Properties.Resources.HermesLogo;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "5";
            // 
            // Pnl_User
            // 
            this.Pnl_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_User.Controls.Add(this.Lbl_UserName);
            this.Pnl_User.Controls.Add(this.Lbl_FormAbierto);
            this.Pnl_User.Controls.Add(this.Lbl_UserGrupo);
            this.Pnl_User.Controls.Add(this.Pic_Perfil);
            this.Pnl_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_User.Location = new System.Drawing.Point(234, 29);
            this.Pnl_User.Name = "Pnl_User";
            this.Pnl_User.Size = new System.Drawing.Size(717, 114);
            this.Pnl_User.TabIndex = 28;
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_UserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lbl_UserName.Location = new System.Drawing.Point(0, 75);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Size = new System.Drawing.Size(715, 13);
            this.Lbl_UserName.TabIndex = 1;
            this.Lbl_UserName.Text = "Nombre de usuario";
            this.Lbl_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_FormAbierto
            // 
            this.Lbl_FormAbierto.AutoSize = true;
            this.Lbl_FormAbierto.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_FormAbierto.ForeColor = System.Drawing.Color.MediumBlue;
            this.Lbl_FormAbierto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lbl_FormAbierto.Location = new System.Drawing.Point(16, 30);
            this.Lbl_FormAbierto.Name = "Lbl_FormAbierto";
            this.Lbl_FormAbierto.Size = new System.Drawing.Size(190, 41);
            this.Lbl_FormAbierto.TabIndex = 3;
            this.Lbl_FormAbierto.Text = "PRINCIPAL";
            // 
            // Lbl_UserGrupo
            // 
            this.Lbl_UserGrupo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_UserGrupo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lbl_UserGrupo.Location = new System.Drawing.Point(0, 88);
            this.Lbl_UserGrupo.Name = "Lbl_UserGrupo";
            this.Lbl_UserGrupo.Size = new System.Drawing.Size(715, 24);
            this.Lbl_UserGrupo.TabIndex = 2;
            this.Lbl_UserGrupo.Text = ".";
            this.Lbl_UserGrupo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Pic_Perfil
            // 
            this.Pic_Perfil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Pic_Perfil.Location = new System.Drawing.Point(635, 2);
            this.Pic_Perfil.Margin = new System.Windows.Forms.Padding(0);
            this.Pic_Perfil.Name = "Pic_Perfil";
            this.Pic_Perfil.Size = new System.Drawing.Size(72, 69);
            this.Pic_Perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Perfil.TabIndex = 0;
            this.Pic_Perfil.TabStop = false;
            // 
            // Pnl_Der
            // 
            this.Pnl_Der.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Der.Location = new System.Drawing.Point(234, 149);
            this.Pnl_Der.Name = "Pnl_Der";
            this.Pnl_Der.Size = new System.Drawing.Size(717, 428);
            this.Pnl_Der.TabIndex = 29;
            // 
            // Btn_MateGrupOri
            // 
            this.Btn_MateGrupOri.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_MateGrupOri.FlatAppearance.BorderSize = 0;
            this.Btn_MateGrupOri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MateGrupOri.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.Btn_MateGrupOri.ForeColor = System.Drawing.Color.White;
            this.Btn_MateGrupOri.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_MateGrupOri.Location = new System.Drawing.Point(0, 167);
            this.Btn_MateGrupOri.Name = "Btn_MateGrupOri";
            this.Btn_MateGrupOri.Size = new System.Drawing.Size(234, 50);
            this.Btn_MateGrupOri.TabIndex = 4;
            this.Btn_MateGrupOri.Text = "EDITAR CURSOS";
            this.Btn_MateGrupOri.UseVisualStyleBackColor = false;
            this.Btn_MateGrupOri.Click += new System.EventHandler(this.Btn_MateGrupOri_Click);
            // 
            // Btn_Users
            // 
            this.Btn_Users.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Users.FlatAppearance.BorderSize = 0;
            this.Btn_Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Users.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.Btn_Users.ForeColor = System.Drawing.Color.White;
            this.Btn_Users.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Users.Location = new System.Drawing.Point(0, 220);
            this.Btn_Users.Name = "Btn_Users";
            this.Btn_Users.Size = new System.Drawing.Size(234, 50);
            this.Btn_Users.TabIndex = 4;
            this.Btn_Users.Text = "EDITAR USUARIOS";
            this.Btn_Users.UseVisualStyleBackColor = false;
            this.Btn_Users.Click += new System.EventHandler(this.Btn_Settings_Click);
            // 
            // MainFormAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.Pnl_Der);
            this.Controls.Add(this.Pnl_User);
            this.Controls.Add(this.Pnl_Izq);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hermes - Chat Institucional";
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
        private System.Windows.Forms.Button Btn_Users;
    }
}