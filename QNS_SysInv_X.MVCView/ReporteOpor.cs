﻿using QNS_SysInv_X.MVCController;
using System;
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

        public ReporteOpor(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsu.Text = this.user.Usuario;
        }

        private void ReporteInventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QNS.Oportunidades' table. You can move, or remove it, as needed.
            this.oportunidadesTableAdapter.Fill(this.dS_QNS.Oportunidades);
            // TODO: This line of code loads data into the 'dS_QNS.Clientes' table. You can move, or remove it, as needed.
           

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbFiltro.SelectedIndex == 0)
                {
                    this.oportunidadesTableAdapter.FillBy(this.dS_QNS.Oportunidades, int.Parse(txtFiltro.Text));
                }
                else if (cmbFiltro.SelectedIndex == 1)
                {
                    this.oportunidadesTableAdapter.FillByFecha(this.dS_QNS.Oportunidades, dtpFecha.Value);
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

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
