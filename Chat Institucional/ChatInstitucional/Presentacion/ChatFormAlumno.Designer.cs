namespace ChatInstitucional.Presentacion
{
    partial class ChatFormAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatFormAlumno));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pnl_Chat = new System.Windows.Forms.Panel();
            this.outcomming1 = new ChatInstitucional.ChatItems.Outcomming();
            this.incomming1 = new ChatInstitucional.ChatItems.Incomming();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dgv_Chats = new System.Windows.Forms.DataGridView();
            this.Pnl_Mensajemandar = new System.Windows.Forms.Panel();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.Text_Mensaje = new System.Windows.Forms.TextBox();
            this.Pnl_Arriba = new System.Windows.Forms.Panel();
            this.Btn_Opciones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_Chat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Chats)).BeginInit();
            this.Pnl_Mensajemandar.SuspendLayout();
            this.Pnl_Arriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Chat
            // 
            this.Pnl_Chat.AutoScroll = true;
            this.Pnl_Chat.Controls.Add(this.outcomming1);
            this.Pnl_Chat.Controls.Add(this.incomming1);
            this.Pnl_Chat.Location = new System.Drawing.Point(256, 64);
            this.Pnl_Chat.Name = "Pnl_Chat";
            this.Pnl_Chat.Size = new System.Drawing.Size(460, 331);
            this.Pnl_Chat.TabIndex = 0;
            // 
            // outcomming1
            // 
            this.outcomming1.BackColor = System.Drawing.Color.Transparent;
            this.outcomming1.Dock = System.Windows.Forms.DockStyle.Top;
            this.outcomming1.Location = new System.Drawing.Point(0, 63);
            this.outcomming1.Mensaje = "Hola mundo";
            this.outcomming1.Name = "outcomming1";
            this.outcomming1.Size = new System.Drawing.Size(460, 63);
            this.outcomming1.TabIndex = 1;
            // 
            // incomming1
            // 
            this.incomming1.Avatar = ((System.Drawing.Image)(resources.GetObject("incomming1.Avatar")));
            this.incomming1.BackColor = System.Drawing.Color.Transparent;
            this.incomming1.Dock = System.Windows.Forms.DockStyle.Top;
            this.incomming1.Location = new System.Drawing.Point(0, 0);
            this.incomming1.Mensaje = "Hola mundo";
            this.incomming1.Name = "incomming1";
            this.incomming1.Size = new System.Drawing.Size(460, 63);
            this.incomming1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 34);
            this.panel2.TabIndex = 0;
            // 
            // Dgv_Chats
            // 
            this.Dgv_Chats.AllowUserToAddRows = false;
            this.Dgv_Chats.AllowUserToDeleteRows = false;
            this.Dgv_Chats.AllowUserToResizeColumns = false;
            this.Dgv_Chats.AllowUserToResizeRows = false;
            this.Dgv_Chats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.Dgv_Chats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Dgv_Chats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dgv_Chats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv_Chats.ColumnHeadersHeight = 4;
            this.Dgv_Chats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Chats.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Chats.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Chats.Dock = System.Windows.Forms.DockStyle.Left;
            this.Dgv_Chats.EnableHeadersVisualStyles = false;
            this.Dgv_Chats.Location = new System.Drawing.Point(0, 34);
            this.Dgv_Chats.MultiSelect = false;
            this.Dgv_Chats.Name = "Dgv_Chats";
            this.Dgv_Chats.ReadOnly = true;
            this.Dgv_Chats.RowHeadersVisible = false;
            this.Dgv_Chats.Size = new System.Drawing.Size(256, 393);
            this.Dgv_Chats.TabIndex = 1;
            // 
            // Pnl_Mensajemandar
            // 
            this.Pnl_Mensajemandar.Controls.Add(this.Btn_Send);
            this.Pnl_Mensajemandar.Controls.Add(this.Text_Mensaje);
            this.Pnl_Mensajemandar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Mensajemandar.Location = new System.Drawing.Point(256, 393);
            this.Pnl_Mensajemandar.Name = "Pnl_Mensajemandar";
            this.Pnl_Mensajemandar.Size = new System.Drawing.Size(460, 34);
            this.Pnl_Mensajemandar.TabIndex = 0;
            // 
            // Btn_Send
            // 
            this.Btn_Send.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Send.BackgroundImage = global::ChatInstitucional.Properties.Resources.send;
            this.Btn_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Send.FlatAppearance.BorderSize = 2;
            this.Btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Send.Font = new System.Drawing.Font("Impact", 2.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Send.Location = new System.Drawing.Point(422, 8);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(35, 20);
            this.Btn_Send.TabIndex = 3;
            this.Btn_Send.UseVisualStyleBackColor = false;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // Text_Mensaje
            // 
            this.Text_Mensaje.Location = new System.Drawing.Point(3, 8);
            this.Text_Mensaje.Name = "Text_Mensaje";
            this.Text_Mensaje.Size = new System.Drawing.Size(413, 20);
            this.Text_Mensaje.TabIndex = 2;
            this.Text_Mensaje.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Text_Mensaje_KeyUp);
            // 
            // Pnl_Arriba
            // 
            this.Pnl_Arriba.Controls.Add(this.label1);
            this.Pnl_Arriba.Controls.Add(this.Btn_Opciones);
            this.Pnl_Arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Arriba.Location = new System.Drawing.Point(256, 34);
            this.Pnl_Arriba.Name = "Pnl_Arriba";
            this.Pnl_Arriba.Size = new System.Drawing.Size(460, 31);
            this.Pnl_Arriba.TabIndex = 0;
            // 
            // Btn_Opciones
            // 
            this.Btn_Opciones.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Opciones.BackgroundImage = global::ChatInstitucional.Properties.Resources.menu_vertical;
            this.Btn_Opciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Opciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Opciones.FlatAppearance.BorderSize = 0;
            this.Btn_Opciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Opciones.Font = new System.Drawing.Font("Impact", 2.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Opciones.Location = new System.Drawing.Point(428, 1);
            this.Btn_Opciones.Name = "Btn_Opciones";
            this.Btn_Opciones.Size = new System.Drawing.Size(31, 27);
            this.Btn_Opciones.TabIndex = 4;
            this.Btn_Opciones.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre Apellido";
            // 
            // ChatFormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 427);
            this.Controls.Add(this.Pnl_Arriba);
            this.Controls.Add(this.Pnl_Mensajemandar);
            this.Controls.Add(this.Dgv_Chats);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Pnl_Chat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatFormAlumno";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChatFormAlumno_Load);
            this.Pnl_Chat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Chats)).EndInit();
            this.Pnl_Mensajemandar.ResumeLayout(false);
            this.Pnl_Mensajemandar.PerformLayout();
            this.Pnl_Arriba.ResumeLayout(false);
            this.Pnl_Arriba.PerformLayout();
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
        private ChatItems.Incomming incomming1;
        private ChatItems.Outcomming outcomming1;
        private System.Windows.Forms.Label label1;
    }
}