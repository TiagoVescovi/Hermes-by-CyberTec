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
    public partial class MainFormAlumno : Form
    {
        Validacion validacion = new Validacion();

        public MainFormAlumno()
        {
            InitializeComponent();
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            //Ver clase PictureBox
        }

        private void Btn_Cursos_Click(object sender, EventArgs e)
        {
            //CursosForm
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está segur@ que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                validacion.ValidarLogOut(Validacion.UsuarioActual);
                Application.Exit();
            }
            else
            {

            }
            //Poner MessageBox del LoL y cambiar estado de logueado en persona en bdd
        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_Consultas_Click(object sender, EventArgs e)
        {
            ConsultaFormAlumno consultaForm = new ConsultaFormAlumno();
            consultaForm.TopLevel = false;
            consultaForm.AutoScroll = true;
            Pnl_Der.Controls.Add(consultaForm);
            consultaForm.Dock = DockStyle.Fill;

            consultaForm.Show();
        }
    }
}
