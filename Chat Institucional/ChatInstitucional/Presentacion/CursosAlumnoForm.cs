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
    public partial class CursosAlumnoForm : Form
    {
        public CursosAlumnoForm()
        {
            InitializeComponent();
        }

        private void CursosAlumnoForm_Load(object sender, EventArgs e)
        {
            //  Llena el Dgv_Materias
            Materia materia = new Materia();
            Alumno alumno = new Alumno();
            for(int i = 0; i < materia.ListarMaterias(alumno.BuscarAlumno(Validacion.UsuarioActual).GetIdGrupo()).Rows.Count; i++)
            {
                Dgv_Materias.Columns.Add("Materia","nombre");
                Dgv_Materias.Rows.Add(materia.ListarMaterias(alumno.BuscarAlumno(Validacion.UsuarioActual).GetIdGrupo()).Rows[i][1]);
            }
            // Ver como hacer q solo muestre el nombre de las materias
        }

        private void Btn_Unirse_Click(object sender, EventArgs e)
        {
            // Se une a un chat q ya exista de esa materia

            DataTable dataTable = new DataTable();
            Chat chat = new Chat();
            Consulta consulta = new Consulta();
            Validacion validacion = new Validacion();
            Materia materia = new Materia();
            Alumno alumno = new Alumno();

            int idgrupo = alumno.BuscarAlumno(Validacion.UsuarioActual).GetIdGrupo();
            int index = Dgv_Materias.CurrentRow.Index;

            try
            {
                chat.SetCiAlumno(Validacion.UsuarioActual);
                chat.SetCiProfesor(Convert.ToInt32(materia.ListarMaterias(idgrupo).Rows[index][3]));
                chat.SetIdMateria(Convert.ToInt32(materia.ListarMaterias(idgrupo).Rows[index][2]));
                chat.SetIdGrupo(idgrupo);
                chat.SetIdConsulta(chat.ConseguirIdChat(chat));
                Console.WriteLine(chat.GetIdConsulta()); // sacar

                if (chat.UnirseChat(chat) == 0)
                {
                    MessageBox.Show("No te has podido unir al chat");
                }
                else 
                {
                    if (chat.UnirseChat(chat) == 1)
                    {
                        MessageBox.Show("Te has unido al chat");
                    }
                    else
                    {
                        MessageBox.Show("Ya eres parte del chat");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            // Crea un chat de esa materia si no existe

            DataTable dataTable = new DataTable();
            Chat chat = new Chat();
            Consulta consulta = new Consulta();
            Validacion validacion = new Validacion();
            Materia materia = new Materia();
            Alumno alumno = new Alumno();

            int idgrupo = alumno.BuscarAlumno(Validacion.UsuarioActual).GetIdGrupo();
            int index = Dgv_Materias.CurrentRow.Index;

            try
            {
                chat.SetCiAlumno(Validacion.UsuarioActual);
                chat.SetCiProfesor(Convert.ToInt32(materia.ListarMaterias(idgrupo).Rows[index][3]));
                chat.SetIdMateria(Convert.ToInt32(materia.ListarMaterias(idgrupo).Rows[index][2]));
                chat.SetIdGrupo(idgrupo);

                if (chat.SubirConsulta(chat))
                {
                    chat.SetIdConsulta(chat.ConseguirIdConsulta(Validacion.UsuarioActual));
                    chat.SetHoraIni(DateTime.Now);

                    if (chat.CrearChat(chat))
                    {
                        MessageBox.Show("Chat creado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear el chat");
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrió un error y no se pudo crear el chat");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Dgv_Materias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Se activan los botones dependiendo de si hay o no un chat ya creado
            DataTable dataTable = new DataTable();
            Chat chat = new Chat();
            Validacion validacion = new Validacion();
            Materia materia = new Materia();
            Alumno alumno = new Alumno();

            int idgrupo = alumno.BuscarAlumno(Validacion.UsuarioActual).GetIdGrupo();
            int index = Dgv_Materias.CurrentRow.Index;

            try
            {
                chat.SetCiAlumno(Validacion.UsuarioActual);
                chat.SetCiProfesor(Convert.ToInt32(materia.ListarMaterias(idgrupo).Rows[index][3]));
                chat.SetIdMateria(Convert.ToInt32(materia.ListarMaterias(idgrupo).Rows[index][2]));
                chat.SetIdGrupo(idgrupo);

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
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
