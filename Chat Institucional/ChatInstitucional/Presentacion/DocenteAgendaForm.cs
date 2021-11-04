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
    public partial class DocenteAgendaForm : Form
    {
        int idGrupo, idMateria;
        public DocenteAgendaForm()
        {
            InitializeComponent();
        }

        private void AgendaDocenteForm_Load(object sender, EventArgs e)
        {
            // Llena todos los combo boxes
            Orientacion orientacion = new Orientacion();

            for(int i = 0; i < orientacion.ListarOrientaciones().Rows.Count; i++)
            {
                Combo_Orientacion.Items.Add(orientacion.ListarOrientaciones().Rows[i][1]);
            }

            //Dgv_Horarios.Columns.Add("Lunes", "Lunes");
            //Dgv_Horarios.Columns.Add("Martes", "Martes");
            //Dgv_Horarios.Columns.Add("Miércoles", "Miércoles");
            //Dgv_Horarios.Columns.Add("Jueves", "Jueves");
            //Dgv_Horarios.Columns.Add("Viernes", "Viernes");
            //Dgv_Horarios.Columns.Add("Sábado", "Sábado");
            //Dgv_Horarios.Columns.Add("Domingo", "Domingo");

            LlenarDgvHorarios();
            LlenarDgvMaterias();

            for (int i = 00; i < 24; i++)
            {
                if (i < 10)
                {
                    Combo_HoraIni_HH.Items.Add("0" + i);
                    Combo_HoraFin_HH.Items.Add("0" + i);
                }
                else
                {
                    Combo_HoraIni_HH.Items.Add(i);
                    Combo_HoraFin_HH.Items.Add(i);
                }
            }

            for (int i = 00; i < 60; i++)
            {
                if (i < 10)
                {
                    Combo_HoraIni_MM.Items.Add("0" + i);
                    Combo_HoraFin_MM.Items.Add("0" + i);
                }
                else
                {
                    Combo_HoraIni_MM.Items.Add(i);
                    Combo_HoraFin_MM.Items.Add(i);
                }
            }
        }

        private void Combo_Orientacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cambian los grupos cada vez q se cambia la orientacion
            Combo_Grupos.Items.Clear();
            Grupo grupo = new Grupo();
            Orientacion orientacion = new Orientacion();
            for (int i = 0; i < grupo.GruposPorOrientacion(Convert.ToInt32(orientacion.ListarOrientaciones().Rows[Combo_Orientacion.SelectedIndex][0])).Rows.Count; i++)
            {
                Combo_Grupos.Items.Add(grupo.GruposPorOrientacion(Convert.ToInt32(orientacion.ListarOrientaciones().Rows[Combo_Orientacion.SelectedIndex][0])).Rows[i][1].ToString());
            }

            Combo_Grupos.Enabled = true;
        }


        private void Combo_Grupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combo_Materias.Items.Clear();
            Materia materia = new Materia();
            Grupo grupo = new Grupo();
            Orientacion orientacion = new Orientacion();
            idGrupo = Convert.ToInt32(grupo.GruposPorOrientacion(Convert.ToInt32(orientacion.ListarOrientaciones().Rows[Combo_Orientacion.SelectedIndex][0])).Rows[0][0]);
            for (int i = 0; i < materia.ListarSoloMaterias().Rows.Count; i++)
            {
                Combo_Materias.Items.Add(materia.ListarSoloMaterias().Rows[i][1].ToString());
            }

            Combo_Materias.Enabled = true;
        }

        private void Combo_Materias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilita Btn_Agregar_Materia
            Btn_Agregar_Materia.Enabled = true;
        }

        private void Combo_Dias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilita los horarios

            LlenarDgvHorarios();

            Combo_HoraIni_HH.Enabled = true;
            Combo_HoraIni_MM.Enabled = true;
            Combo_HoraFin_HH.Enabled = true;
            Combo_HoraFin_MM.Enabled = true;
        }

        private void Combo_HoraFin_MM_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilita Btn_Agregar_Horario
            Btn_Agregar_Horario.Enabled = true;
        }

        private void Btn_Agregar_Horario_Click(object sender, EventArgs e)
        {
            // Agrega en horario
            Horario horario = new Horario();
            
            if(!String.IsNullOrEmpty(Combo_Dias.SelectedItem.ToString()) && !String.IsNullOrEmpty(Combo_HoraIni_HH.SelectedItem.ToString()) && !String.IsNullOrEmpty(Combo_HoraIni_MM.SelectedItem.ToString()) && !String.IsNullOrEmpty(Combo_HoraFin_HH.SelectedItem.ToString()) && !String.IsNullOrEmpty(Combo_HoraFin_MM.SelectedItem.ToString()))
            {
                horario.SetCiProfesor(Validacion.UsuarioActual);
                horario.SetHoraIni(Combo_HoraIni_HH.SelectedItem.ToString() + ":" + Combo_HoraIni_MM.SelectedItem.ToString());
                horario.SetHoraFin(Combo_HoraFin_HH.SelectedItem.ToString() + ":" + Combo_HoraFin_MM.SelectedItem.ToString());
                horario.SetDia(Combo_Dias.SelectedItem.ToString());

                if (horario.AgregarHorario(horario))
                {
                    DialogResult dialogResult = MessageBox.Show("Horario añadido exitosamente");
                    if(dialogResult == DialogResult.OK)
                    {
                        LlenarDgvHorarios();
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo añadir el horario");
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
        }

        private void Btn_Eliminar_Horario_Click(object sender, EventArgs e)
        {
            // Elimina el horario seleccionado del dia seleccionado
            Horario horario = new Horario();

            try
            {
                horario.SetCiProfesor(Validacion.UsuarioActual);
                horario.SetHoraIni(horario.HorariosProfe(Validacion.UsuarioActual).Rows[Dgv_Horarios.CurrentRow.Index][1].ToString());
                horario.SetHoraFin(horario.HorariosProfe(Validacion.UsuarioActual).Rows[Dgv_Horarios.CurrentRow.Index][2].ToString());
                horario.SetDia(horario.HorariosProfe(Validacion.UsuarioActual).Rows[Dgv_Horarios.CurrentRow.Index][0].ToString());

                horario.EliminarHorario(horario);
                LlenarDgvHorarios();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void LlenarDgvHorarios()
        {
            // Las columnas van a ser los dias
            // Ver como hacerlo y que quede bien xd
            Horario horario = new Horario();
            try
            {
                Dgv_Horarios.DataSource = horario.HorariosPorDia(Validacion.UsuarioActual, Combo_Dias.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void LlenarHorarios()
        {
            for (int i = 00; i < 24; i++)
            {
                if (i < 10)
                {
                    Combo_HoraIni_HH.Items.Add("0" + i);
                    Combo_HoraFin_HH.Items.Add("0" + i);
                }
                else
                {
                    Combo_HoraIni_HH.Items.Add(i);
                    Combo_HoraFin_HH.Items.Add(i);
                }
            }

            for (int i = 00; i < 60; i++)
            {
                if (i < 10)
                {
                    Combo_HoraIni_MM.Items.Add("0" + i);
                    Combo_HoraFin_MM.Items.Add("0" + i);
                }
                else
                {
                    Combo_HoraIni_MM.Items.Add(i);
                    Combo_HoraFin_MM.Items.Add(i);
                }
            }
        }

        private void Btn_Agregar_Materia_Click(object sender, EventArgs e)
        {
            // Agrega la materia si no la da
            if (!String.IsNullOrEmpty(Combo_Orientacion.SelectedItem.ToString()) && !String.IsNullOrEmpty(Combo_Grupos.SelectedItem.ToString()) && !String.IsNullOrEmpty(Combo_Materias.SelectedItem.ToString()))
            {
                Materia materia = new Materia();
                Grupo grupo = new Grupo();
                Orientacion orientacion = new Orientacion();
                if (materia.AgregarEnsenia(Convert.ToInt32(materia.ListarSoloMaterias().Rows[Combo_Materias.SelectedIndex][0]), Validacion.UsuarioActual, Convert.ToInt32(grupo.GruposPorOrientacion(Convert.ToInt32(orientacion.ListarOrientaciones().Rows[Combo_Orientacion.SelectedIndex][0])).Rows[Combo_Grupos.SelectedIndex][0])))
                {
                    DialogResult dialogResult = MessageBox.Show("Materia agregada exitosamente");
                    if (dialogResult == DialogResult.OK)
                    {
                        LlenarDgvMaterias();
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrió un error y no se pudo agregar la materia");
                }
            }
            else
            {
                MessageBox.Show("Ocurrió un error al tomar los datos.\nAsegúrese de que sean válidos");
            }
        }

        private void Btn_Eliminar_Materia_Click(object sender, EventArgs e)
        {
            // Elimina la materia seleccionada
            DialogResult dialogResult = MessageBox.Show("¿Está segur@ de que quiere eliminar el horario?", "Eliminar horario", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                Materia materia = new Materia();
                if (materia.EliminarEnsenia(Convert.ToInt32(materia.ListarEnsenia(Validacion.UsuarioActual).Rows[Dgv_Materias.CurrentRow.Index][0]), Validacion.UsuarioActual, Convert.ToInt32(materia.ListarEnsenia(Validacion.UsuarioActual).Rows[Dgv_Materias.CurrentRow.Index][2])))
                {
                    MessageBox.Show("Se eliminó la materia");
                    LlenarDgvMaterias();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la materia");
                    LlenarDgvMaterias();
                }
            }
        }

        private void Btn_Refresh_Horario_Click(object sender, EventArgs e)
        {
            LlenarDgvHorarios();
        }

        private void Btn_Refresh_Materia_Click(object sender, EventArgs e)
        {
            LlenarDgvMaterias();
        }

        private void Dgv_Materias_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Eliminar_Materia.Enabled = true;
        }

        private void Dgv_Horarios_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Eliminar_Horario.Enabled = true;
        }

        private void LlenarDgvMaterias()
        {
            // Enseña
            Materia materia = new Materia();
            Dgv_Materias.DataSource = materia.LlenarDgvEnsenia(Validacion.UsuarioActual);
        }
    }
}
