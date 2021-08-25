using System;
using System.Data;
using System.Windows.Forms;
using QNS_SysInv_X.MVCController;
using QNS_SysInv_X.MVCView.Resources;

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
            this.statusUsuario.Text = "Bienvenid@ " + this.user.Nombre; //+ " " + this.user.Apellido + " Usuario "+ this.user.Usuario ;
        }

            #region log cierre de sesion
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
                    #endregion

        private void validarPerfil()
        {
            #region Validar Perfil
            roles = new Roles();
            
            roles.opc = 6;
            this.roles.ID1 = user.Rol;
            rolesH = new RolesHelper(roles);

            table = rolesH.BusquedaPermisoRol();
            DataRow fila = table.Rows[0];

            if (bool.Parse(fila["Usuarios"].ToString())==true)
            {
                usuariosToolStripMenuItem.Visible = true;
                usuariosToolStripMenuItem1.Visible = true;
            }
            if (bool.Parse(fila["Entregas"].ToString()) == true)
            {
                entregaToolStripMenuItem.Visible = true;
            }
            if (bool.Parse(fila["Inventarios"].ToString()) == true)
            {
                inventarioToolStripMenuItem.Visible = true;
                tsmReporteInv.Visible = true;
            }
            if(bool.Parse(fila["Roles"].ToString()) == true)
            {
                rolesToolStripMenuItem.Visible = true;
            }
            if (bool.Parse(fila["Prestamos"].ToString()) == true)
            {
                prestamoToolStripMenuItem.Visible = true;
            }
            if (bool.Parse(fila["Bitacoras"].ToString()) == true)
            {
                tsBita.Visible = true;
            }
            if (bool.Parse(fila["Oportunidades"].ToString()) == true)
            {
                oportunidadesToolStripMenuItem.Visible = true;
                tsmReporteOpo.Visible = true;
            }
            if (bool.Parse(fila["Vendedores"].ToString()) == true)
            {
                vendedoresToolStripMenuItem.Visible = true;
                vendedoresToolStripMenuItem1.Visible = true;
            }
            if (bool.Parse(fila["Clientes"].ToString()) == true)
            {
                clientesToolStripMenuItem.Visible = true;
                clmReporteCli.Visible = true;
            }
            #endregion
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "ACERCA DE  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                AcercaDe about = new AcercaDe();
                about.Show();
            }
        }
        
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GESTOR INVENTARIOS  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                GestorInventario inve = new GestorInventario(user);
                inve.Show();
            }
        }

        private void Entrega_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GESTOR DE ENTREGAS  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                GestorEntregas entr = new GestorEntregas(user);
                entr.Show();
            }
        }
        
        private void tsAboutUs_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "ACERCA DE  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                AcercaDe about = new AcercaDe(user);
                about.Show();
            }
        }

        private void tsInventario(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GESTOR INVENTARIOS  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                GestorInventario inve = new GestorInventario(user);
                inve.Show();
            }
        }

        private void tsEntrega(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GESTOR DE ENTREGAS  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                GestorEntregas entr = new GestorEntregas(user);
                entr.Show();
            }
        }
        private void ingresarConOtroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "CAMBIO DE CLAVE  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }

            }
            if (IsOpen == false)
            {
                CambiodeClave cambio = new CambiodeClave(user);
                cambio.Show();
            }
           
        }

        private void toolStripInventario_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GESTOR INVENTARIOS  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }

            }
            if (IsOpen == false)
            {
                GestorInventario inve = new GestorInventario(user);
                inve.Show();
            }
        }

        private void tsrEntrega_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GESTOR DE ENTREGAS  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                GestorEntregas entr = new GestorEntregas(user);
                entr.Show();
            }
        }

        private void tsAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Alejandro\Desktop\QNS_SysInv_X\QNS_SysInv_X.MVCView\images\Manual de Usuario.pdf");
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            validarPerfil();
        }

        private void tslBitacora_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "BITÁCORA  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                VerBitacora bitacora = new VerBitacora(user);
                bitacora.Show();
            }
        }

        private void cerrarTodo()
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GESTOR DE ROLES  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                GestorRoles role = new GestorRoles(user);
                role.Show();
            }
        }

        private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GESTOR DE USUARIOS  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                GestorUsuarios gu = new GestorUsuarios(user);
                gu.Show();
            }
        }
        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GESTOR INVENTARIOS  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                GestorInventario inve = new GestorInventario(user);
                inve.Show();
            }
        }
        private void entregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GESTOR DE ENTREGAS  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                GestorEntregas entr = new GestorEntregas(user);
                entr.Show();
            }
        }

        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GESTOR DE PRÉSTAMOS  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                GestorPrestamo prestamo = new GestorPrestamo(user);
                prestamo.Show();
            }
        }

        private void Principal_Leave(object sender, EventArgs e)
        {
            LogCierreSesion();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GESTOR VENDEDORES  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                GestorVendedores res = new GestorVendedores(user);
                res.Show();
            }
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GESTOR VENDEDORES  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                GestorVendedores res = new GestorVendedores(user);
                res.Show();
            }
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GESTOR CLIENTES  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                GestorClientes clientes = new GestorClientes(user);
                clientes.Show();
            }
        }

        private void oportunidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GESTOR OPORTUNIDADES  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                GestorOportunidades oportunidades = new GestorOportunidades(user);
                oportunidades.Show();
            }
        }

        private void tsmReporteInv_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "REPORTE INVENTARIO  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                ReporteInventario entr = new ReporteInventario(user);
                entr.Show();
            }
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "REPORTE USUARIOS  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                ReporteUsuarios repU = new ReporteUsuarios(user);
                repU.Show();
            }
        }

        private void tsBitacora_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "BITÁCORA  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                VerBitacora bitacora = new VerBitacora(user);
                bitacora.Show();
            }
        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "BITÁCORA  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                VerBitacora bitacora = new VerBitacora(user);
                bitacora.Show();
            }
        }

        private void verBitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "BITÁCORA  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                VerBitacora bitacora = new VerBitacora(user);
                bitacora.Show();
            }
        }

        private void tsmReporteOpo_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "REPORTE OPORTUNIDADES  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                ReporteOpor  RedOpo = new ReporteOpor(user);
                RedOpo.Show();
            }
        }

        private void clmReporteCli_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "REPORTE CLIENTES | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                RerporteClientes RepoClientes = new RerporteClientes(user);
                RepoClientes.Show();
            }
        }

        private void vendedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "REPORTE VENDEDORES  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                ReporteVendedor repoVendedores = new ReporteVendedor(user);
                repoVendedores.Show();
            }
        }

        private void entregaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GESTOR DE USUARIOS  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                ReporteEntrega repoPrestamo = new ReporteEntrega(user);
                repoPrestamo.Show();
            }
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "REPORTE PRÉSTAMO  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                ReportePrestamo repoPrestamo = new ReportePrestamo(user);
                repoPrestamo.Show();
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea cerrar la sesión?", "SALIR", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.user.Nombre;
                this.bitacora.Movimiento = "Cierre de Sesión existoso";
                this.bitacora.Detalle = "Se cerró sesión de forma correcta: " + this.user.Nombre;
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();
                LogCierreSesion();
                cerrarTodo();
                e.Cancel = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
