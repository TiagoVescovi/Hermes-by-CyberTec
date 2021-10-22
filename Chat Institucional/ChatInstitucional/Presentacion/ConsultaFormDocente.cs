using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatInstitucional.Presentacion
{
    public partial class ConsultaFormDocente : Form
    {
        public ConsultaFormDocente()
        {
            InitializeComponent();
        }

        private void ConsultaFormDocente_Load(object sender, EventArgs e)
        {
            // Llena los DataGrid
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            // Lo mismo q el Load
        }

        private void Dgv_Realizada_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Abre VerConsultaForm
        }
    }
}
