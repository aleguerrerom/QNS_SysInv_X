using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNV_Inventario.MVCController;
using CNV_Inventario.MVCView.Resources;

namespace CNV_Inventario.MVCView
{
    public partial class Principal : Form
    {
        private Usuarios user;
        public Principal()
        {
            InitializeComponent();
        }

        public Principal(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.statusUsuario.Text = "Usuario: " + this.user.Nombre;
            validarPerfil();
        }

        private void validarPerfil()
        {
            switch (this.user.Rol)
            {
                /*case "5":
                    this.usuariosToolStripMenuItem.Visible = false;
                    break;
                case "6":
                  this.aboutUsToolStripMenuItem.Visible = false;
                      break;
                    //estudiantesToolStripMenuItem
                    //cursosToolStripMenuItem
                  */  //usuariosToolStripMenuItem
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestorUsuarios gu = new GestorUsuarios();
            gu.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            AcercaDe about = new AcercaDe();
            about.Show();
        }

        private void toolStripLabel4_Click_1(object sender, EventArgs e)
        {
            AcercaDe about = new AcercaDe();
            about.Show();
            
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Inventario inve = new Inventario();
            inve.Show();
        }

        private void Entrega_Click(object sender, EventArgs e)
        {
            Entrega entr = new Entrega();
            entr.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Prestamo pres = new Prestamo();
            pres.Show();
        }
    }
}
