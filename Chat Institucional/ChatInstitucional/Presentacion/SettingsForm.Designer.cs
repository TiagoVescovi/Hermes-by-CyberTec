namespace ChatInstitucional.Presentacion
{
    partial class SettingsForm
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
            this.Picture_ImgPerfil = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Text_Nick = new System.Windows.Forms.TextBox();
            this.Btn_ChangeNick = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_BajaUser = new System.Windows.Forms.Button();
            this.Combo_Tema = new System.Windows.Forms.ComboBox();
            this.Combo_Idioma = new System.Windows.Forms.ComboBox();
            this.Btn_ChangeFoto = new System.Windows.Forms.Button();
            this.Btn_SubirFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Btn_ChangeLang = new System.Windows.Forms.Button();
            this.Btn_ChangeTheme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ImgPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture_ImgPerfil
            // 
            this.Picture_ImgPerfil.Image = global::ChatInstitucional.Properties.Resources.descarga;
            this.Picture_ImgPerfil.Location = new System.Drawing.Point(536, 68);
            this.Picture_ImgPerfil.Name = "Picture_ImgPerfil";
            this.Picture_ImgPerfil.Size = new System.Drawing.Size(150, 150);
            this.Picture_ImgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_ImgPerfil.TabIndex = 0;
            this.Picture_ImgPerfil.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cambiar foto de perfil";
            // 
            // Text_Nick
            // 
            this.Text_Nick.Location = new System.Drawing.Point(36, 45);
            this.Text_Nick.Name = "Text_Nick";
            this.Text_Nick.Size = new System.Drawing.Size(204, 20);
            this.Text_Nick.TabIndex = 2;
            this.Text_Nick.Text = "Cambiar nickname";
            // 
            // Btn_ChangeNick
            // 
            this.Btn_ChangeNick.Location = new System.Drawing.Point(259, 45);
            this.Btn_ChangeNick.Name = "Btn_ChangeNick";
            this.Btn_ChangeNick.Size = new System.Drawing.Size(75, 23);
            this.Btn_ChangeNick.TabIndex = 3;
            this.Btn_ChangeNick.Text = "CAMBIAR";
            this.Btn_ChangeNick.UseVisualStyleBackColor = true;
            this.Btn_ChangeNick.Click += new System.EventHandler(this.Btn_ChangeNick_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Idioma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tema";
            // 
            // Btn_BajaUser
            // 
            this.Btn_BajaUser.Location = new System.Drawing.Point(539, 392);
            this.Btn_BajaUser.Name = "Btn_BajaUser";
            this.Btn_BajaUser.Size = new System.Drawing.Size(125, 23);
            this.Btn_BajaUser.TabIndex = 6;
            this.Btn_BajaUser.Text = "ELIMINAR USUARIO";
            this.Btn_BajaUser.UseVisualStyleBackColor = true;
            this.Btn_BajaUser.Click += new System.EventHandler(this.Btn_BajaUser_Click);
            // 
            // Combo_Tema
            // 
            this.Combo_Tema.FormattingEnabled = true;
            this.Combo_Tema.Location = new System.Drawing.Point(39, 233);
            this.Combo_Tema.Name = "Combo_Tema";
            this.Combo_Tema.Size = new System.Drawing.Size(145, 21);
            this.Combo_Tema.TabIndex = 7;
            // 
            // Combo_Idioma
            // 
            this.Combo_Idioma.FormattingEnabled = true;
            this.Combo_Idioma.Items.AddRange(new object[] {
            "English",
            "Español"});
            this.Combo_Idioma.Location = new System.Drawing.Point(39, 154);
            this.Combo_Idioma.Name = "Combo_Idioma";
            this.Combo_Idioma.Size = new System.Drawing.Size(142, 21);
            this.Combo_Idioma.TabIndex = 8;
            // 
            // Btn_ChangeFoto
            // 
            this.Btn_ChangeFoto.Location = new System.Drawing.Point(536, 253);
            this.Btn_ChangeFoto.Name = "Btn_ChangeFoto";
            this.Btn_ChangeFoto.Size = new System.Drawing.Size(150, 23);
            this.Btn_ChangeFoto.TabIndex = 9;
            this.Btn_ChangeFoto.Text = "APLICAR";
            this.Btn_ChangeFoto.UseVisualStyleBackColor = true;
            this.Btn_ChangeFoto.Click += new System.EventHandler(this.Btn_ChangeFoto_Click);
            // 
            // Btn_SubirFoto
            // 
            this.Btn_SubirFoto.Location = new System.Drawing.Point(536, 224);
            this.Btn_SubirFoto.Name = "Btn_SubirFoto";
            this.Btn_SubirFoto.Size = new System.Drawing.Size(150, 23);
            this.Btn_SubirFoto.TabIndex = 10;
            this.Btn_SubirFoto.Text = "SUBIR";
            this.Btn_SubirFoto.UseVisualStyleBackColor = true;
            this.Btn_SubirFoto.Click += new System.EventHandler(this.Btn_SubirFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "ofdImagen";
            // 
            // Btn_ChangeLang
            // 
            this.Btn_ChangeLang.Location = new System.Drawing.Point(198, 152);
            this.Btn_ChangeLang.Name = "Btn_ChangeLang";
            this.Btn_ChangeLang.Size = new System.Drawing.Size(75, 23);
            this.Btn_ChangeLang.TabIndex = 11;
            this.Btn_ChangeLang.Text = "CAMBIAR";
            this.Btn_ChangeLang.UseVisualStyleBackColor = true;
            this.Btn_ChangeLang.Click += new System.EventHandler(this.Btn_ChangeLang_Click);
            // 
            // Btn_ChangeTheme
            // 
            this.Btn_ChangeTheme.Location = new System.Drawing.Point(198, 231);
            this.Btn_ChangeTheme.Name = "Btn_ChangeTheme";
            this.Btn_ChangeTheme.Size = new System.Drawing.Size(75, 23);
            this.Btn_ChangeTheme.TabIndex = 12;
            this.Btn_ChangeTheme.Text = "CAMBIAR";
            this.Btn_ChangeTheme.UseVisualStyleBackColor = true;
            this.Btn_ChangeTheme.Click += new System.EventHandler(this.Btn_ChangeTheme_Click);
            // 
            // SettingsFormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 427);
            this.Controls.Add(this.Btn_ChangeTheme);
            this.Controls.Add(this.Btn_ChangeLang);
            this.Controls.Add(this.Btn_SubirFoto);
            this.Controls.Add(this.Btn_ChangeFoto);
            this.Controls.Add(this.Combo_Idioma);
            this.Controls.Add(this.Combo_Tema);
            this.Controls.Add(this.Btn_BajaUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_ChangeNick);
            this.Controls.Add(this.Text_Nick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Picture_ImgPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsFormAlumno";
            this.Text = "ModifyForm";
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ImgPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture_ImgPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_Nick;
        private System.Windows.Forms.Button Btn_ChangeNick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_BajaUser;
        private System.Windows.Forms.ComboBox Combo_Tema;
        private System.Windows.Forms.ComboBox Combo_Idioma;
        private System.Windows.Forms.Button Btn_ChangeFoto;
        private System.Windows.Forms.Button Btn_SubirFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Btn_ChangeLang;
        private System.Windows.Forms.Button Btn_ChangeTheme;
    }
}