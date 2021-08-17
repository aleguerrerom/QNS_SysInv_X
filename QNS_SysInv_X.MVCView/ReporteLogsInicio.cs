using Microsoft.Reporting.WinForms;
using QNS_SysInv_X.MVCController;
using System;
using System.Windows.Forms;

namespace QNS_SysInv_X.MVCView
{
    public partial class ReporteLogsInicio : Form
    {
        public ReporteLogsInicio()
        {
            InitializeComponent();
        }

        private Usuarios user;

        public ReporteLogsInicio(Usuarios usuario)
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
            // TODO: This line of code loads data into the 'dS_QNS.AuditLog' table. You can move, or remove it, as needed.
            this.auditLogTableAdapter.Fill(this.dS_QNS.AuditLog);
            // TODO: This line of code loads data into the 'dS_QNS.Inventario' table. You can move, or remove it, as needed.
            this.reportViewer1.RefreshReport();
            cmbFiltro.SelectedIndex = 1;
            dtpFecha.Value = DateTime.Today;
            dtpFechaFinal.Value = DateTime.Today;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedIndex == 0)
            {
                this.auditLogTableAdapter.FillByUsuario(this.dS_QNS.AuditLog, txtFiltro.Text);
            }
            else if (cmbFiltro.SelectedIndex == 1)
            {
                    if (dtpFecha.Value > dtpFechaFinal.Value)
                    {
                        MessageBox.Show("La fecha de inicio no puede ser mayor a la final", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        this.auditLogTableAdapter.FillByfechaInicio(this.dS_QNS.AuditLog, dtpFecha.Value, dtpFechaFinal.Value);
            }
            else if (cmbFiltro.SelectedIndex == 2)
            {
                if (dtpFecha.Value > dtpFechaFinal.Value)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor a la final", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    this.auditLogTableAdapter.FillByfechaSalida(this.dS_QNS.AuditLog, dtpFecha.Value, dtpFechaFinal.Value);
            }
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.auditLogTableAdapter.Fill(this.dS_QNS.AuditLog);
            //txtFiltro.Visible = true;
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
                dtpFechaFinal.Visible = false;
                lblFechaInicio.Visible = false;
                lblFechaFinal.Visible = false;
            }
            else if (cmbFiltro.SelectedIndex == 1 || cmbFiltro.SelectedIndex == 2)
            {
                dtpFecha.Visible = true;
                txtFiltro.Visible = false;
                dtpFecha.Visible = true;
                dtpFechaFinal.Visible = true;
                lblFechaInicio.Visible = true;
                lblFechaFinal.Visible = true;
            }
        }
    }
}
