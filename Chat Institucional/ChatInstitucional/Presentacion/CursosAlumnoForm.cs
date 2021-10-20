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
        int idChat = 0;
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
                for (int i = 0; i < materia.ListarMaterias(idgrupo).Rows.Count; i++)
                {
                    if (Dgv_Materias.Rows[index].Cells[0].Value.ToString() == materia.ListarMaterias(idgrupo).Rows[i][1].ToString())
                    {
                        int idmateria = Convert.ToInt32(materia.ListarMaterias(idgrupo).Rows[i][0]);
                        Text_NomDocente.Text = materia.ListarMaterias(idgrupo).Rows[i][6].ToString() + " " + materia.ListarMaterias(idgrupo).Rows[i][7];

                        for (int c = 0; c < chat.ListarConsultas().Rows.Count; c++)
                        {
                            if (idmateria == Convert.ToInt32(chat.ListarConsultas().Rows[c][3]))
                            {
                                chat.SetHoraIni(DateTime.Now);
                                chat.SetCiAlumno(Validacion.UsuarioActual);
                                chat.SetCiProfesor(Convert.ToInt32(materia.ListarMaterias(idgrupo).Rows[i][4]));
                                chat.SetIdMateria(idmateria);
                                chat.SetIdGrupo(idgrupo);

                                if (chat.UnirseChat(chat))
                                {
                                    MessageBox.Show("te uniste al chat");
                                }
                                else
                                {
                                    MessageBox.Show("No pudiste unirte al chat");
                                }
                            }
                        }
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
                for (int i = 0; i < materia.ListarMaterias(idgrupo).Rows.Count; i++)
                {
                    if (Dgv_Materias.Rows[index].Cells[0].Value.ToString() == materia.ListarMaterias(idgrupo).Rows[i][1].ToString())
                    {
                        int idmateria = Convert.ToInt32(materia.ListarMaterias(idgrupo).Rows[i][0]);
                        Text_NomDocente.Text = materia.ListarMaterias(idgrupo).Rows[i][6].ToString() + " " + materia.ListarMaterias(idgrupo).Rows[i][7];

                        for (int c = 0; c < chat.ListarConsultas().Rows.Count; c++)
                        {
                            if (idmateria == Convert.ToInt32(chat.ListarConsultas().Rows[c][3]))
                            {
                                chat.SetHoraIni(DateTime.Now);
                                chat.SetCiAlumno(Validacion.UsuarioActual);
                                chat.SetCiProfesor(Convert.ToInt32(materia.ListarMaterias(idgrupo).Rows[i][4]));
                                chat.SetIdMateria(idmateria);
                                chat.SetIdGrupo(idgrupo);

                                if (chat.SubirConsulta(chat))
                                {
                                    chat.SetIdConsulta(chat.ConseguirIdConsulta(Validacion.UsuarioActual));

                                    if (chat.CrearChat(chat))
                                    {
                                        MessageBox.Show("El chat ha sido creado exitosamente"); // Sacar los MessageBox del for xd
                                        Btn_Crear.Enabled = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se pudo crear el chat");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ocurrió un error al crear el chat");
                                }
                            }
                        }
                    }
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
            Consulta consulta = new Consulta();
            Validacion validacion = new Validacion();
            Materia materia = new Materia();
            Alumno alumno = new Alumno();

            int idgrupo = alumno.BuscarAlumno(Validacion.UsuarioActual).GetIdGrupo();
            int index = Dgv_Materias.CurrentRow.Index;

            try
            {
                for (int i = 0; i < materia.ListarMaterias(idgrupo).Rows.Count; i++) // Releer esto a ver q hice mal -- Parece q esta bien
                {
                    if (Dgv_Materias.Rows[index].Cells[0].Value.ToString() == materia.ListarMaterias(idgrupo).Rows[i][1].ToString())
                    {
                        int idmateria = Convert.ToInt32(materia.ListarMaterias(idgrupo).Rows[i][0]);
                        Text_NomDocente.Text = materia.ListarMaterias(idgrupo).Rows[i][6].ToString() + " " + materia.ListarMaterias(idgrupo).Rows[i][7];

                        for (int c = 0; c < chat.ListarConsultas().Rows.Count; c++)
                        {
                            if (idmateria == Convert.ToInt32(chat.ListarConsultas().Rows[c][3]))
                            {
                                int idchat = Convert.ToInt32(chat.ListarConsultas().Rows[c][0]);

                                if (idgrupo == chat.BuscarChat(idchat).GetIdGrupo() && String.IsNullOrEmpty(chat.BuscarChat(idchat).GetHoraFin()))
                                {
                                    Btn_Unirse.Enabled = true;
                                }
                                else
                                {
                                    Btn_Crear.Enabled = true;
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
