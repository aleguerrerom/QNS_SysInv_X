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
using System.Security.Cryptography;

namespace CNV_Inventario.MVCView
{
    public partial class Login : Form
    {
        private Usuarios user;
        private UsuariosHelper userHelper;
        private DataTable table;
        private Bitacora bitacora;
        private BitacoraHelper bitH;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogInicioSesion()
        {
            try
            {
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.txtUsuarioLogin.Text;
                this.bitacora.opc = 2;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogSesion();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (this.txtUsuarioLogin.Text != "" && this.txtClaveLogin.Text != "")
                {
                    this.user = new Usuarios();
                    this.user.Usuario = this.txtUsuarioLogin.Text;
                    this.user.Clave = EncryptionHelper.Encrypt(this.txtClaveLogin.Text);
                   // this.user.Clave = this.txtClaveLogin.Text;
                    this.user.opc = 5;

                    this.userHelper = new UsuariosHelper(user);
                    this.table = new DataTable();
                    this.table = this.userHelper.ValidarLogin();

                    
                    if (table.Rows.Count > 0)
                    {
                        DataRow fila = table.Rows[0];
                        this.user.Usuario = fila["usuario"].ToString();
                        this.user.Rol = int.Parse(fila["rol"].ToString());
                        this.user.Nombre = fila["nombre"].ToString();
                        this.user.Apellido = fila["apellido"].ToString();
                        Principal inicio = new Principal(user);
                        LogInicioSesion();
                        inicio.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("Datos de inicio de sesión incorrectos o Usuario Inactivo");
                }
                else MessageBox.Show("Campos vacios favor ingresar datos en ambos campos");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            CambiodeClave clave = new CambiodeClave();
            clave.Show();
        }
    }
}
