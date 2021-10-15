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
    public partial class VerConsultasAlumnoForm : Form
    {
        Validacion validacion = new Validacion();

        public VerConsultasAlumnoForm(int IdConsulta)
        {
            InitializeComponent();

            //Muestra la consulta -- Muestra System.Byte[] -- Ver como arreglarlo -- Arreglado cambiando de blob a varchar
            Text_Consulta.Text = validacion.Select("SELECT contenido FROM asincronica WHERE idConsulta = " + IdConsulta + ";").Rows[0]["contenido"].ToString();
        }

        private void VerConsultasAlumnoForm_Load(object sender, EventArgs e)
        {
            //Poner el nombre del alumno en el titulo del form -- Capaz q no
        }
    }
}
