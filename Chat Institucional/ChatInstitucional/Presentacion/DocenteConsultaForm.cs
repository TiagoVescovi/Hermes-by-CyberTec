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
    public partial class DocenteConsultaForm : Form
    {
        int IdConsulta = 0;
        public DocenteConsultaForm()
        {
            InitializeComponent();
        }

        private void ConsultaFormDocente_Load(object sender, EventArgs e)
        {
            // Llena los DataGrid

            RecargarConsultas();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            // Lo mismo q el Load

            RecargarConsultas();
        }

        private void Dgv_Realizada_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Doble click en el rojo
            int index = Dgv_Realizada.CurrentRow.Index;
            IdConsulta = Convert.ToInt32(Dgv_Realizada.Rows[index].Cells[0].Value);
            VerConsultasForm ver = new VerConsultasForm(IdConsulta, Validacion.UsuarioActual);
            ver.ShowDialog();
            RecargarConsultas();
        }

        private void Dgv_Contestada_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Doble click en el amarillo
            int index = Dgv_Contestada.CurrentRow.Index;
            IdConsulta = Convert.ToInt32(Dgv_Contestada.Rows[index].Cells[0].Value);
            VerConsultasForm ver = new VerConsultasForm(IdConsulta, Validacion.UsuarioActual);
            ver.ShowDialog();
            RecargarConsultas();
        }

        private void Dgv_Recibida_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Doble click en el verde
            int index = Dgv_Recibida.CurrentRow.Index;
            IdConsulta = Convert.ToInt32(Dgv_Recibida.Rows[index].Cells[0].Value);
            VerConsultasForm ver = new VerConsultasForm(IdConsulta, Validacion.UsuarioActual);
            ver.ShowDialog();
            RecargarConsultas();
        }

        private void RecargarConsultas()
        {
            try
            {
                Asincronica asincronica = new Asincronica();
                Dgv_Realizada.DataSource = asincronica.TraerRealizadasDocente(Validacion.UsuarioActual);
                Dgv_Contestada.DataSource = asincronica.TraerContestadasDocente(Validacion.UsuarioActual);
                Dgv_Recibida.DataSource = asincronica.TraerRecibidasDocente(Validacion.UsuarioActual);
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al mostrar las consultas.\nPor favor intente nuevamente");
            }
        }
    }
}
