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

        public VerConsultasAlumnoForm()
        {
            InitializeComponent();

            //Muestra la consulta -- Muestra System.Byte[] -- Ver como arreglarlo
            Text_Consulta.Text = validacion.Select("SELECT contenido FROM asincronica a, consulta c WHERE a.idConsulta = c.idConsulta AND a.idConsulta = 2;").Rows[0]["contenido"].ToString();
        }
    }
}
