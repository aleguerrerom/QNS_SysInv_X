using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using QNS_SysInv_X.MVCController;
using System;
using System.Collections.Generic;
using System.Data;
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
            // TODO: This line of code loads data into the 'dS_QNS2.Clientes' table. You can move, or remove it, as needed.
            this.ClientesTableAdapter.Fill(this.DS_QNS.Clientes);
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("Parameter1", stsUsu.Text));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.LocalReport.Refresh();
            //this.reportViewer1.RefreshReport();
            // TODO: This line of code loads data into the 'dS_QNS.Clientes' table. You can move, or remove it, as needed.
            this.ClientesTableAdapter.Fill(this.DS_QNS.Clientes);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbFiltrar.SelectedIndex == 0)
            {
                this.ClientesTableAdapter.FillByCedula(this.DS_QNS.Clientes, int.Parse(txtFiltro.Text));
            }
            else if (cmbFiltrar.SelectedIndex == 1)
            {
                this.ClientesTableAdapter.FillByNombre(this.DS_QNS.Clientes, txtFiltro.Text);
            }
            reportViewer1.RefreshReport();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.ClientesTableAdapter.Fill(this.DS_QNS.Clientes);
            this.reportViewer1.RefreshReport();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
