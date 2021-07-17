using QNS_SysInv_X.MVCController;
using System;
using System.Windows.Forms;

namespace QNS_SysInv_X.MVCView
{
    public partial class ReporteInventario : Form
    {
        public ReporteInventario()
        {
            InitializeComponent();
        }

        private Usuarios user;

        public ReporteInventario(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsu.Text = this.user.Usuario;
        }
        private void ReporteInventario_Load(object sender, EventArgs e)
        {
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
    }
}
