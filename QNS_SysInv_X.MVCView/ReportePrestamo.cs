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
    public partial class ReportePrestamo : Form
    {
        public ReportePrestamo()
        {
            InitializeComponent();
        }

        private void ReporteUsuarios_Load(object sender, EventArgs e)
        {

            //TODO: esta línea de código carga datos en la tabla 'DataSet_ReporteInventarios.SPReporte_inventarios_totales_generales' Puede moverla o quitarla según sea necesario.
            //this.SPReporte_inventarios_totales_generalesTableAdapter.Fill(this.DataSet_ReporteInventarios.SPReporte_inventarios_totales_generales);
            //TODO: esta línea de código carga datos en la tabla 'DataSet_ReporteInventarios.SPReporteIventarios' Puede moverla o quitarla según sea necesario.
            //this.SPReporteIventariosTableAdapter.Fill(this.DataSet_ReporteInventarios.SPReporteIventarios);


            // TODO: This line of code loads data into the 'dS_QNS.Prestamo' table. You can move, or remove it, as needed.
            this.prestamoTableAdapter.Fill(dS_QNS.Prestamo);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbFiltrar.SelectedIndex == 0)
            {
                this.clientesTableAdapter.FillByCedula(this.dS_QNS.Clientes, int.Parse(txtFiltro.Text));
            }
            else if (cmbFiltrar.SelectedIndex == 1)
            {
                this.clientesTableAdapter.FillByNombre(this.dS_QNS.Clientes, txtFiltro.Text);
            }
            this.reportViewer1.RefreshReport();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.dS_QNS.Clientes);

            this.reportViewer1.RefreshReport();
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
