using Microsoft.Reporting.WinForms;
using QNS_SysInv_X.MVCController;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QNS_SysInv_X.MVCView
{
    public partial class RerporteClientes : Form
    {
        private Usuarios user;
        
        public List<Clientes> clientes = new List<Clientes>();
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
            
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSClientesLocal", clientes));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSClientes", clientes));
           // ReportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rd1 = new ReportDataSource("DSClientesLocal", clientes);
            ReportDataSource rd2 = new ReportDataSource("DSClientes", clientes);
            reportViewer1.LocalReport.DataSources.Add(rd1);
            reportViewer1.LocalReport.DataSources.Add(rd2);
            
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
            //reportViewer1.LocalReport.ReportEmbeddedResource = "path_to_the_embedded_report";
            //ReportParameter[] anyPara = new ReportParameter[1];
            //anyPara[0] = new ReportParameter("anyPara", "anyPara", false);
            //reportViewer1.LocalReport.SetParameters(anyPara);
            //SetReportParameters();
            //string param0 = "admin";
            //ReportParameter anyPara1 = new ReportParameter("anyPara", param0);
            //this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]{ anyPara1 });
            reportViewer1.RefreshReport();
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

        private void stsUsu_Click(object sender, EventArgs e)
        {

        }
    }
}
