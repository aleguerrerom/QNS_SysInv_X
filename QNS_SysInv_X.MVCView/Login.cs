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
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace QNS_SysInv_X.MVCView
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

        static Regex validate_emailaddress = RegexExpression.email_validation();

        static Regex validate_letter = RegexExpression.letter_validation();

        static Regex validate_number = RegexExpression.number_validation();

        static Regex validate_numberANDletter = RegexExpression.numberANDletter_validation();

        static Regex validate_Spaces = RegexExpression.AvoidSpaces_validation();
        
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
                if (this.txtUsuarioLogin.Text == "" && this.txtClaveLogin.Text == "")
                {
                      MessageBox.Show("Campos vacios favor ingresar datos en ambos campos");
                }
                else if (validate_Spaces.IsMatch(txtClaveLogin.Text) != true)
                {
                    MessageBox.Show("No se permiten espacios en la Clave", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtClaveLogin.Focus();
                    return;
                }
                else if (validate_numberANDletter.IsMatch(txtUsuarioLogin.Text) != true)
                {
                    MessageBox.Show("Solo letras y numeros son permitios en campo de Usuario", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    return;
                }
               
                else { 
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
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chckView.Checked)
            {
                txtClaveLogin.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
                lblShow.Text = "OCULTAR CONTRASEÑA";
            }
           else
            {
                txtClaveLogin.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
                lblShow.Text = "VER CONTRASEÑA";
            }
        }
    }
}
