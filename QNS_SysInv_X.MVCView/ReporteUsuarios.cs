using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QNS_SysInv_X.MVCView
{
    public partial class ReporteUsuarios : Form
    {
        public ReporteUsuarios()
        {
            InitializeComponent();
        }

        private void ReporteUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QNS.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.dS_QNS.Usuarios);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltro.SelectedIndex == 0)
                {
                    this.usuariosTableAdapter.FillBy(this.dS_QNS.Usuarios, txtFiltro.Text);
                }
                else if (cmbFiltro.SelectedIndex == 1)
                {
                    this.usuariosTableAdapter.FillByApellido(this.dS_QNS.Usuarios, txtFiltro.Text);
                }
                else if (cmbFiltro.SelectedIndex == 2)
                {
                    this.usuariosTableAdapter.FillByCorreo(this.dS_QNS.Usuarios, txtFiltro.Text);
                }
                else if (cmbFiltro.SelectedIndex == 3)
                {
                    this.usuariosTableAdapter.FillByNombre(this.dS_QNS.Usuarios, txtFiltro.Text);
                }
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.Fill(this.dS_QNS.Usuarios);

            this.reportViewer1.RefreshReport();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
