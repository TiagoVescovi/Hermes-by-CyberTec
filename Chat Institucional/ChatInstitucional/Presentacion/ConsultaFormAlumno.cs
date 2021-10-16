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
        int IdConsulta = 0;


        public ConsultaFormAlumno()
        {
            InitializeComponent();
        }

        private void ConsultaFormAlumno_Load(object sender, EventArgs e)
        {
            //Llena el Combo_Materia
            
            DataTable nomMateria = validacion.TraerIdMateria(); //Generar tabla paralela para agarrar id
            
            /*for (int i = 0; i<110; i++)
            {
                if(a.Rows[i].Equals(b.Rows[i])
                    idconsulta= a.
            }*/


            for (int i = 0; i < nomMateria.Rows.Count; i++)
            {
                Combo_Materia.Items.Add(nomMateria.Rows[i]["nombreMat"] + " - " + nomMateria.Rows[i]["nombre"] + " " + nomMateria.Rows[i]["apellido"]);
            }

            //Llena los DataGridView
            try
            {
                Dgv_Realizada.DataSource = validacion.Select("SELECT c.idConsulta AS ' .', p.nombre as 'Nombre', p.apellido as 'Apellido' FROM asincronica a, consulta c, persona p WHERE cedula = ciProfesor AND c.idConsulta = a.idConsulta AND estado = 'Realizada' AND ciAlumno = " + Validacion.UsuarioActual + ";");
                Dgv_Contestada.DataSource = validacion.Select("SELECT c.idConsulta as '. ', p.nombre as 'Nombre', p.apellido as 'Apellido' FROM asincronica a, consulta c, persona p WHERE cedula = ciProfesor AND c.idConsulta = a.idConsulta AND estado = 'Contestada' AND ciAlumno = " + Validacion.UsuarioActual + ";");
                Dgv_Recibida.DataSource = validacion.Select("SELECT c.idConsulta as ' .', p.nombre as 'Nombre', p.apellido as 'Apellido' FROM asincronica a, consulta c, persona p WHERE cedula = ciProfesor AND c.idConsulta = a.idConsulta AND estado = 'Reccibida' AND ciAlumno = " + Validacion.UsuarioActual + ";");

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
            {
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

                if (validacion.Insert("INSERT INTO consulta(ciAlumno,ciProfesor,idMateria,idGrupo) VALUES (" + asincronica.GetCiAlumno() + "," + asincronica.GetCiProfesor() + "," + asincronica.GetIdMateria() + "," + asincronica.GetIdGrupo() + ");"))
                {
                    asincronica.SetIdConsulta(Convert.ToInt32(validacion.Select("SELECT idConsulta FROM consulta WHERE ciAlumno = " + Validacion.UsuarioActual + " AND idConsulta >= ALL (SELECT idConsulta FROM consulta WHERE ciAlumno = " + Validacion.UsuarioActual + ");").Rows[0]["idConsulta"]));
                    if (validacion.Insert("INSERT INTO asincronica(idConsulta,estado,contenido) VALUES (" + asincronica.GetIdConsulta() + ",'" + asincronica.GetEstado() + "','" + asincronica.GetContenido() + "');"))
                    {
                        MessageBox.Show("Consulta enviada satisfactoriamente");
                    }
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
                Dgv_Realizada.DataSource = validacion.Select("SELECT c.idConsulta, p.nombre as 'Nombre', p.apellido as 'Apellido' FROM asincronica a, consulta c, persona p WHERE cedula = ciProfesor AND c.idConsulta = a.idConsulta AND estado = 'Realizada' AND ciAlumno = " + Validacion.UsuarioActual + ";");
                Dgv_Contestada.DataSource = validacion.Select("SELECT c.idConsulta, p.nombre as 'Nombre', p.apellido as 'Apellido' FROM asincronica a, consulta c, persona p WHERE cedula = ciProfesor AND c.idConsulta = a.idConsulta AND estado = 'Contestada' AND ciAlumno = " + Validacion.UsuarioActual + ";");
                Dgv_Recibida.DataSource = validacion.Select("SELECT c.idConsulta, p.nombre as 'Nombre', p.apellido as 'Apellido' FROM asincronica a, consulta c, persona p WHERE cedula = ciProfesor AND c.idConsulta = a.idConsulta AND estado = 'Reccibida' AND ciAlumno = " + Validacion.UsuarioActual + ";");
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al mostrar las consultas.\nPor favor intente nuevamente");
            }
        }

        private void Dgv_Realizada_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Doble click en el rojo
            int index = Dgv_Realizada.CurrentRow.Index;
            IdConsulta = Convert.ToInt32(Dgv_Realizada.Rows[index].Cells[0].Value);
            VerConsultasAlumnoForm ver = new VerConsultasAlumnoForm(IdConsulta);
            ver.ShowDialog();
        }

        private void Dgv_Contestada_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Doble click en el amarillo
            int index = Dgv_Contestada.CurrentRow.Index;
            IdConsulta = Convert.ToInt32(Dgv_Contestada.Rows[index].Cells[0].Value);
            VerConsultasAlumnoForm ver = new VerConsultasAlumnoForm(IdConsulta);
            validacion.Update("UPDATE asincronica SET estado = 'Recibida' WHERE idConuslta = " + IdConsulta + ";");
            ver.ShowDialog();
            //Agregar atributo respuesta
        }

        private void Dgv_Recibida_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Doble click en el verde
            int index = Dgv_Recibida.CurrentRow.Index;
            IdConsulta = Convert.ToInt32(Dgv_Recibida.Rows[index].Cells[0].Value);
            VerConsultasAlumnoForm ver = new VerConsultasAlumnoForm(IdConsulta);
            ver.ShowDialog();
        }
    }
}
