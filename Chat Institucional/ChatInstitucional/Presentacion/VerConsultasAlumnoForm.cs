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
        int idAsincronica;

        public VerConsultasAlumnoForm(int IdAsincronica)
        {
            InitializeComponent();

            idAsincronica = IdAsincronica;
        }

        private void VerConsultasAlumnoForm_Load(object sender, EventArgs e)
        {
            Asincronica asincronica = new Asincronica();
            //Poner el nombre del alumno en el titulo del form -- Capaz q no
            Text_Consulta.Text = asincronica.VerAsincronica(idAsincronica).GetConsulta().ToString();
            Text_Respuesta.Text = asincronica.VerAsincronica(idAsincronica).GetRespuesta().ToString();
        }
    }
}
