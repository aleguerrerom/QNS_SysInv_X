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

        private void UsuariosReport_Load(object sender, EventArgs e)
        {
           // reportViewer1.LocalReport.ReportPath = "C:/Users/Alejandro/Desktop/CNV_Inventario.MVC/CNV_Inventario.MVCView/ReportUsuario.rdlc";
            this.usuariosTableAdapter1.Fill(this.DSUsuarios.Usuarios);
            this.reportViewer1.RefreshReport();
        }

}
}
