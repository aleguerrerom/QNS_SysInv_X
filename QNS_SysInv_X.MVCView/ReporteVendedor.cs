using Microsoft.Reporting.WinForms;
using QNS_SysInv_X.MVCController;
using System;
using System.Windows.Forms;

namespace QNS_SysInv_X.MVCView
{
    public partial class ReporteVendedor: Form
    {
        public ReporteVendedor()
        {
            InitializeComponent();
        }

        private Usuarios user;

        public ReporteVendedor(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsu.Text = this.user.Usuario;
        }

        private void ReporteInventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QNS.Vendedores' table. You can move, or remove it, as needed.
            this.vendedoresTableAdapter1.Fill(this.dS_QNS.Vendedores);
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("Parameter1", stsUsu.Text));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.LocalReport.Refresh();
            // TODO: This line of code loads data into the 'dS_QNS.Oportunidades' table. You can move, or remove it, as needed.
            this.vendedoresTableAdapter1.Fill(this.dS_QNS.Vendedores);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbFiltro.SelectedIndex == 0)
                {
                    this.vendedoresTableAdapter1.FillCedula(this.dS_QNS.Vendedores, int.Parse(txtFiltro.Text));
                }
                else if (cmbFiltro.SelectedIndex == 1)
                {
                    this.vendedoresTableAdapter1.FillByNombre(this.dS_QNS.Vendedores, txtFiltro.Text);
                }
                else if (cmbFiltro.SelectedIndex == 2)
                {
                    this.vendedoresTableAdapter1.FillByCorreo(this.dS_QNS.Vendedores, txtFiltro.Text);
                }
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.vendedoresTableAdapter1.Fill(this.dS_QNS.Vendedores);

            this.reportViewer1.RefreshReport();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
