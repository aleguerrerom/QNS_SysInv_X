using Microsoft.Reporting.WinForms;
using QNS_SysInv_X.MVCController;
using System;
using System.Windows.Forms;

namespace QNS_SysInv_X.MVCView
{
    public partial class ReporteMovimientos : Form
    {
        public ReporteMovimientos()
        {
            InitializeComponent();
        }
        private Usuarios user;

        public ReporteMovimientos(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsu.Text = this.user.Usuario;
        }

        private void ReporteInventario_Load(object sender, EventArgs e)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("Parameter1", stsUsu.Text));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.LocalReport.Refresh();
            // TODO: This line of code loads data into the 'dS_QNS.MovimientosLog' table. You can move, or remove it, as needed.
            this.movimientosLogTableAdapter.Fill(this.dS_QNS.MovimientosLog);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltro.SelectedIndex == 0)
                {
                    this.movimientosLogTableAdapter.FillByUsuario(this.dS_QNS.MovimientosLog, txtFiltro.Text);
                }
                else if (cmbFiltro.SelectedIndex == 1)
                {
                    this.movimientosLogTableAdapter.FillByFecha(this.dS_QNS.MovimientosLog, dtpFecha.Value);
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
            this.movimientosLogTableAdapter.Fill(this.dS_QNS.MovimientosLog);

            this.reportViewer1.RefreshReport();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedIndex == 0)
            {
                txtFiltro.Visible = true;
                dtpFecha.Visible = false;

            }
            else if (cmbFiltro.SelectedIndex == 1)
            {
                dtpFecha.Visible = true;
                txtFiltro.Visible = false;

            }
        }
    }
}
