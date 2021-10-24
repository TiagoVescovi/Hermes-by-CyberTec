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

            Materia materia = new Materia();

            for (int i = 0; i < materia.LlenarComboBoxConsulta().Rows.Count; i++)
            {
                Combo_Materia.Items.Add(materia.LlenarComboBoxConsulta().Rows[i][1] + " - " + materia.LlenarComboBoxConsulta().Rows[i][6] + " " + materia.LlenarComboBoxConsulta().Rows[i][7] + " - " + materia.LlenarComboBoxConsulta().Rows[i][14]); //Agregarle el grupo al lado del nombre
            }

            //Llena los DataGridView

            try
            {
                Asincronica asincronica = new Asincronica();
                Dgv_Realizada.DataSource = asincronica.TraerRealizadasAlumno(Validacion.UsuarioActual);
                Dgv_Contestada.DataSource = asincronica.TraerContestadasAlumno(Validacion.UsuarioActual);
                Dgv_Recibida.DataSource = asincronica.TraerRecibidasAlumno(Validacion.UsuarioActual);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mostrar las consultas.\nPor favor intente nuevamente");
                Console.WriteLine(ex.ToString());
            }
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            //Crea Consulta y crea Asincronica
            Persona persona = new Persona();
            Materia materia = new Materia();
            Alumno alumno = new Alumno();
            try
            {
                int ciAlumno = Validacion.UsuarioActual;
                int ciProfesor = persona.BuscarPersona(Convert.ToInt32(materia.LlenarComboBoxConsulta().Rows[Combo_Materia.SelectedIndex]["cedula"])).GetCI();
                int idMateria = Convert.ToInt32(materia.LlenarComboBoxConsulta().Rows[Combo_Materia.SelectedIndex][0]);
                int idGrupo = alumno.BuscarAlumno(Validacion.UsuarioActual).GetIdGrupo();
                string estado = "Realizada";
                string consulta = Text_Consulta.Text;
                string respuesta = ".";

                if (!String.IsNullOrEmpty(ciAlumno.ToString()) && !String.IsNullOrEmpty(ciProfesor.ToString()) && !String.IsNullOrEmpty(idMateria.ToString()) && !String.IsNullOrEmpty(idGrupo.ToString()) && !String.IsNullOrEmpty(estado) && !String.IsNullOrEmpty(consulta) && consulta != "Redacta la consulta aquí" && !String.IsNullOrEmpty(respuesta))
                {
                    Console.WriteLine("no lo toma nulo o vacio");
                    Asincronica asincronica = new Asincronica();
                    asincronica.SetCiAlumno(ciAlumno);
                    asincronica.SetCiProfesor(ciProfesor);
                    asincronica.SetIdMateria(idMateria);
                    asincronica.SetIdGrupo(idGrupo);
                    asincronica.SetEstado(estado);
                    asincronica.SetConsulta(consulta);

                    if (asincronica.SubirConsulta(asincronica))
                    {
                        asincronica.SetIdConsulta(asincronica.ConseguirIdConsulta(Validacion.UsuarioActual));

                        if (asincronica.SubirAsincronica(asincronica))
                        {
                            DialogResult dialogResult = MessageBox.Show("Consulta enviada satisfactoriamente", "Consulta enviada", MessageBoxButtons.OK);
                            if(dialogResult == DialogResult.OK)
                            {
                                Dgv_Realizada.DataSource = asincronica.TraerRealizadasAlumno(Validacion.UsuarioActual);
                                Dgv_Contestada.DataSource = asincronica.TraerContestadasAlumno(Validacion.UsuarioActual);
                                Dgv_Recibida.DataSource = asincronica.TraerRecibidasAlumno(Validacion.UsuarioActual);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo procesar la operación");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al enviar la consulta asincrónica");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al enviar la consulta");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una consulta válida");
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
                Asincronica asincronica = new Asincronica();
                Dgv_Realizada.DataSource = asincronica.TraerRealizadasAlumno(Validacion.UsuarioActual);
                Dgv_Contestada.DataSource = asincronica.TraerContestadasAlumno(Validacion.UsuarioActual);
                Dgv_Recibida.DataSource = asincronica.TraerRecibidasAlumno(Validacion.UsuarioActual);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mostrar las consultas.\nPor favor intente nuevamente");
                Console.WriteLine(ex.ToString());
            }
        }

        private void Dgv_Realizada_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Doble click en el rojo
            // De repente no funciona ninguno de estos
            int index = Dgv_Realizada.CurrentRow.Index;
            IdConsulta = Convert.ToInt32(Dgv_Realizada.Rows[index].Cells[0].Value);
            VerConsultasForm ver = new VerConsultasForm(IdConsulta, Validacion.UsuarioActual);
            ver.ShowDialog();
        }

        private void Dgv_Contestada_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Doble click en el amarillo
            int index = Dgv_Contestada.CurrentRow.Index;
            IdConsulta = Convert.ToInt32(Dgv_Contestada.Rows[index].Cells[0].Value);
            VerConsultasForm ver = new VerConsultasForm(IdConsulta, Validacion.UsuarioActual);
            validacion.Update("UPDATE asincronica SET estado = 'Recibida' WHERE idAsincronica = " + IdConsulta + ";");
            ver.ShowDialog();
        }

        private void Dgv_Recibida_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Doble click en el verde
            int index = Dgv_Recibida.CurrentRow.Index;
            IdConsulta = Convert.ToInt32(Dgv_Recibida.Rows[index].Cells[0].Value);
            VerConsultasForm ver = new VerConsultasForm(IdConsulta, Validacion.UsuarioActual);
            ver.ShowDialog();
        }
    }
}
