namespace ChatInstitucional.Presentacion
{
    partial class DocenteConsultaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dgv_Realizada = new System.Windows.Forms.DataGridView();
            this.Dgv_Recibida = new System.Windows.Forms.DataGridView();
            this.Dgv_Contestada = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Realizada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Recibida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Contestada)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Realizada
            // 
            this.Dgv_Realizada.AllowUserToAddRows = false;
            this.Dgv_Realizada.AllowUserToDeleteRows = false;
            this.Dgv_Realizada.AllowUserToResizeColumns = false;
            this.Dgv_Realizada.AllowUserToResizeRows = false;
            this.Dgv_Realizada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dgv_Realizada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.Dgv_Realizada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Dgv_Realizada.BackgroundColor = System.Drawing.Color.Red;
            this.Dgv_Realizada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Dgv_Realizada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Realizada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Realizada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Realizada.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Realizada.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Realizada.EnableHeadersVisualStyles = false;
            this.Dgv_Realizada.GridColor = System.Drawing.Color.White;
            this.Dgv_Realizada.Location = new System.Drawing.Point(12, 45);
            this.Dgv_Realizada.MultiSelect = false;
            this.Dgv_Realizada.Name = "Dgv_Realizada";
            this.Dgv_Realizada.ReadOnly = true;
            this.Dgv_Realizada.RowHeadersVisible = false;
            this.Dgv_Realizada.RowHeadersWidth = 20;
            this.Dgv_Realizada.RowTemplate.ReadOnly = true;
            this.Dgv_Realizada.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Realizada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Realizada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Realizada.Size = new System.Drawing.Size(227, 370);
            this.Dgv_Realizada.TabIndex = 6;
            this.Dgv_Realizada.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Realizada_CellContentDoubleClick);
            // 
            // Dgv_Recibida
            // 
            this.Dgv_Recibida.AllowUserToAddRows = false;
            this.Dgv_Recibida.AllowUserToDeleteRows = false;
            this.Dgv_Recibida.AllowUserToResizeColumns = false;
            this.Dgv_Recibida.AllowUserToResizeRows = false;
            this.Dgv_Recibida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.Dgv_Recibida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Dgv_Recibida.BackgroundColor = System.Drawing.Color.Green;
            this.Dgv_Recibida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Dgv_Recibida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Recibida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Recibida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Recibida.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Recibida.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Recibida.EnableHeadersVisualStyles = false;
            this.Dgv_Recibida.GridColor = System.Drawing.Color.White;
            this.Dgv_Recibida.Location = new System.Drawing.Point(478, 45);
            this.Dgv_Recibida.MultiSelect = false;
            this.Dgv_Recibida.Name = "Dgv_Recibida";
            this.Dgv_Recibida.ReadOnly = true;
            this.Dgv_Recibida.RowHeadersVisible = false;
            this.Dgv_Recibida.RowTemplate.ReadOnly = true;
            this.Dgv_Recibida.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Recibida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Recibida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Recibida.Size = new System.Drawing.Size(227, 370);
            this.Dgv_Recibida.TabIndex = 10;
            this.Dgv_Recibida.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Recibida_CellContentDoubleClick);
            // 
            // Dgv_Contestada
            // 
            this.Dgv_Contestada.AllowUserToAddRows = false;
            this.Dgv_Contestada.AllowUserToDeleteRows = false;
            this.Dgv_Contestada.AllowUserToResizeColumns = false;
            this.Dgv_Contestada.AllowUserToResizeRows = false;
            this.Dgv_Contestada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.Dgv_Contestada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Dgv_Contestada.BackgroundColor = System.Drawing.Color.Yellow;
            this.Dgv_Contestada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Dgv_Contestada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Contestada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Contestada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Contestada.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Contestada.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_Contestada.EnableHeadersVisualStyles = false;
            this.Dgv_Contestada.GridColor = System.Drawing.Color.White;
            this.Dgv_Contestada.Location = new System.Drawing.Point(245, 45);
            this.Dgv_Contestada.MultiSelect = false;
            this.Dgv_Contestada.Name = "Dgv_Contestada";
            this.Dgv_Contestada.ReadOnly = true;
            this.Dgv_Contestada.RowHeadersVisible = false;
            this.Dgv_Contestada.RowTemplate.ReadOnly = true;
            this.Dgv_Contestada.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Contestada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Contestada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Contestada.Size = new System.Drawing.Size(227, 370);
            this.Dgv_Contestada.TabIndex = 8;
            this.Dgv_Contestada.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Contestada_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(52, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Estado de las consultas";
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
            this.Btn_Refresh.Location = new System.Drawing.Point(12, 12);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(36, 27);
            this.Btn_Refresh.TabIndex = 14;
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // ConsultaFormDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 427);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Dgv_Realizada);
            this.Controls.Add(this.Dgv_Recibida);
            this.Controls.Add(this.Dgv_Contestada);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaFormDocente";
            this.Text = "ConsultaFormDocente";
            this.Load += new System.EventHandler(this.ConsultaFormDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Realizada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Recibida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Contestada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.DataGridView Dgv_Realizada;
        private System.Windows.Forms.DataGridView Dgv_Recibida;
        private System.Windows.Forms.DataGridView Dgv_Contestada;
        private System.Windows.Forms.Label label1;
    }
}