using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QNS_SysInv_X.MVCView
{
    public partial class ReporteInventario : Form
    {
        public ReporteInventario()
        {
            InitializeComponent();
        }

        private void ReporteInventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QNS.Inventario' table. You can move, or remove it, as needed.
            this.inventarioTableAdapter.Fill(this.dS_QNS.Inventario);

            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
