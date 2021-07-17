using System;
using System.Windows.Forms;
using QNS_SysInv_X.MVCController;
using System.Text.RegularExpressions;

namespace QNS_SysInv_X.MVCView
{
    public partial class CambiodeClave : Form
    {
        private Usuarios user;
        private UsuariosHelper userHelper;
        private Bitacora bitacora;
        private BitacoraHelper bitH;

        public CambiodeClave()
        {
            InitializeComponent();
        }

        static Regex validate_Spaces = RegexExpression.AvoidSpaces_validation();

        public CambiodeClave(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsua.Text = this.user.Usuario;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA
            if (this.txtClave.Text == "" || this.txtConfirmar.Text == "")
            {
                MessageBox.Show("Tienes que llenar todos los campos, para agregar o actualizar");
            }

            else if (validate_Spaces.IsMatch(txtClave.Text) != true)
            {
                MessageBox.Show("No se permiten espacios en la Clave", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.ActiveControl = txtClave;
                return;
            }
            else if (validate_Spaces.IsMatch(txtConfirmar.Text) != true)
            {
                MessageBox.Show("No se permiten espacios en el espacio Confirmar", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.ActiveControl = txtConfirmar;
                return;
            }
            else
            {
                if (this.txtClave.Text != this.txtConfirmar.Text)
                {
                      MessageBox.Show("Las claven deben ser iguales");
                }
                
                else {
                    DialogResult dialogResult = MessageBox.Show("Desea actualizar la Clave?", "Cambio de Clave", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        CambiarClave();
                        limpiar();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("No se actualizo la clave");
                    }
                } }
               
        }

        private void CambiarClave()
        {

            try
            {
                this.user = new Usuarios();
                this.user.Usuario = this.stsUser.Text ;
                this.user.Clave = EncryptionHelper.Encrypt(this.txtClave.Text);
                 this.user.opc = 6;

                 this.userHelper = new UsuariosHelper(user);
                
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.stsUsua.Text;
                this.bitacora.Movimiento = "Actualizar";
                this.bitacora.Detalle = "Se cambio la clave del usuario correctamente ";
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();
                
                this.userHelper.CambiarClave();
                MessageBox.Show("La clave ha sido actualizada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void limpiar()
        {
            this.txtClave.Text = "";
            this.txtConfirmar.Text = "";

        }

        private void chckView_CheckedChanged(object sender, EventArgs e)
        {
            if (chckView.Checked)
            {
                txtClave.UseSystemPasswordChar = false;
                txtConfirmar.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
                lblShow.Text = "OCULTAR CONTRASEÑA";
            }
            else
            {
                txtClave.UseSystemPasswordChar = true;
                txtConfirmar.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
                lblShow.Text = "VER CONTRASEÑA";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } }