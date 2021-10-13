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
    public partial class Outcomming : UserControl
    {
        public Outcomming()
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
            label1.Height = Utils.GetTextHeight(label1) + 10;

            panel1.Height = label1.Top + panel1.Top + label1.Height;

            this.Height = panel1.Bottom + 10;
        }

        private void OutgoingResize(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void Outcomming_DockChanged(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
