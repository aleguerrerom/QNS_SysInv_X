using Microsoft.Reporting.WinForms;
using QNS_SysInv_X.MVCController;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QNS_SysInv_X.MVCView
{
    public partial class ReporteEntrega : Form
    {
        public List<Entrega> entrega = new List<Entrega>();
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
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DSEntrega",entrega));
            // TODO: This line of code loads data into the 'dS_QNS.Entrega' table. You can move, or remove it, as needed.
            this.entregaTableAdapter.Fill(this.dS_QNS.Entrega);
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
        
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

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
