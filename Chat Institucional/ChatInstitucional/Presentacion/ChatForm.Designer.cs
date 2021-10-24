namespace ChatInstitucional.Presentacion
{
    partial class ChatForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pnl_Chat = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Dgv_Chats = new System.Windows.Forms.DataGridView();
            this.Pnl_Mensajemandar = new System.Windows.Forms.Panel();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.Text_Mensaje = new System.Windows.Forms.TextBox();
            this.Pnl_Arriba = new System.Windows.Forms.Panel();
            this.Btn_Tema = new System.Windows.Forms.Button();
            this.Btn_Opciones = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Chats)).BeginInit();
            this.Pnl_Mensajemandar.SuspendLayout();
            this.Pnl_Arriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Chat
            // 
            this.Pnl_Chat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Chat.AutoScroll = true;
            this.Pnl_Chat.Location = new System.Drawing.Point(250, 64);
            this.Pnl_Chat.Name = "Pnl_Chat";
            this.Pnl_Chat.Size = new System.Drawing.Size(467, 331);
            this.Pnl_Chat.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_Refresh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 34);
            this.panel2.TabIndex = 0;
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
            this.Btn_Refresh.Location = new System.Drawing.Point(3, 4);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(36, 27);
            this.Btn_Refresh.TabIndex = 6;
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Dgv_Chats
            // 
            this.Dgv_Chats.AllowUserToAddRows = false;
            this.Dgv_Chats.AllowUserToDeleteRows = false;
            this.Dgv_Chats.AllowUserToResizeColumns = false;
            this.Dgv_Chats.AllowUserToResizeRows = false;
            this.Dgv_Chats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Dgv_Chats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dgv_Chats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv_Chats.ColumnHeadersHeight = 4;
            this.Dgv_Chats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Chats.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Chats.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Chats.EnableHeadersVisualStyles = false;
            this.Dgv_Chats.GridColor = System.Drawing.Color.Black;
            this.Dgv_Chats.Location = new System.Drawing.Point(0, 34);
            this.Dgv_Chats.MultiSelect = false;
            this.Dgv_Chats.Name = "Dgv_Chats";
            this.Dgv_Chats.ReadOnly = true;
            this.Dgv_Chats.RowHeadersVisible = false;
            this.Dgv_Chats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Chats.Size = new System.Drawing.Size(250, 393);
            this.Dgv_Chats.TabIndex = 1;
            this.Dgv_Chats.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Chats_CellMouseDoubleClick);
            // 
            // Pnl_Mensajemandar
            // 
            this.Pnl_Mensajemandar.BackColor = System.Drawing.Color.Gainsboro;
            this.Pnl_Mensajemandar.Controls.Add(this.Btn_Send);
            this.Pnl_Mensajemandar.Controls.Add(this.Text_Mensaje);
            this.Pnl_Mensajemandar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Mensajemandar.Location = new System.Drawing.Point(0, 391);
            this.Pnl_Mensajemandar.Name = "Pnl_Mensajemandar";
            this.Pnl_Mensajemandar.Size = new System.Drawing.Size(717, 36);
            this.Pnl_Mensajemandar.TabIndex = 0;
            // 
            // Btn_Send
            // 
            this.Btn_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Send.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Send.BackgroundImage = global::ChatInstitucional.Properties.Resources.send;
            this.Btn_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Send.Enabled = false;
            this.Btn_Send.FlatAppearance.BorderSize = 2;
            this.Btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Send.Font = new System.Drawing.Font("Impact", 2.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Send.Location = new System.Drawing.Point(672, 10);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(35, 20);
            this.Btn_Send.TabIndex = 3;
            this.Btn_Send.UseVisualStyleBackColor = false;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // Text_Mensaje
            // 
            this.Text_Mensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Mensaje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_Mensaje.Enabled = false;
            this.Text_Mensaje.Location = new System.Drawing.Point(256, 10);
            this.Text_Mensaje.Name = "Text_Mensaje";
            this.Text_Mensaje.Size = new System.Drawing.Size(410, 20);
            this.Text_Mensaje.TabIndex = 2;
            this.Text_Mensaje.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Text_Mensaje_KeyUp);
            // 
            // Pnl_Arriba
            // 
            this.Pnl_Arriba.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Pnl_Arriba.BackColor = System.Drawing.Color.Gainsboro;
            this.Pnl_Arriba.Controls.Add(this.Btn_Tema);
            this.Pnl_Arriba.Controls.Add(this.Btn_Opciones);
            this.Pnl_Arriba.Location = new System.Drawing.Point(250, 34);
            this.Pnl_Arriba.Name = "Pnl_Arriba";
            this.Pnl_Arriba.Size = new System.Drawing.Size(467, 31);
            this.Pnl_Arriba.TabIndex = 0;
            // 
            // Btn_Tema
            // 
            this.Btn_Tema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Tema.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Tema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Tema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Tema.Enabled = false;
            this.Btn_Tema.FlatAppearance.BorderSize = 0;
            this.Btn_Tema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Tema.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Tema.Location = new System.Drawing.Point(6, 1);
            this.Btn_Tema.Name = "Btn_Tema";
            this.Btn_Tema.Size = new System.Drawing.Size(421, 27);
            this.Btn_Tema.TabIndex = 5;
            this.Btn_Tema.Text = "Tema Chat";
            this.Btn_Tema.UseVisualStyleBackColor = false;
            this.Btn_Tema.Click += new System.EventHandler(this.Btn_Tema_Click);
            // 
            // Btn_Opciones
            // 
            this.Btn_Opciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Opciones.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Opciones.BackgroundImage = global::ChatInstitucional.Properties.Resources.menu_vertical;
            this.Btn_Opciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Opciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Opciones.Enabled = false;
            this.Btn_Opciones.FlatAppearance.BorderSize = 0;
            this.Btn_Opciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Opciones.Font = new System.Drawing.Font("Impact", 2.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Opciones.Location = new System.Drawing.Point(433, 1);
            this.Btn_Opciones.Name = "Btn_Opciones";
            this.Btn_Opciones.Size = new System.Drawing.Size(31, 27);
            this.Btn_Opciones.TabIndex = 4;
            this.Btn_Opciones.UseVisualStyleBackColor = false;
            this.Btn_Opciones.Click += new System.EventHandler(this.Btn_Opciones_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 427);
            this.Controls.Add(this.Dgv_Chats);
            this.Controls.Add(this.Pnl_Mensajemandar);
            this.Controls.Add(this.Pnl_Arriba);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Pnl_Chat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChatFormAlumno_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Chats)).EndInit();
            this.Pnl_Mensajemandar.ResumeLayout(false);
            this.Pnl_Mensajemandar.PerformLayout();
            this.Pnl_Arriba.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Pnl_Chat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Dgv_Chats;
        private System.Windows.Forms.Panel Pnl_Mensajemandar;
        private System.Windows.Forms.Button Btn_Opciones;
        private System.Windows.Forms.Panel Pnl_Arriba;
        private System.Windows.Forms.TextBox Text_Mensaje;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Button Btn_Tema;
    }
}