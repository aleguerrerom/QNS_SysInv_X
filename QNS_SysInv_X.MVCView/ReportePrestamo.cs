using Microsoft.Reporting.WinForms;
using QNS_SysInv_X.MVCController;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QNS_SysInv_X.MVCView
{
    public partial class ReportePrestamo : Form
    {
        public List<Prestamos> prestamoLista = new List<Prestamos>();
        public ReportePrestamo()
        {
            InitializeComponent();
        }

        private Usuarios user;

        public ReportePrestamo(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsu.Text = this.user.Usuario;
        }

        private void ReporteUsuarios_Load(object sender, EventArgs e)
        {
            //this.prestamoTableAdapter.Fill(this.dS_QNS.Prestamo);
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("Parameter1", stsUsu.Text));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            // this.reportViewer2.LocalReport.Refresh();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSPrestamoLocal", prestamoLista));
            // TODO: This line of code loads data into the 'dS_QNS.Prestamo' table. You can move, or remove it, as needed.
        
           // this.reportViewer1.LocalReport.Refresh();
            // TODO: This line of code loads data into the 'dS_QNS.Prestamo' table. You can move, or remove it, as needed.
           // this.prestamoTableAdapter.Fill(dS_QNS.Prestamo);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            if (cmbFiltrar.SelectedIndex == 0)
            {
                this.prestamoTableAdapter.Fill(this.dS_QNS.Clientes, int.Parse(txtFiltro.Text));
            }
            else if (cmbFiltrar.SelectedIndex == 1)
            {
                this.clientesTableAdapter.FillByNombre(this.dS_QNS.Clientes, txtFiltro.Text);
            }
            this.reportViewer1.RefreshReport();*/
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
