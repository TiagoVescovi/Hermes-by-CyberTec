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
            //Llena los DataGridView
            try
            {   //Muestra todos los profesores(? o algo asi muy raro -- Ver el form ejecutado para entender
                Dgv_Realizada.DataSource = validacion.Select("SELECT p.nombre as 'Nombre', p.apellido as 'Apellido' FROM asincronica a, consulta c, persona p WHERE cedula = ciProfesor AND estado = 'Realizada' AND ciAlumno = " + Validacion.UsuarioActual + ";");
                Dgv_Contestada.DataSource = validacion.Select("SELECT p.nombre as 'Nombre', p.apellido as 'Apellido' FROM asincronica a, consulta c, persona p WHERE cedula = ciProfesor AND estado = 'Contestada' AND ciAlumno = " + Validacion.UsuarioActual + ";");
                Dgv_Recibida.DataSource = validacion.Select("SELECT p.nombre as 'Nombre', p.apellido as 'Apellido' FROM asincronica a, consulta c, persona p WHERE cedula = ciProfesor AND estado = 'Recibida' AND ciAlumno = " + Validacion.UsuarioActual + ";");
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al mostrar las consultas.\nPor favor intente nuevamente");
            }
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            //Crea Consulta y crea Asincronica
            Asincronica asincronica = new Asincronica();
            try
            {       //No puebla bien Asincronica
                asincronica.SetIdConsulta(Convert.ToInt32(validacion.Select("SELECT idConsulta FROM consulta WHERE ciAlumno = " + Validacion.UsuarioActual + " AND idConsulta >= ALL (SELECT idConsulta FROM consulta WHERE ciAlumno = " + Validacion.UsuarioActual + ");").Rows[0]["idConsulta"]));
                Console.WriteLine(asincronica.GetIdConsulta().ToString()); //sacar
                asincronica.SetCiAlumno(Validacion.UsuarioActual);
                asincronica.SetCiProfesor(Convert.ToInt32(validacion.TraerIdMateria().Rows[Combo_Materia.SelectedIndex]["cedula"]));
                Console.WriteLine(asincronica.GetCiProfesor()); //sacar
                asincronica.SetIdMateria(Convert.ToInt32(validacion.Select("SELECT p.cedula, m.nombre as 'nombreMat', p.nombre, p.apellido, m.idMateria FROM materia m, enseña e, persona p WHERE m.idMateria = e.idMateria AND e.ciProfesor = p.cedula;").Rows[Combo_Materia.SelectedIndex]["idMateria"]));
                Console.WriteLine(asincronica.GetIdMateria()); //sacar
                asincronica.SetIdGrupo(Convert.ToInt32(validacion.Select("SELECT idGrupo FROM alumno WHERE cedula = " + Validacion.UsuarioActual + ";").Rows[0]["idGrupo"]));
                Console.WriteLine(asincronica.GetIdGrupo()); //sacar
                asincronica.SetEstado("Realizada");
                asincronica.SetContenido(Text_Consulta.Text);
                Console.WriteLine(asincronica.GetContenido()); //sacar

                if (validacion.SubirConsulta(asincronica))
                {
                    MessageBox.Show("Consulta enviada satisfacrotiamente");
                }
            }
            catch
            {
                MessageBox.Show("No se pudo enviar la consulta");
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            //Lo mismo q el Load
            try
            {
                Dgv_Realizada.DataSource = validacion.Select("SELECT p.nombre as 'Nombre', p.apellido as 'Apellido' FROM asincronica a, consulta c, persona p WHERE cedula = ciProfesor AND estado = 'Realizada' AND ciAlumno = " + Validacion.UsuarioActual + ";");
                Dgv_Contestada.DataSource = validacion.Select("SELECT p.nombre as 'Nombre', p.apellido as 'Apellido' FROM asincronica a, consulta c, persona p WHERE cedula = ciProfesor AND estado = 'Contestada' AND ciAlumno = " + Validacion.UsuarioActual + ";");
                Dgv_Recibida.DataSource = validacion.Select("SELECT p.nombre as 'Nombre', p.apellido as 'Apellido' FROM asincronica a, consulta c, persona p WHERE cedula = ciProfesor AND estado = 'Recibida' AND ciAlumno = " + Validacion.UsuarioActual + ";");
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al mostrar las consultas.\nPor favor intente nuevamente");
            }
        }

        private void Dgv_Realizada_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Doble click en el rojo
            VerConsultasAlumnoForm ver = new VerConsultasAlumnoForm(11);  //Ver como tomar el idConsulta del DataGridView
            //Dgv_Realizada.SelectedRows   Para poner el nombre del alumno como titulo del form
            ver.ShowDialog();
        }

        private void Dgv_Contestada_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Doble click en el amarillo
        }

        private void Dgv_Recibida_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Doble click en el verde
        }
    }
}
