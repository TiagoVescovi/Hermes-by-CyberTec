namespace ChatInstitucional.Presentacion
{
    partial class AdminCursosAMForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCursosAMForm));
            this.Text_Grado = new System.Windows.Forms.TextBox();
            this.Text_Dist = new System.Windows.Forms.TextBox();
            this.Text_Nombre = new System.Windows.Forms.TextBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Combo_Ori = new System.Windows.Forms.ComboBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Text_Ano = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Text_Grado
            // 
            this.Text_Grado.Location = new System.Drawing.Point(113, 36);
            this.Text_Grado.MaxLength = 3;
            this.Text_Grado.Name = "Text_Grado";
            this.Text_Grado.Size = new System.Drawing.Size(62, 29);
            this.Text_Grado.TabIndex = 0;
            this.Text_Grado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_Grado_KeyPress);
            // 
            // Text_Dist
            // 
            this.Text_Dist.Location = new System.Drawing.Point(113, 76);
            this.Text_Dist.MaxLength = 7;
            this.Text_Dist.Name = "Text_Dist";
            this.Text_Dist.Size = new System.Drawing.Size(62, 29);
            this.Text_Dist.TabIndex = 1;
            // 
            // Text_Nombre
            // 
            this.Text_Nombre.Location = new System.Drawing.Point(113, 150);
            this.Text_Nombre.MaxLength = 30;
            this.Text_Nombre.Name = "Text_Nombre";
            this.Text_Nombre.Size = new System.Drawing.Size(163, 29);
            this.Text_Nombre.TabIndex = 2;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(311, 21);
            this.Lbl_Titulo.TabIndex = 3;
            this.Lbl_Titulo.Text = "CREAR ALGO";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "GRADO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "DISTINTIVO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "NOMBRE:";
            // 
            // Combo_Ori
            // 
            this.Combo_Ori.BackColor = System.Drawing.Color.Gainsboro;
            this.Combo_Ori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Ori.FormattingEnabled = true;
            this.Combo_Ori.Location = new System.Drawing.Point(33, 185);
            this.Combo_Ori.Name = "Combo_Ori";
            this.Combo_Ori.Size = new System.Drawing.Size(243, 29);
            this.Combo_Ori.TabIndex = 7;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(78, 233);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(154, 31);
            this.Btn_Add.TabIndex = 8;
            this.Btn_Add.Text = "AGREGAR";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "AÑO:";
            // 
            // Text_Ano
            // 
            this.Text_Ano.Location = new System.Drawing.Point(113, 115);
            this.Text_Ano.MaxLength = 4;
            this.Text_Ano.Name = "Text_Ano";
            this.Text_Ano.Size = new System.Drawing.Size(62, 29);
            this.Text_Ano.TabIndex = 9;
            this.Text_Ano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_Ano_KeyPress);
            // 
            // AdminCursosAMForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(311, 276);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Text_Ano);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Combo_Ori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Text_Nombre);
            this.Controls.Add(this.Text_Dist);
            this.Controls.Add(this.Text_Grado);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminCursosAMForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AdminCursosAMForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_Grado;
        private System.Windows.Forms.TextBox Text_Dist;
        private System.Windows.Forms.TextBox Text_Nombre;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Combo_Ori;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Text_Ano;
    }
}