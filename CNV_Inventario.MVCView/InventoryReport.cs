using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNV_Inventario.MVCView
{
    public partial class InventoryReport : Form
    {
        public InventoryReport()
        {
            InitializeComponent();
        }

        private void InventoryReport_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
            // reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.ReportPath = "C:/Users/Alejandro/Desktop/CNV_Inventario.MVC/CNV_Inventario.MVCView/ReportUsuario.rdlc";
         //   this.inventarioTableAdapter1.Fill(this.dS_QNS1.Usuarios);
            this.reportViewer1.RefreshReport();
        }
    }
}
