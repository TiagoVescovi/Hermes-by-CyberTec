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
                return label1.Text;
            }

            set
            {
                label1.Text = value;

                AdjustHeight();
            }
        }

        void AdjustHeight()
        {
            pictureBox1.Location = new Point(4, 3);
            label1.Height = Utils.GetTextHeight(label1) + 10;

            panel1.Height = label1.Top + panel1.Top + label1.Height;

            this.Height = panel1.Bottom + 10;
        }

        public Image Avatar { get => pictureBox1.Image; set => pictureBox1.Image = value; }

        private void IncommingResize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
