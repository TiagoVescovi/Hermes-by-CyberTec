using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatInstitucional.Logica;

namespace ChatInstitucional.Presentacion
{
    public partial class ConsultaFormAlumno : Form
    {
        Validacion validacion = new Validacion();

        public ConsultaFormAlumno()
        {
            InitializeComponent();

            DataTable nomMateria = validacion.TraerIdMateria(); //Generar tabla paralela para agarrar id
            for (int i = 0; i < nomMateria.Rows.Count; i++)
            {
                Combo_Materia.Items.Add(nomMateria.Rows[i]["nombreMat"] + " - " + nomMateria.Rows[i]["nombre"] + " " + nomMateria.Rows[i]["apellido"]);
            }
        }

        private void ConsultaFormAlumno_Load(object sender, EventArgs e)
        {
            //Llenar los DataGridView
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            Asincronica asincronica = new Asincronica();

            //Ver como tomar la idConsulta
            asincronica.SetCiAlumno(Validacion.UsuarioActual);
            //Ver como tomar la ci de profesor
            //idMateria
            //idGrupo
        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {
            //Abre la consulta y ésta pasa a tener estado RECIBIDA
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            //Lo mismo q en el Load
        }
    }
}
