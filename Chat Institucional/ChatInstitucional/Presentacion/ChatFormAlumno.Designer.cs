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
            this.Dgv_Chats = new System.Windows.Forms.DataGridView();
            this.Pnl_Chat = new System.Windows.Forms.Panel();
            this.Text_EnviarMsg = new System.Windows.Forms.TextBox();
            this.Btn_Enviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Chats)).BeginInit();
            this.Pnl_Chat.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_Chats
            // 
            this.Dgv_Chats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Chats.Location = new System.Drawing.Point(10, 69);
            this.Dgv_Chats.Name = "Dgv_Chats";
            this.Dgv_Chats.Size = new System.Drawing.Size(205, 346);
            this.Dgv_Chats.TabIndex = 0;
            // 
            // Pnl_Chat
            // 
            this.Pnl_Chat.Controls.Add(this.Btn_Enviar);
            this.Pnl_Chat.Controls.Add(this.Text_EnviarMsg);
            this.Pnl_Chat.Location = new System.Drawing.Point(222, 69);
            this.Pnl_Chat.Name = "Pnl_Chat";
            this.Pnl_Chat.Size = new System.Drawing.Size(482, 346);
            this.Pnl_Chat.TabIndex = 1;
            // 
            // Text_EnviarMsg
            // 
            this.Text_EnviarMsg.Location = new System.Drawing.Point(4, 323);
            this.Text_EnviarMsg.Name = "Text_EnviarMsg";
            this.Text_EnviarMsg.Size = new System.Drawing.Size(434, 20);
            this.Text_EnviarMsg.TabIndex = 0;
            // 
            // Btn_Enviar
            // 
            this.Btn_Enviar.Location = new System.Drawing.Point(444, 323);
            this.Btn_Enviar.Name = "Btn_Enviar";
            this.Btn_Enviar.Size = new System.Drawing.Size(35, 21);
            this.Btn_Enviar.TabIndex = 1;
            this.Btn_Enviar.Text = "ENVIAR";
            this.Btn_Enviar.UseVisualStyleBackColor = true;
            this.Btn_Enviar.Click += new System.EventHandler(this.Btn_Enviar_Click);
            // 
            // ChatFormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 427);
            this.Controls.Add(this.Pnl_Chat);
            this.Controls.Add(this.Dgv_Chats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatFormAlumno";
            this.Text = "ChatForm";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Chats)).EndInit();
            this.Pnl_Chat.ResumeLayout(false);
            this.Pnl_Chat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Chats;
        private System.Windows.Forms.Panel Pnl_Chat;
        private System.Windows.Forms.TextBox Text_EnviarMsg;
        private System.Windows.Forms.Button Btn_Enviar;
    }
}