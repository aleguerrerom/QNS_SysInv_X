using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QNS_SysInv_X.MVCController;
using QNS_SysInv_X.MVCView.Resources;
using System.IO;

namespace QNS_SysInv_X.MVCView
{
    public partial class Principal : Form
    {
        private Usuarios user;
        private Roles roles;
        private DataTable table;
        private RolesHelper rolesH;
        private Bitacora bitacora;
        private BitacoraHelper bitH;

        public Principal()
        {
            InitializeComponent();
        }

        public Principal(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.statusUsuario.Text = "Bienvenid@ " + this.user.Nombre + " " + this.user.Apellido + " Usuario "+ this.user.Usuario ;
        }

        private void LogCierreSesion()
        {
            try
            {
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.user.Usuario;
                this.bitacora.opc = 3;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogSesion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void validarPerfil()
        {
           
            roles = new Roles();
            
            roles.opc = 6;
            this.roles.ID1 = user.Rol;
            rolesH = new RolesHelper(roles);

            table = rolesH.BusquedaPermisoRol();
            DataRow fila = table.Rows[0];

            if (bool.Parse(fila["usuarios"].ToString())==true)
            {
                usuariosToolStripMenuItem.Visible = true;
                usuariosToolStripMenuItem1.Visible = true;
            }
            if (bool.Parse(fila["entrega"].ToString()) == true)
            {
                entregaToolStripMenuItem.Visible = true;
                entregaToolStripMenuItem1.Visible = true;
            }
            if (bool.Parse(fila["inventario"].ToString()) == true)
            {
                inventarioToolStripMenuItem.Visible = true;
                tsmReporteInv.Visible = true;
            }
            if(bool.Parse(fila["roles"].ToString()) == true)
            {
                rolesToolStripMenuItem.Visible = true;
            }
            if (bool.Parse(fila["prestamo"].ToString()) == true)
            {
                prestamoToolStripMenuItem.Visible = true;
                prestamosToolStripMenuItem.Visible = true;
            }
            if (bool.Parse(fila["bitacora"].ToString()) == true)
            {
                tsBita.Visible = true;
            }
            if (bool.Parse(fila["oportunidades"].ToString()) == true)
            {
                oportunidadesToolStripMenuItem.Visible = true;
                tsmReporteOpo.Visible = true;
            }
            if (bool.Parse(fila["vendedores"].ToString()) == true)
            {
                vendedoresToolStripMenuItem.Visible = true;
                vendedoresToolStripMenuItem1.Visible = true;
            }
            if (bool.Parse(fila["clientes"].ToString()) == true)
            {
                clientesToolStripMenuItem.Visible = true;
                clmReporteCli.Visible = true;
            }
        }
        
        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            AcercaDe about = new AcercaDe();
            about.Show();
        }
        
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            GestorInventario inve = new GestorInventario();
            inve.Show();
        }

        private void Entrega_Click(object sender, EventArgs e)
        {
            GestorEntregas entr = new GestorEntregas();
            entr.Show();
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
            GestorInventario inve = new GestorInventario();
            inve.Show();
        }

        private void tsEntrega(object sender, EventArgs e)
        {
            GestorEntregas entr = new GestorEntregas();
            entr.Show();
        }

        private void ingresarConOtroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea salir e ingresar con otro usuario?", "Ingresar con otro usuario", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
            this.Close();
            LogCierreSesion();
            Login login = new Login();
            login.Show();
            }
            else if (dialogResult == DialogResult.No)
            { }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            LogCierreSesion();
            Login login = new Login();
            login.Show();
            }
            else if (dialogResult == DialogResult.No)
            { }   
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiodeClave cambio = new CambiodeClave(user);
            cambio.Show();
        }

        private void toolStripInventario_Click(object sender, EventArgs e)
        {
            GestorInventario inve = new GestorInventario(user);
            inve.Show();
        }

        private void tsrEntrega_Click(object sender, EventArgs e)
        {
            GestorEntregas entr = new GestorEntregas();
            entr.Show();
        }

        private void tsAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Alejandro\Desktop\QNS_SysInv_X\QNS_SysInv_X.MVCView\images\guia.pdf");
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            validarPerfil();
        }

        private void tslBitacora_Click(object sender, EventArgs e)
        {
            VerBitacora bitacora = new VerBitacora();
            bitacora.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestorRoles role = new GestorRoles(user);
            role.Show();
        }

        private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GestorUsuarios gu = new GestorUsuarios(user);
            gu.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestorInventario inve = new GestorInventario(user);
            inve.Show();
        }

        private void entregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestorEntregas entr = new GestorEntregas(user);
            entr.Show();
        }

        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestorPrestamo prestamo = new GestorPrestamo(user);
            prestamo.Show();
        }

       private void tsPrestamo_ButtonClick(object sender, EventArgs e)
        {

        }

        private void Principal_Leave(object sender, EventArgs e)
        {
            LogCierreSesion();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            GestorVendedores res = new GestorVendedores(user);
            res.Show();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestorVendedores res = new GestorVendedores(user);
            res.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestorClientes clientes = new GestorClientes(user);
            clientes.Show();
        }

        private void oportunidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestorOportunidades oportunidades = new GestorOportunidades(user);
            oportunidades.Show();
        }

        private void tsmReporteInv_Click(object sender, EventArgs e)
        {
            ReporteInventario entr = new ReporteInventario();
            entr.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteUsuarios repU = new ReporteUsuarios();
            repU.Show();
        }

        private void tsBitacora_Click(object sender, EventArgs e)
        {
            VerBitacora bitacora = new VerBitacora();
            bitacora.Show();
        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            VerBitacora bitacora = new VerBitacora();
            bitacora.Show();
        }

        private void verBitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerBitacora bitacora = new VerBitacora();
            bitacora.Show();
        }

        private void tsmReporteOpo_Click(object sender, EventArgs e)
        {
           ReporteOpor RedOpo = new ReporteOpor();
            RedOpo.Show();
        }

        private void clmReporteCli_Click(object sender, EventArgs e)
        {
            RerporteClientes RepoClientes = new RerporteClientes();
             RepoClientes.Show();
        }

        private void vendedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteVendedores repoVendedores = new ReporteVendedores();
            repoVendedores.Show();
        }

        private void entregaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteEntrega repoPrestamo = new ReporteEntrega();
            repoPrestamo.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportePrestamo repoPrestamo = new ReportePrestamo();
            repoPrestamo.Show();
        }
    }
}
