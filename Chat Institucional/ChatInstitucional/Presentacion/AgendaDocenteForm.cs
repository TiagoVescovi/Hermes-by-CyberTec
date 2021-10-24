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
    public partial class AgendaDocenteForm : Form
    {
        int idGrupo, idMateria;
        public AgendaDocenteForm()
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

            LlenarDgvHorarios(Validacion.UsuarioActual);
        }

        private void Combo_Orientacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cambian los grupos cada vez q se cambia la orientacion
            Grupo grupo = new Grupo();
            Orientacion orientacion = new Orientacion();
            for (int i = 0; i < grupo.GruposPorOrientacion(Convert.ToInt32(orientacion.ListarOrientaciones().Rows[Combo_Orientacion.SelectedIndex][0])).Rows.Count; i++)
            {
                Combo_Grupos.Items.Add(grupo.GruposPorOrientacion(Convert.ToInt32(orientacion.ListarOrientaciones().Rows[Combo_Orientacion.SelectedIndex][0])).Rows[i][1].ToString());
            }

            Combo_Grupos.Enabled = true;

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


        private void Combo_Grupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cambian las materias cada vez q se cambia el grupo
            Materia materia = new Materia();
            Grupo grupo = new Grupo();
            Orientacion orientacion = new Orientacion();
            idGrupo = Convert.ToInt32(grupo.GruposPorOrientacion(Convert.ToInt32(orientacion.ListarOrientaciones().Rows[Combo_Orientacion.SelectedIndex][0])).Rows[0][0]);
            for (int i = 0; i < materia.MateriasPorGrupo(idGrupo).Rows.Count; i++)
            {
                Combo_Materias.Items.Add(materia.MateriasPorGrupo(idGrupo).Rows[i][1].ToString());
            }

            Combo_Materias.Enabled = true;
        }


        private void Combo_Materias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilita dias
            Combo_Dias.Enabled = true;
        }

        private void Combo_Dias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilita los horarios
            Combo_HoraIni_HH.Enabled = true;
            Combo_HoraIni_MM.Enabled = true;
            Combo_HoraFin_HH.Enabled = true;
            Combo_HoraFin_MM.Enabled = true;
        }

        private void Combo_HoraFin_MM_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilita agregar
            Btn_Agregar.Enabled = true;
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            // Agrega en enseña con cedula actual
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            // Elimina el horario seleccionado del dia seleccionado
        }

        public void LlenarDgvHorarios(int ci)
        {
            // Las columnas van a ser los dias
            // Ver como hacerlo y que quede bien xd
        }
    }
}
