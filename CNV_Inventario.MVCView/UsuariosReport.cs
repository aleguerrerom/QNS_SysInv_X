using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CNV_Inventario.MVCView
{
    public partial class UsuariosReport : Form
    {
        public UsuariosReport()
        {
            InitializeComponent();
        }


        private void UsuariosReport_Load_1(object sender, EventArgs e)
        {
            //  reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.RefreshReport();
            reportViewer1.LocalReport.ReportPath = "C:/Users/Alejandro/Desktop/CNV_Inventario.MVC/CNV_Inventario.MVCView/ReportUser.rdlc";
           this.usuariosTableAdapter.Fill(this.DS_QNS.Usuarios);
           this.reportViewer1.RefreshReport();
        }
    }
}
