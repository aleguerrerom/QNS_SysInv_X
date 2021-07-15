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
                GestorInventario inve = new GestorInventario();
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
                GestorEntregas entr = new GestorEntregas();
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
                AcercaDe about = new AcercaDe();
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
                GestorInventario inve = new GestorInventario();
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
                GestorEntregas entr = new GestorEntregas();
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
                GestorEntregas entr = new GestorEntregas();
                entr.Show();
            }
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
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "BITACORA  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                VerBitacora bitacora = new VerBitacora();
                bitacora.Show();
            }
        }

        private void cerrarTodo()
        {
           // Application.Exit();
            //VerBitacora bitacora = new VerBitacora();
            //bitacora.Close();
            //ReporteVendedores repV = new ReporteVendedores();
            //repV.Close();
            //ReporteUsuarios repU = new ReporteUsuarios();
            //repU.Close();
            //ReportePrestamo repP = new ReportePrestamo();
            //repP.Close();
            //ReporteOpor repO = new ReporteOpor();
            //repO.Close();
            //ReporteMovimientos repM = new ReporteMovimientos();
            //repM.Close();
            //ReporteLogsInicio repL = new ReporteLogsInicio();
            //repL.Close();
            //ReporteInventario repI = new ReporteInventario();
            //repI.Close();
            //ReporteEntrega repE = new ReporteEntrega();
            //repE.Close();
            //RerporteClientes repC = new RerporteClientes();
            //repC.Close();
            //GestorVendedores gesV = new GestorVendedores();
            //gesV.Close();
            //GestorUsuarios gesU = new GestorUsuarios();
            //gesU.Close();
            //GestorRoles gesR = new GestorRoles();
            //gesR.Close();
            //GestorPrestamo gesP = new GestorPrestamo();
            //gesP.Close();
            //GestorOportunidades gesO = new GestorOportunidades();
            //gesO.Close();
            //GestorInventario gesI = new GestorInventario();
            //gesI.Close();
            //GestorEntregas gesE = new GestorEntregas();
            //gesE.Close();
            //GestorClientes gesC = new GestorClientes();
            //gesC.Close();

            //AcercaDe aboutus = new AcercaDe();
            //CambiodeClave camdClave = new CambiodeClave();
            //camdClave.Close();
            //aboutus.Close();
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
                if (f.Text == "GESTOR DE PRESTAMOS  | QNS_SysInv_X")
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
                ReporteInventario entr = new ReporteInventario();
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
                ReporteUsuarios repU = new ReporteUsuarios();
                repU.Show();
            }
        }

        private void tsBitacora_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "BITACORA  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                VerBitacora bitacora = new VerBitacora();
                bitacora.Show();
            }
        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "BITACORA  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                VerBitacora bitacora = new VerBitacora();
                bitacora.Show();
            }
        }

        private void verBitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "BITACORA  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                VerBitacora bitacora = new VerBitacora();
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
                ReporteOpor RedOpo = new ReporteOpor();
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
                RerporteClientes RepoClientes = new RerporteClientes();
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
                ReporteVendedores repoVendedores = new ReporteVendedores();
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
                ReporteEntrega repoPrestamo = new ReporteEntrega();
                repoPrestamo.Show();
            }
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "REPORTE PRESTAMO  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                ReportePrestamo repoPrestamo = new ReportePrestamo();
                repoPrestamo.Show();
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea cerrar la sesión?", "SALIR", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                LogCierreSesion();
                Login login = new Login();
                login.Show();
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
