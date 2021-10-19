namespace ChatInstitucional.Presentacion
{
    partial class MainFormAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormAlumno));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Minimize = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Pnl_Izq = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Cursos = new System.Windows.Forms.Button();
            this.Btn_Settings = new System.Windows.Forms.Button();
            this.Btn_Consultas = new System.Windows.Forms.Button();
            this.Btn_Chats = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pnl_Der = new System.Windows.Forms.Panel();
            this.Pnl_User = new System.Windows.Forms.Panel();
            this.Lbl_FormAbierto = new System.Windows.Forms.Label();
            this.Lbl_UserGrupo = new System.Windows.Forms.Label();
            this.Lbl_UserName = new System.Windows.Forms.Label();
            this.Pic_Perfil = new System.Windows.Forms.PictureBox();
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
            this.panel1.TabIndex = 25;
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
            this.Pnl_Izq.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_Cursos);
            this.panel2.Controls.Add(this.Btn_Settings);
            this.panel2.Controls.Add(this.Btn_Consultas);
            this.panel2.Controls.Add(this.Btn_Chats);
            this.panel2.Location = new System.Drawing.Point(0, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 326);
            this.panel2.TabIndex = 3;
            // 
            // Btn_Cursos
            // 
            this.Btn_Cursos.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Cursos.FlatAppearance.BorderSize = 0;
            this.Btn_Cursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cursos.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cursos.ForeColor = System.Drawing.Color.White;
            this.Btn_Cursos.Location = new System.Drawing.Point(0, 8);
            this.Btn_Cursos.Name = "Btn_Cursos";
            this.Btn_Cursos.Size = new System.Drawing.Size(234, 72);
            this.Btn_Cursos.TabIndex = 1;
            this.Btn_Cursos.Text = "MIS CURSOS";
            this.Btn_Cursos.UseVisualStyleBackColor = false;
            this.Btn_Cursos.Click += new System.EventHandler(this.Btn_Cursos_Click);
            // 
            // Btn_Settings
            // 
            this.Btn_Settings.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Settings.FlatAppearance.BorderSize = 0;
            this.Btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Settings.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Settings.ForeColor = System.Drawing.Color.White;
            this.Btn_Settings.Location = new System.Drawing.Point(0, 242);
            this.Btn_Settings.Name = "Btn_Settings";
            this.Btn_Settings.Size = new System.Drawing.Size(234, 72);
            this.Btn_Settings.TabIndex = 4;
            this.Btn_Settings.Text = "CONFIGURACIÓN";
            this.Btn_Settings.UseVisualStyleBackColor = false;
            this.Btn_Settings.Click += new System.EventHandler(this.Btn_Settings_Click);
            // 
            // Btn_Consultas
            // 
            this.Btn_Consultas.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Consultas.FlatAppearance.BorderSize = 0;
            this.Btn_Consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Consultas.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consultas.ForeColor = System.Drawing.Color.White;
            this.Btn_Consultas.Location = new System.Drawing.Point(0, 86);
            this.Btn_Consultas.Name = "Btn_Consultas";
            this.Btn_Consultas.Size = new System.Drawing.Size(234, 72);
            this.Btn_Consultas.TabIndex = 2;
            this.Btn_Consultas.Text = "CONSULTAS";
            this.Btn_Consultas.UseVisualStyleBackColor = false;
            this.Btn_Consultas.Click += new System.EventHandler(this.Btn_Consultas_Click);
            // 
            // Btn_Chats
            // 
            this.Btn_Chats.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Chats.FlatAppearance.BorderSize = 0;
            this.Btn_Chats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Chats.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Chats.ForeColor = System.Drawing.Color.White;
            this.Btn_Chats.Location = new System.Drawing.Point(0, 164);
            this.Btn_Chats.Name = "Btn_Chats";
            this.Btn_Chats.Size = new System.Drawing.Size(234, 72);
            this.Btn_Chats.TabIndex = 3;
            this.Btn_Chats.Text = "MIS CHATS";
            this.Btn_Chats.UseVisualStyleBackColor = false;
            this.Btn_Chats.Click += new System.EventHandler(this.Btn_Chats_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "5";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Pnl_Der
            // 
            this.Pnl_Der.Location = new System.Drawing.Point(234, 149);
            this.Pnl_Der.Name = "Pnl_Der";
            this.Pnl_Der.Size = new System.Drawing.Size(717, 427);
            this.Pnl_Der.TabIndex = 27;
            // 
            // Pnl_User
            // 
            this.Pnl_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_User.Controls.Add(this.Lbl_FormAbierto);
            this.Pnl_User.Controls.Add(this.Lbl_UserGrupo);
            this.Pnl_User.Controls.Add(this.Lbl_UserName);
            this.Pnl_User.Controls.Add(this.Pic_Perfil);
            this.Pnl_User.Location = new System.Drawing.Point(234, 29);
            this.Pnl_User.Name = "Pnl_User";
            this.Pnl_User.Size = new System.Drawing.Size(717, 114);
            this.Pnl_User.TabIndex = 3;
            // 
            // Lbl_FormAbierto
            // 
            this.Lbl_FormAbierto.AutoSize = true;
            this.Lbl_FormAbierto.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FormAbierto.ForeColor = System.Drawing.Color.MediumBlue;
            this.Lbl_FormAbierto.Location = new System.Drawing.Point(16, 30);
            this.Lbl_FormAbierto.Name = "Lbl_FormAbierto";
            this.Lbl_FormAbierto.Size = new System.Drawing.Size(190, 41);
            this.Lbl_FormAbierto.TabIndex = 3;
            this.Lbl_FormAbierto.Text = "PRINCIPAL";
            // 
            // Lbl_UserGrupo
            // 
            this.Lbl_UserGrupo.AutoSize = true;
            this.Lbl_UserGrupo.Location = new System.Drawing.Point(635, 94);
            this.Lbl_UserGrupo.Name = "Lbl_UserGrupo";
            this.Lbl_UserGrupo.Size = new System.Drawing.Size(36, 13);
            this.Lbl_UserGrupo.TabIndex = 2;
            this.Lbl_UserGrupo.Text = "Grupo";
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.AutoSize = true;
            this.Lbl_UserName.Location = new System.Drawing.Point(605, 75);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Size = new System.Drawing.Size(96, 13);
            this.Lbl_UserName.TabIndex = 1;
            this.Lbl_UserName.Text = "Nombre de usuario";
            // 
            // Pic_Perfil
            // 
            this.Pic_Perfil.Location = new System.Drawing.Point(617, 2);
            this.Pic_Perfil.Margin = new System.Windows.Forms.Padding(0);
            this.Pic_Perfil.Name = "Pic_Perfil";
            this.Pic_Perfil.Size = new System.Drawing.Size(72, 69);
            this.Pic_Perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Perfil.TabIndex = 0;
            this.Pic_Perfil.TabStop = false;
            // 
            // MainFormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.Pnl_User);
            this.Controls.Add(this.Pnl_Der);
            this.Controls.Add(this.Pnl_Izq);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainFormAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hermes - Chat Institucional";
            this.Load += new System.EventHandler(this.MainFormAlumno_Load);
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
        private System.Windows.Forms.Panel Pnl_Der;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Cursos;
        private System.Windows.Forms.Button Btn_Settings;
        private System.Windows.Forms.Button Btn_Chats;
        private System.Windows.Forms.Button Btn_Consultas;
        private System.Windows.Forms.Panel Pnl_User;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Pic_Perfil;
        private System.Windows.Forms.Label Lbl_UserName;
        private System.Windows.Forms.Label Lbl_UserGrupo;
        private System.Windows.Forms.Label Lbl_FormAbierto;
    }
}