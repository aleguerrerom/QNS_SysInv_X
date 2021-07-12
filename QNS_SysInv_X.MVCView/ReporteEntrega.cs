﻿using Microsoft.Reporting.WinForms;
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
    public partial class ReporteEntrega : Form
    {
        public ReporteEntrega()
        {
            InitializeComponent();
        }

        private void ReporteUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QNS.Entrega' table. You can move, or remove it, as needed.
            this.entregaTableAdapter.Fill(this.dS_QNS.Entrega);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbFiltrar.SelectedIndex == 0)
            {
                this.entregaTableAdapter.FillByID(this.dS_QNS.Entrega, int.Parse(txtFiltro.Text));
            }
            else if (cmbFiltrar.SelectedIndex == 1)
            {
                this.entregaTableAdapter.FillByCliente(this.dS_QNS.Entrega, txtFiltro.Text);
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
    }
}
