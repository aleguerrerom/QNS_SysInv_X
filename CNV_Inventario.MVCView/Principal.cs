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
        private UsuariosHelper userHelper;
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
            this.statusUsuario.Text = "Bienvenid@ " + this.user.Nombre + " " + this.user.Apellido + " "+ this.user.Rol +" Usuario "+ this.user.Usuario ;
            
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
            }
            if (bool.Parse(fila["entrega"].ToString()) == true)
            {
                entregaToolStripMenuItem.Visible = true;
            }
            if (bool.Parse(fila["inventario"].ToString()) == true)
            {
                inventarioToolStripMenuItem.Visible = true;
            }
            if(bool.Parse(fila["roles"].ToString()) == true)
            {
                rolesToolStripMenuItem.Visible = true;
            }
            if (bool.Parse(fila["prestamo"].ToString()) == true)
            {
                prestamoToolStripMenuItem.Visible = true;
            }
            if (bool.Parse(fila["bitacora"].ToString()) == true)
            {
                tslBitacora.Visible = true;
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
            Entrega entr = new Entrega();
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
            Entrega entr = new Entrega();
            entr.Show();
        }

        private void ingresarConOtroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LogCierreSesion();
            Login login = new Login();
            login.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LogCierreSesion();
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

            GestorInventario inve = new GestorInventario();
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
            GestorRoles role = new GestorRoles();
            role.Show();
        }

        private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GestorUsuarios gu = new GestorUsuarios(user);
            gu.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestorInventario inve = new GestorInventario();
            inve.Show();
        }

        private void entregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrega entr = new Entrega();
            entr.Show();
        }

        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
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
            GestorRespaldos res = new GestorRespaldos();
            res.Show();
        }
    }
}
