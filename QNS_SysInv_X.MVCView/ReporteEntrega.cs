using Microsoft.Reporting.WinForms;
using QNS_SysInv_X.MVCController;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QNS_SysInv_X.MVCView
{
    public partial class ReporteEntrega : Form
    {
        public List<Entrega> entregaLista = new List<Entrega>();
        public ReporteEntrega()
        {
            InitializeComponent();
        }

        private Usuarios user;

        public ReporteEntrega(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsu.Text = this.user.Usuario;
        }

        private void ReporteUsuarios_Load(object sender, EventArgs e)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("Parameter1", stsUsu.Text));
            this.reportViewer2.LocalReport.SetParameters(reportParameters);
            // this.reportViewer2.LocalReport.Refresh();
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DSEntrega", entregaLista));
            // TODO: This line of code loads data into the 'dS_QNS.Entrega' table. You can move, or remove it, as needed.
            this.reportViewer2.RefreshReport();
        }
        
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
