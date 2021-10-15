using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatInstitucional.Logica;

namespace ChatInstitucional.ChatItems
{
    public partial class Incomming : UserControl
    {
        public Incomming()
        {
            InitializeComponent();
        }

        public string Mensaje
        {
            get
            {
                return Lbl_Text.Text;
            }

            set
            {
                Lbl_Text.Text = value;

                AdjustHeight();
            }
        }

        void AdjustHeight()
        {
            Lbl_Time.Location = new Point(4, 3);
            Lbl_Text.Height = Utils.GetTextHeight(Lbl_Text) + 10;
            
            panel1.Height = Lbl_Text.Top + panel1.Top + Lbl_Text.Height;

            this.Height = panel1.Bottom + 10 + Lbl_Time.Top + Lbl_Time.Height;
        }

        public string Nombre { get => Lbl_Name.Text; set => Lbl_Name.Text = value; }
        public string Fecha { get => Lbl_Time.Text; set => Lbl_Time.Text = value; }

        private void IncommingResize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
