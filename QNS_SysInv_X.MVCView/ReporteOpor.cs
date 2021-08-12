using Microsoft.Reporting.WinForms;
using QNS_SysInv_X.MVCController;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QNS_SysInv_X.MVCView
{
    public partial class ReporteOpor : Form
    {
        public ReporteOpor()
        {
            InitializeComponent();
        }

        private Usuarios user;
        static Regex validate_number = RegexExpression.number_validation();

        public ReporteOpor(Usuarios usuario)
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
            // TODO: This line of code loads data into the 'dS_QNS.Oportunidades' table. You can move, or remove it, as needed.
            this.oportunidadesTableAdapter.Fill(this.dS_QNS.Oportunidades);
            this.reportViewer1.RefreshReport();
            cmbFiltro.SelectedIndex = 1;
            dtpEnd.Value = DateTime.Today;
            dtpFechaInicio.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltro.SelectedIndex == 0)
                {
                    if (validate_number.IsMatch(txtFiltro.Text) != true)
                    {
                        MessageBox.Show("El campo de busqueda solo permite numeros", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtFiltro.Clear();
                        return;
                    }
                    else
                        this.oportunidadesTableAdapter.FillBy(this.dS_QNS.Oportunidades, int.Parse(txtFiltro.Text));
                }
                if (cmbFiltro.SelectedIndex == 2)
                {
                    this.oportunidadesTableAdapter.FillByNombre(this.dS_QNS.Oportunidades, txtFiltro.Text);
                }
                if (cmbFiltro.SelectedIndex == 3)
                {
                    this.oportunidadesTableAdapter.FillByMarca(this.dS_QNS.Oportunidades, txtFiltro.Text);
                }
                else if (cmbFiltro.SelectedIndex == 1)
                {
                    if (dtpFechaInicio.Value > dtpEnd.Value)
                    {
                        MessageBox.Show("La fecha de inicio no puede ser mayor a la final", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    this.oportunidadesTableAdapter.FillByFecha(this.dS_QNS.Oportunidades, dtpFechaInicio.Value,dtpEnd.Value);
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
            this.oportunidadesTableAdapter.Fill(this.dS_QNS.Oportunidades);

            this.reportViewer1.RefreshReport();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedIndex == 0 || cmbFiltro.SelectedIndex == 2 || cmbFiltro.SelectedIndex == 3)
            {
                txtFiltro.Visible = true;
                dtpFechaInicio.Visible = false;
                dtpEnd.Visible = false;
                lblFechaInicio.Visible = false ;
                lblFechaFinal.Visible = false;
            }
            else if (cmbFiltro.SelectedIndex == 1)
            {
                dtpFechaInicio.Visible = true;
                txtFiltro.Visible = false;
                dtpEnd.Visible = true;
                lblFechaInicio.Visible = true;
                lblFechaFinal.Visible = true;
            }
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }
    }
}
