namespace ChatInstitucional.Presentacion
{
    partial class ConsultaFormAlumno
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
            this.label2 = new System.Windows.Forms.Label();
            this.Combo_Materia = new System.Windows.Forms.ComboBox();
            this.Text_Consulta = new System.Windows.Forms.TextBox();
            this.Btn_Enviar = new System.Windows.Forms.Button();
            this.Dgv_Realizada = new System.Windows.Forms.DataGridView();
            this.Dgv_Contestada = new System.Windows.Forms.DataGridView();
            this.Dgv_Recibida = new System.Windows.Forms.DataGridView();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Realizada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Contestada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Recibida)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(52, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado de las consultas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(22, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Materia";
            // 
            // Combo_Materia
            // 
            this.Combo_Materia.BackColor = System.Drawing.Color.Blue;
            this.Combo_Materia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Combo_Materia.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Materia.ForeColor = System.Drawing.Color.White;
            this.Combo_Materia.FormattingEnabled = true;
            this.Combo_Materia.Location = new System.Drawing.Point(120, 33);
            this.Combo_Materia.Name = "Combo_Materia";
            this.Combo_Materia.Size = new System.Drawing.Size(288, 27);
            this.Combo_Materia.TabIndex = 1;
            // 
            // Text_Consulta
            // 
            this.Text_Consulta.Location = new System.Drawing.Point(414, 12);
            this.Text_Consulta.Multiline = true;
            this.Text_Consulta.Name = "Text_Consulta";
            this.Text_Consulta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Text_Consulta.Size = new System.Drawing.Size(291, 93);
            this.Text_Consulta.TabIndex = 2;
            this.Text_Consulta.Text = "Redacta la consulta aquí";
            // 
            // Btn_Enviar
            // 
            this.Btn_Enviar.BackColor = System.Drawing.Color.MediumBlue;
            this.Btn_Enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Enviar.FlatAppearance.BorderSize = 0;
            this.Btn_Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Enviar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enviar.ForeColor = System.Drawing.Color.White;
            this.Btn_Enviar.Location = new System.Drawing.Point(514, 111);
            this.Btn_Enviar.Name = "Btn_Enviar";
            this.Btn_Enviar.Size = new System.Drawing.Size(125, 27);
            this.Btn_Enviar.TabIndex = 3;
            this.Btn_Enviar.Text = "ENVIAR";
            this.Btn_Enviar.UseVisualStyleBackColor = false;
            this.Btn_Enviar.Click += new System.EventHandler(this.Btn_Enviar_Click);
            // 
            // Dgv_Realizada
            // 
            this.Dgv_Realizada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dgv_Realizada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.Dgv_Realizada.BackgroundColor = System.Drawing.Color.Red;
            this.Dgv_Realizada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Realizada.GridColor = System.Drawing.Color.White;
            this.Dgv_Realizada.Location = new System.Drawing.Point(12, 174);
            this.Dgv_Realizada.Name = "Dgv_Realizada";
            this.Dgv_Realizada.ReadOnly = true;
            this.Dgv_Realizada.RowHeadersWidth = 20;
            this.Dgv_Realizada.Size = new System.Drawing.Size(227, 241);
            this.Dgv_Realizada.TabIndex = 0;
            this.Dgv_Realizada.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Realizada_CellMouseDoubleClick);
            // 
            // Dgv_Contestada
            // 
            this.Dgv_Contestada.BackgroundColor = System.Drawing.Color.Yellow;
            this.Dgv_Contestada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Contestada.GridColor = System.Drawing.Color.White;
            this.Dgv_Contestada.Location = new System.Drawing.Point(245, 174);
            this.Dgv_Contestada.Name = "Dgv_Contestada";
            this.Dgv_Contestada.ReadOnly = true;
            this.Dgv_Contestada.Size = new System.Drawing.Size(227, 241);
            this.Dgv_Contestada.TabIndex = 1;
            this.Dgv_Contestada.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Contestada_CellMouseDoubleClick);
            // 
            // Dgv_Recibida
            // 
            this.Dgv_Recibida.BackgroundColor = System.Drawing.Color.Green;
            this.Dgv_Recibida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Recibida.GridColor = System.Drawing.Color.White;
            this.Dgv_Recibida.Location = new System.Drawing.Point(478, 174);
            this.Dgv_Recibida.Name = "Dgv_Recibida";
            this.Dgv_Recibida.ReadOnly = true;
            this.Dgv_Recibida.Size = new System.Drawing.Size(227, 241);
            this.Dgv_Recibida.TabIndex = 2;
            this.Dgv_Recibida.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Recibida_CellMouseDoubleClick);
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
            this.Btn_Refresh.Location = new System.Drawing.Point(12, 141);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(36, 27);
            this.Btn_Refresh.TabIndex = 5;
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // ConsultaFormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 427);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Dgv_Realizada);
            this.Controls.Add(this.Dgv_Recibida);
            this.Controls.Add(this.Dgv_Contestada);
            this.Controls.Add(this.Btn_Enviar);
            this.Controls.Add(this.Text_Consulta);
            this.Controls.Add(this.Combo_Materia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaFormAlumno";
            this.ShowInTaskbar = false;
            this.Text = "ConsultaForm";
            this.Load += new System.EventHandler(this.ConsultaFormAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Realizada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Contestada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Recibida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Combo_Materia;
        private System.Windows.Forms.TextBox Text_Consulta;
        private System.Windows.Forms.Button Btn_Enviar;
        private System.Windows.Forms.DataGridView Dgv_Realizada;
        private System.Windows.Forms.DataGridView Dgv_Contestada;
        private System.Windows.Forms.DataGridView Dgv_Recibida;
        private System.Windows.Forms.Button Btn_Refresh;
    }
}