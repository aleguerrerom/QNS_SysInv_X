using Microsoft.Reporting.WinForms;
using QNS_SysInv_X.MVCController;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QNS_SysInv_X.MVCView
{
    public partial class ReporteInventario : Form
    {
        public ReporteInventario()
        {
            InitializeComponent();
        }

        static Regex validate_number = RegexExpression.number_validation();

        private Usuarios user;

        public ReporteInventario(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsu.Text = this.user.Usuario;
        }
        private void ReporteInventario_Load(object sender, EventArgs e)
        {
            cmbFiltro.SelectedIndex = 0;
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("Parameter1", stsUsu.Text));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.LocalReport.Refresh();
            // TODO: This line of code loads data into the 'dS_QNS.Inventario' table. You can move, or remove it, as needed.
            this.inventarioTableAdapter.Fill(this.dS_QNS.Inventario);

            this.reportViewer1.RefreshReport();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltro.SelectedIndex == 0)
                {
                     if (validate_number.IsMatch(txtFiltro.Text) != true)
                    {
                        MessageBox.Show("El campo de busqueda solo permite números", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtFiltro.Clear();
                        return;
                    }
                     else
                    this.inventarioTableAdapter.FillBy(this.dS_QNS.Inventario, int.Parse(txtFiltro.Text));
                }
                else if (cmbFiltro.SelectedIndex == 1)
                {
                    this.inventarioTableAdapter.FillBy1(this.dS_QNS.Inventario,txtFiltro.Text);
                }
                else if (cmbFiltro.SelectedIndex == 2)
                {
                    this.inventarioTableAdapter.FillByEstado(this.dS_QNS.Inventario, txtFiltro.Text);
                }
                else if (cmbFiltro.SelectedIndex == 3)
                {
                    this.inventarioTableAdapter.FillByModelo(this.dS_QNS.Inventario, txtFiltro.Text);
                }
                else if (cmbFiltro.SelectedIndex == 4)
                {
                    this.inventarioTableAdapter.FillBySN(this.dS_QNS.Inventario, txtFiltro.Text);
                }
                else if (cmbFiltro.SelectedIndex == 5)
                {
                    this.inventarioTableAdapter.FillByTipo(this.dS_QNS.Inventario, txtFiltro.Text);
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
            this.inventarioTableAdapter.Fill(this.dS_QNS.Inventario);
            this.reportViewer1.RefreshReport();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
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
