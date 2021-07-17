using QNS_SysInv_X.MVCController;
using System;
using System.Windows.Forms;

namespace QNS_SysInv_X.MVCView
{
    public partial class ReporteVendedores : Form
    {
        public ReporteVendedores()
        {
            InitializeComponent();
        }

        private Usuarios user;

        public ReporteVendedores(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsu.Text = this.user.Usuario;
        }

        private void ReporteInventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QNS.Vendedores' table. You can move, or remove it, as needed.
            this.vendedoresTableAdapter.Fill(this.dS_QNS.Vendedores);
            this.reportViewer1.RefreshReport();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltro.SelectedIndex == 0)
                {
                    this.vendedoresTableAdapter.FillByCorreo(this.dS_QNS.Vendedores, txtFiltro.Text);
                }
                else if (cmbFiltro.SelectedIndex == 1)
                {
                    this.vendedoresTableAdapter.FillByNombre(this.dS_QNS.Vendedores, txtFiltro.Text);
                }
                else if (cmbFiltro.SelectedIndex == 1)
                {
                    this.vendedoresTableAdapter.FillCedula(this.dS_QNS.Vendedores, int.Parse(txtFiltro.Text));
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
            this.vendedoresTableAdapter.Fill(this.dS_QNS.Vendedores);

            this.reportViewer1.RefreshReport();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReporteVendedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QNS.Vendedores' table. You can move, or remove it, as needed.
            this.vendedoresTableAdapter.Fill(this.dS_QNS.Vendedores);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
