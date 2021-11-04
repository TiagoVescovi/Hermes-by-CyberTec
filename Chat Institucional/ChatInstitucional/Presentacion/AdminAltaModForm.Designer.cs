namespace ChatInstitucional.Presentacion
{
    partial class AdminAltaModForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAltaModForm));
            this.Text_PassCheck = new System.Windows.Forms.TextBox();
            this.Text_Pass = new System.Windows.Forms.TextBox();
            this.Text_Nombre = new System.Windows.Forms.TextBox();
            this.Text_Nick = new System.Windows.Forms.TextBox();
            this.Text_Cedula = new System.Windows.Forms.TextBox();
            this.Text_Apellido = new System.Windows.Forms.TextBox();
            this.Btn_ImgDefault = new System.Windows.Forms.Button();
            this.Btn_Accept = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Combo_Grupos = new System.Windows.Forms.ComboBox();
            this.Combo_Nuevo_Existenete = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Text_PassCheck
            // 
            this.Text_PassCheck.BackColor = System.Drawing.Color.White;
            this.Text_PassCheck.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Text_PassCheck.ForeColor = System.Drawing.Color.Gray;
            this.Text_PassCheck.Location = new System.Drawing.Point(12, 322);
            this.Text_PassCheck.MaxLength = 20;
            this.Text_PassCheck.Name = "Text_PassCheck";
            this.Text_PassCheck.Size = new System.Drawing.Size(234, 31);
            this.Text_PassCheck.TabIndex = 53;
            this.Text_PassCheck.Text = "Confirmar Contraseña";
            this.Text_PassCheck.UseSystemPasswordChar = true;
            // 
            // Text_Pass
            // 
            this.Text_Pass.BackColor = System.Drawing.Color.White;
            this.Text_Pass.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Text_Pass.ForeColor = System.Drawing.Color.Gray;
            this.Text_Pass.Location = new System.Drawing.Point(12, 275);
            this.Text_Pass.MaxLength = 20;
            this.Text_Pass.Name = "Text_Pass";
            this.Text_Pass.Size = new System.Drawing.Size(234, 31);
            this.Text_Pass.TabIndex = 52;
            this.Text_Pass.Text = "Contraseña";
            this.Text_Pass.UseSystemPasswordChar = true;
            // 
            // Text_Nombre
            // 
            this.Text_Nombre.BackColor = System.Drawing.Color.White;
            this.Text_Nombre.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Text_Nombre.ForeColor = System.Drawing.Color.Gray;
            this.Text_Nombre.Location = new System.Drawing.Point(12, 134);
            this.Text_Nombre.MaxLength = 30;
            this.Text_Nombre.Name = "Text_Nombre";
            this.Text_Nombre.Size = new System.Drawing.Size(234, 31);
            this.Text_Nombre.TabIndex = 49;
            this.Text_Nombre.Text = "Nombre";
            // 
            // Text_Nick
            // 
            this.Text_Nick.BackColor = System.Drawing.Color.White;
            this.Text_Nick.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Text_Nick.ForeColor = System.Drawing.Color.Gray;
            this.Text_Nick.Location = new System.Drawing.Point(12, 228);
            this.Text_Nick.MaxLength = 9;
            this.Text_Nick.Name = "Text_Nick";
            this.Text_Nick.Size = new System.Drawing.Size(234, 31);
            this.Text_Nick.TabIndex = 51;
            this.Text_Nick.Text = "Nickname";
            // 
            // Text_Cedula
            // 
            this.Text_Cedula.BackColor = System.Drawing.Color.White;
            this.Text_Cedula.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Text_Cedula.ForeColor = System.Drawing.Color.Gray;
            this.Text_Cedula.Location = new System.Drawing.Point(12, 87);
            this.Text_Cedula.MaxLength = 9;
            this.Text_Cedula.Name = "Text_Cedula";
            this.Text_Cedula.Size = new System.Drawing.Size(234, 31);
            this.Text_Cedula.TabIndex = 48;
            this.Text_Cedula.Text = "Cedula";
            // 
            // Text_Apellido
            // 
            this.Text_Apellido.BackColor = System.Drawing.Color.White;
            this.Text_Apellido.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Text_Apellido.ForeColor = System.Drawing.Color.Gray;
            this.Text_Apellido.Location = new System.Drawing.Point(12, 181);
            this.Text_Apellido.MaxLength = 30;
            this.Text_Apellido.Name = "Text_Apellido";
            this.Text_Apellido.Size = new System.Drawing.Size(234, 31);
            this.Text_Apellido.TabIndex = 50;
            this.Text_Apellido.Text = "Apellido";
            // 
            // Btn_ImgDefault
            // 
            this.Btn_ImgDefault.Location = new System.Drawing.Point(272, 87);
            this.Btn_ImgDefault.Name = "Btn_ImgDefault";
            this.Btn_ImgDefault.Size = new System.Drawing.Size(197, 54);
            this.Btn_ImgDefault.TabIndex = 54;
            this.Btn_ImgDefault.Text = "PONER IMÁGEN POR DEFECTO";
            this.Btn_ImgDefault.UseVisualStyleBackColor = true;
            this.Btn_ImgDefault.Click += new System.EventHandler(this.Btn_ImgDefault_Click);
            // 
            // Btn_Accept
            // 
            this.Btn_Accept.Location = new System.Drawing.Point(272, 218);
            this.Btn_Accept.Name = "Btn_Accept";
            this.Btn_Accept.Size = new System.Drawing.Size(197, 54);
            this.Btn_Accept.TabIndex = 55;
            this.Btn_Accept.Text = "ACEPTAR";
            this.Btn_Accept.UseVisualStyleBackColor = true;
            this.Btn_Accept.Click += new System.EventHandler(this.Btn_Accept_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(272, 349);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(197, 54);
            this.Btn_Cancel.TabIndex = 56;
            this.Btn_Cancel.Text = "CANCELAR";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Combo_Grupos
            // 
            this.Combo_Grupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Grupos.Enabled = false;
            this.Combo_Grupos.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Grupos.ForeColor = System.Drawing.Color.Gray;
            this.Combo_Grupos.FormattingEnabled = true;
            this.Combo_Grupos.Location = new System.Drawing.Point(12, 369);
            this.Combo_Grupos.Name = "Combo_Grupos";
            this.Combo_Grupos.Size = new System.Drawing.Size(234, 31);
            this.Combo_Grupos.TabIndex = 57;
            // 
            // Combo_Nuevo_Existenete
            // 
            this.Combo_Nuevo_Existenete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Nuevo_Existenete.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Nuevo_Existenete.ForeColor = System.Drawing.Color.Gray;
            this.Combo_Nuevo_Existenete.FormattingEnabled = true;
            this.Combo_Nuevo_Existenete.Items.AddRange(new object[] {
            "Nueva",
            "Existente"});
            this.Combo_Nuevo_Existenete.Location = new System.Drawing.Point(166, 26);
            this.Combo_Nuevo_Existenete.Name = "Combo_Nuevo_Existenete";
            this.Combo_Nuevo_Existenete.Size = new System.Drawing.Size(228, 31);
            this.Combo_Nuevo_Existenete.TabIndex = 58;
            this.Combo_Nuevo_Existenete.SelectedIndexChanged += new System.EventHandler(this.Combo_Nuevo_Existenete_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Estado:";
            // 
            // AdminAltaModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Combo_Nuevo_Existenete);
            this.Controls.Add(this.Combo_Grupos);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Accept);
            this.Controls.Add(this.Btn_ImgDefault);
            this.Controls.Add(this.Text_PassCheck);
            this.Controls.Add(this.Text_Pass);
            this.Controls.Add(this.Text_Nombre);
            this.Controls.Add(this.Text_Nick);
            this.Controls.Add(this.Text_Cedula);
            this.Controls.Add(this.Text_Apellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminAltaModForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AdminAltas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_PassCheck;
        private System.Windows.Forms.TextBox Text_Pass;
        private System.Windows.Forms.TextBox Text_Nombre;
        private System.Windows.Forms.TextBox Text_Nick;
        private System.Windows.Forms.TextBox Text_Cedula;
        private System.Windows.Forms.TextBox Text_Apellido;
        private System.Windows.Forms.Button Btn_ImgDefault;
        private System.Windows.Forms.Button Btn_Accept;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.ComboBox Combo_Grupos;
        private System.Windows.Forms.ComboBox Combo_Nuevo_Existenete;
        private System.Windows.Forms.Label label1;
    }
}