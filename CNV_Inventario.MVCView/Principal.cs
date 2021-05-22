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
using System.IO;

namespace CNV_Inventario.MVCView
{
    public partial class Principal : Form
    {
        private Usuarios user;
        private object wbrPdf;

        public Principal()
        {
            InitializeComponent();
        }

        public Principal(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.statusUsuario.Text = "Usuario: " /*+ this.user.Nombre*/;
            validarPerfil();
        }

        private void validarPerfil()
        {
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

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            GestorRoles role = new GestorRoles();
                role.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        private void tsAboutUs_Click(object sender, EventArgs e)
        {
            AcercaDe about = new AcercaDe();
            about.Show();

        }

        private void tsInventario(object sender, EventArgs e)
        {
            Inventario inve = new Inventario();
            inve.Show();
        }

        private void tsEntrega(object sender, EventArgs e)
        {
            Entrega entr = new Entrega();
            entr.Show();
        }

        private void ingresarConOtroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiodeClave cambio = new CambiodeClave();
            cambio.Show();
        }

        private void toolStripInventario_Click(object sender, EventArgs e)
        {

            Inventario inve = new Inventario();
            inve.Show();
        }

        private void tsrEntrega_Click(object sender, EventArgs e)
        {
            Entrega entr = new Entrega();
            entr.Show();
        }

        private void tsAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Alejandro\Desktop\CNV_Inventario.MVC\CNV_Inventario.MVCView\images\guia.pdf");
        }
    }
}
