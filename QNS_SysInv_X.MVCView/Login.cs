using System;
using System.Data;
using System.Windows.Forms;
using QNS_SysInv_X.MVCController;
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

        #region Expresiones Regulares
        static Regex validate_numberANDletter = RegexExpression.numberANDletter_validation();
        static Regex validate_Spaces = RegexExpression.AvoidSpaces_validation();
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region LogsIniciode Sesion
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
        #endregion

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            #region Validaciones de Login y Proceso de Login
            try
            {
                if (this.txtUsuarioLogin.Text == "" || String.IsNullOrEmpty(txtUsuarioLogin.Text))
                {
                    MessageBox.Show("Campos de usuario no puede estar vacÍo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (this.txtClaveLogin.Text == "" || String.IsNullOrEmpty(txtUsuarioLogin.Text))
                {
                    MessageBox.Show("El campo de contraseña no puede estar vacÍo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    this.user = new Usuarios();
                    this.user.Usuario = this.txtUsuarioLogin.Text.TrimEnd();
                    this.user.Clave = EncryptionHelper.Encrypt(this.txtClaveLogin.Text.TrimEnd());
                    //this.user.Clave = this.txtClaveLogin.Text;
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
                        this.bitacora = new Bitacora();
                        this.bitacora.Usuario = this.txtUsuarioLogin.Text;
                        this.bitacora.Movimiento = "Inicio de sesión exsitoso";
                        this.bitacora.Detalle = "Inicio de sesión correcto de: " + this.txtUsuarioLogin.Text;
                        this.bitacora.opc = 5;
                        this.bitH = new BitacoraHelper(bitacora);
                        this.bitH.LogMovimientos();
                        inicio.Show();
                        this.Hide();
                    }
                    else if (validate_numberANDletter.IsMatch(txtUsuarioLogin.Text) != true)
                    {
                        MessageBox.Show("Solo letras y nÚmeros son permitidos en campo de Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.ActiveControl = txtUsuarioLogin;
                        return;
                    }
                    else if (validate_Spaces.IsMatch(txtUsuarioLogin.Text) != true)
                    {
                        MessageBox.Show("No se permiten espacios en el campo de Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.ActiveControl = txtUsuarioLogin;
                        return;
                    }
                    else if (validate_Spaces.IsMatch(txtClaveLogin.Text) != true)
                    {
                        MessageBox.Show("No se permiten espacios en el campo constraseña.", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.ActiveControl = txtClaveLogin;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Datos de inicio de sesión incorrectos o el usuario o rol se encuentra inactivo.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.bitacora = new Bitacora();
                        this.bitacora.Usuario = this.txtUsuarioLogin.Text;
                        this.bitacora.Movimiento = "Inicio de sesión faliido";
                        this.bitacora.Detalle = "Inicio de sesión fallido de: " + this.txtUsuarioLogin.Text;
                        this.bitacora.opc = 5;
                        this.bitH = new BitacoraHelper(bitacora);
                        this.bitH.LogMovimientos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Funcion ver contrasena 
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
        #endregion

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtUsuarioLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }

        private void txtClaveLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }
    }
}
