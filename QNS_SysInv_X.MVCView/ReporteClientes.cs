using Microsoft.Reporting.WinForms;
using QNS_SysInv_X.MVCController;
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
    public partial class RerporteClientes : Form
    {
        private Usuarios user;

        public RerporteClientes()
        {
            InitializeComponent();
        }
        public RerporteClientes(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsu.Text = this.user.Usuario;
        }

        private void ReporteUsuarios_Load(object sender, EventArgs e)
        {
            //TODO: esta línea de código carga datos en la tabla 'DataSet_ReporteInventarios.SPReporte_inventarios_totales_generales' Puede moverla o quitarla según sea necesario.
            //this.SPReporte_inventarios_totales_generalesTableAdapter.Fill(this.DataSet_ReporteInventarios.SPReporte_inventarios_totales_generales);
            //TODO: esta línea de código carga datos en la tabla 'DataSet_ReporteInventarios.SPReporteIventarios' Puede moverla o quitarla según sea necesario.
            //this.SPReporteIventariosTableAdapter.Fill(this.DataSet_ReporteInventarios.SPReporteIventarios);
           
            //this.reportViewer1.RefreshReport();
            // TODO: This line of code loads data into the 'dS_QNS.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.dS_QNS.Clientes);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbFiltrar.SelectedIndex == 0)
            {
                this.clientesTableAdapter.FillByCedula(this.dS_QNS.Clientes, int.Parse(txtFiltro.Text));
            }
            else if (cmbFiltrar.SelectedIndex == 1)
            {
                this.clientesTableAdapter.FillByNombre(this.dS_QNS.Clientes, txtFiltro.Text);
            }
            reportViewer1.LocalReport.ReportEmbeddedResource = "path_to_the_embedded_report";
            ReportParameter[] anyPara = new ReportParameter[1];
            anyPara[0] = new ReportParameter("anyPara", "anyPara", false);
            reportViewer1.LocalReport.SetParameters(anyPara);
            SetReportParameters();
            //string param0 = "admin";
            //ReportParameter anyPara1 = new ReportParameter("anyPara", param0);
            //this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]{ anyPara1 });
            reportViewer1.RefreshReport();
        }

        private void SetReportParameters()
        {
            ReportParameter p = new
               ReportParameter("AnyPara", stsStrip.ToString());
            this.reportViewer1.ServerReport.SetParameters(new ReportParameter[] { p });
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.dS_QNS.Clientes);
            this.reportViewer1.RefreshReport();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
