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
    public partial class ReporteLogsInicio : Form
    {
        public ReporteLogsInicio()
        {
            InitializeComponent();
        }

        private void ReporteInventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QNS.AuditLog' table. You can move, or remove it, as needed.
            this.auditLogTableAdapter.Fill(this.dS_QNS.AuditLog);
            // TODO: This line of code loads data into the 'dS_QNS.Inventario' table. You can move, or remove it, as needed.
            this.reportViewer1.RefreshReport();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedIndex == 0)
            {
                this.auditLogTableAdapter.FillByUsuario(this.dS_QNS.AuditLog, txtFiltro.Text);
            }
            else if (cmbFiltro.SelectedIndex == 1)
            {
                this.auditLogTableAdapter.FillByfechaInicio(this.dS_QNS.AuditLog, dtpFecha.Value);
            }
            else if (cmbFiltro.SelectedIndex == 2)
            {
                this.auditLogTableAdapter.FillByfechaSalida(this.dS_QNS.AuditLog, dtpFecha.Value);
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

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        
        
    }
}
