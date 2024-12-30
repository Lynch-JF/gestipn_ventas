using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_ventas
{
    public partial class ReporteInventario : Form
    {
        public ReporteInventario()
        {
            InitializeComponent();
        }

        private void ReporteInventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'respuestoDataSet5.Productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.respuestoDataSet5.Productos);

            this.reportViewer1.RefreshReport();
        }
    }
}
