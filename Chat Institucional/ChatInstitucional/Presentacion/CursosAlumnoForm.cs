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
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            // Crea un chat de esa materia si no existe
        }

        private void Dgv_Materias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Se activan los botones dependiendo de si hay o no un chat ya creado
        }
    }
}
