using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatInstitucional.Logica;

namespace ChatInstitucional.Presentacion
{
    public partial class RgstrAlumnoForm : Form
    {
        public RgstrAlumnoForm()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_RegAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                //if(Text_Nickname) IsNullOrEmpty
                    String pass = Text_Pass.Text;
                    String checkPass = Text_CheckPass.Text;
            }
            catch
            {

            }
        }
    }
}
