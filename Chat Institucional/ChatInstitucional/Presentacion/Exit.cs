using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatInstitucional.Presentacion
{
    public partial class Exit : Form
    {
        public Exit()
        {
            InitializeComponent();
        }

        int Answer { get; set; }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            Answer = 0;
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Answer = 1;
            this.Close();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Answer = 2;
            this.Close();
        }

        public int Respuesta()
        {
            return Answer;
        }
    }
}
