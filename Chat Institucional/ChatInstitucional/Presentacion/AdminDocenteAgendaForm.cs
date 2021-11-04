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
    public partial class AdminDocenteAgendaForm : Form
    {
        int CI, idGrupo;
        public AdminDocenteAgendaForm(int ci)
        {
            InitializeComponent();

            CI = ci;
        }

        private void AdminDocenteMateriasForm_Load(object sender, EventArgs e)
        {
            Orientacion orientacion = new Orientacion();

            for (int i = 0; i < orientacion.ListarOrientaciones().Rows.Count; i++)
            {
                Combo_Orientacion.Items.Add(orientacion.ListarOrientaciones().Rows[i][1]);
            }
        }

        private void LlenarDgvMaterias()
        {
            // Enseña
            Materia materia = new Materia();
            Dgv_Materias.DataSource = materia.LlenarDgvEnsenia(CI);
        }

        private void Btn_Agregar_Materia_Click(object sender, EventArgs e)
        {
            // Agrega la materia si no la da
            try
            {
                if (!String.IsNullOrEmpty(Combo_Orientacion.SelectedItem.ToString()) && !String.IsNullOrEmpty(Combo_Grupos.SelectedItem.ToString()) && !String.IsNullOrEmpty(Combo_Materias.SelectedItem.ToString()))
                {
                    Materia materia = new Materia();
                    Grupo grupo = new Grupo();
                    Orientacion orientacion = new Orientacion();
                    if (materia.AgregarEnsenia(Convert.ToInt32(materia.ListarSoloMaterias().Rows[Combo_Materias.SelectedIndex][0]), CI, Convert.ToInt32(grupo.GruposPorOrientacion(Convert.ToInt32(orientacion.ListarOrientaciones().Rows[Combo_Orientacion.SelectedIndex][0])).Rows[Combo_Grupos.SelectedIndex][0])))
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        private void Combo_Grupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Materia materia = new Materia();
            for (int i = 0; i < materia.ListarSoloMaterias().Rows.Count; i++)
            {
                Combo_Materias.Items.Add(materia.ListarSoloMaterias().Rows[i][1].ToString());
            }

            Combo_Materias.Enabled = true;
        }

        private void Combo_Materias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_Agregar_Materia.Enabled = true;
        }

        private void Btn_Eliminar_Materia_Click(object sender, EventArgs e)
        {
            Materia materia = new Materia();
            if (materia.EliminarEnsenia(Convert.ToInt32(materia.ListarEnsenia(CI).Rows[Dgv_Materias.CurrentRow.Index][0]), CI, Convert.ToInt32(materia.ListarEnsenia(CI).Rows[Dgv_Materias.CurrentRow.Index][2])))
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

        private void Dgv_Materias_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Eliminar_Materia.Enabled = true;
        }

        private void Btn_Refresh_Materia_Click(object sender, EventArgs e)
        {
            LlenarDgvMaterias();
        }

        private void Combo_Dias_SelectedValueChanged(object sender, EventArgs e)
        {
            Horario horario = new Horario();
            Dgv_Horaios.DataSource = horario.HorariosPorDia(CI, Combo_Dias.SelectedItem.ToString());
        }

        private void Btn_Refresh_Horario_Click(object sender, EventArgs e)
        {
            try
            {
                Horario horario = new Horario();
                Dgv_Horaios.DataSource = horario.HorariosPorDia(CI, Combo_Dias.SelectedItem.ToString());
            }
            catch
            {
                return;
            }
        }

        private void Combo_Orientacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combo_Grupos.Items.Clear();
            Grupo grupo = new Grupo();
            Orientacion orientacion = new Orientacion();
            Combo_Grupos.DataSource = grupo.GruposPorOrientacion(Convert.ToInt32(orientacion.ListarOrientaciones().Rows[Combo_Orientacion.SelectedIndex][0])).Columns[1];

            for(int i = 0; i < Combo_Grupos.Items.Count; i++)
            {
                if(Combo_Grupos.Items[i] != grupo.GruposPorOrientacion(Convert.ToInt32(orientacion.ListarOrientaciones().Rows[Combo_Orientacion.SelectedIndex][0])).Columns[1])
                {
                    Combo_Grupos.Items.Remove(Combo_Grupos.Items[1]);
                }
            }
            Combo_Grupos.Enabled = true;
        }
    }
}
