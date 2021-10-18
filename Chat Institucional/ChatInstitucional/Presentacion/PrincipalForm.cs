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
    public partial class PrincipalForm : Form
    {
        Validacion validacion = new Validacion();

        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            label1.Text = "BIENVENID@ " + persona.BuscarPersona(Validacion.UsuarioActual).GetNickname();
        }
    }
}
