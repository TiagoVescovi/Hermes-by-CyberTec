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
    public partial class AlumnoCursosForm : Form
    {
        int index;

        public AlumnoCursosForm()
        {
            InitializeComponent();
        }

        private void CursosAlumnoForm_Load(object sender, EventArgs e)
        {
            //  Llena el Dgv_Materias --- Con enseña
            RecargarChats();
        }

        private void Btn_Unirse_Click(object sender, EventArgs e)
        {
            // Se une a un chat q ya exista de esa materia
            // Como esta enabled --> existe
            Chat chat = new Chat();
            Alumno alumno = new Alumno();
            Materia materia = new Materia();

            chat.SetCiAlumno(Validacion.UsuarioActual);
            chat.SetCiProfesor(Convert.ToInt32(materia.ListarMaterias(alumno.BuscarAlumno(Validacion.UsuarioActual).GetIdGrupo()).Rows[Dgv_Materias.CurrentRow.Index][4]));
            chat.SetIdGrupo(alumno.BuscarAlumno(Validacion.UsuarioActual).GetIdGrupo());
            chat.SetIdMateria(Convert.ToInt32(materia.ListarMaterias(alumno.BuscarAlumno(Validacion.UsuarioActual).GetIdGrupo()).Rows[Dgv_Materias.CurrentRow.Index][0]));

            chat.SetIdConsulta(chat.ConseguirIdChat(chat));

            switch (chat.UnirseChat(chat))
            {
                case 1:
                    MessageBox.Show("Te has unido al chat");
                    break;

                case 2:
                    MessageBox.Show("Ya eres parte del chat");
                    break;
                case 3:
                    MessageBox.Show("Te has vuelto a unir al chat");
                    break;

                case 0:
                    MessageBox.Show("No te has podido unir al chat");
                    break;
            }
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            // Crea un chat de esa materia si no existe
            // Como esta enabled--> no existe
            Chat chat = new Chat();
            Materia materia = new Materia();
            Alumno alumno = new Alumno();

            chat.SetCiAlumno(Validacion.UsuarioActual);
            chat.SetCiProfesor(Convert.ToInt32(materia.ListarMaterias(alumno.BuscarAlumno(Validacion.UsuarioActual).GetIdGrupo()).Rows[Dgv_Materias.CurrentRow.Index][4]));
            chat.SetIdMateria(Convert.ToInt32(materia.ListarMaterias(alumno.BuscarAlumno(Validacion.UsuarioActual).GetIdGrupo()).Rows[Dgv_Materias.CurrentRow.Index][0]));
            chat.SetIdGrupo(alumno.BuscarAlumno(Validacion.UsuarioActual).GetIdGrupo());

            if (chat.CrearChat(chat))
            {
                MessageBox.Show("Chat creado satisfactoriamente.\nYa se te ha incluído en el chat");
            }
            else
            {
                MessageBox.Show("No se ha podido crear el chat");
            }
        }

        private void RecargarChats()
        {
            Dgv_Materias.Rows.Clear();
            Materia materia = new Materia();
            Alumno alumno = new Alumno();
            DataTable dataTable = new DataTable();

            for(int i = 0; i < materia.ListarMaterias(alumno.BuscarAlumno(Validacion.UsuarioActual).GetIdGrupo()).Rows.Count; i++)
            {
                Dgv_Materias.Rows.Add(materia.BuscarMateria(Convert.ToInt32(materia.ListarMaterias(alumno.BuscarAlumno(Validacion.UsuarioActual).GetIdGrupo()).Rows[i][0])).GetNombre());
                Dgv_Materias.Columns[0].Width = Dgv_Materias.Width;
                Dgv_Materias.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            RecargarChats();
        }

        private void Dgv_Materias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Se activan los botones dependiendo de si hay o no un chat ya creado
            Chat chat = new Chat();
            Alumno alumno = new Alumno();
            Materia materia = new Materia();

            chat.SetIdMateria(Convert.ToInt32(materia.ListarMaterias(alumno.BuscarAlumno(Validacion.UsuarioActual).GetIdGrupo()).Rows[Dgv_Materias.CurrentRow.Index][0]));
            chat.SetIdGrupo(alumno.BuscarAlumno(Validacion.UsuarioActual).GetIdGrupo());

            if (chat.ValidarChat(chat))
            {
                Btn_Crear.Enabled = false;
                Btn_Unirse.Enabled = true;
            }
            else
            {
                Btn_Crear.Enabled = true;
                Btn_Unirse.Enabled = false;
            }
        }
    }
}
