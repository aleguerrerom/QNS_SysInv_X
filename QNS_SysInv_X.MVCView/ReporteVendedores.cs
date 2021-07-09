﻿using System;
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
    public partial class ReporteVendedores : Form
    {
        public ReporteVendedores()
        {
            InitializeComponent();
        }

        private void ReporteInventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QNS.Vendedores' table. You can move, or remove it, as needed.
            this.vendedoresTableAdapter.Fill(this.dS_QNS.Vendedores);
            // TODO: This line of code loads data into the 'dS_QNS.Inventario' table. You can move, or remove it, as needed.
           
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
    }
}
