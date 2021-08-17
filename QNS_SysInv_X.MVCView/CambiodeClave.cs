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
            #region VALIDACIONES DE ESPACIOS ETCC
            // VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA
            if (this.txtClave.Text == "" || this.txtConfirmar.Text == "")
            {
                MessageBox.Show("Debes llenar ambos campos para cambiar clave", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (validate_Spaces.IsMatch(txtClave.Text) != true)
            {
                MessageBox.Show("No se permiten espacios en la Clave", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.ActiveControl = txtClave;
                return;
            }
            else if (validate_Spaces.IsMatch(txtConfirmar.Text) != true)
            {
                MessageBox.Show("No se permiten espacios en el espacio Confirmar", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.ActiveControl = txtConfirmar;
                return;
            }
            else
            {
                if (this.txtClave.Text != this.txtConfirmar.Text)
                {
                      MessageBox.Show("Las claves deben ser iguales", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show("No se actualizó la clave", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            #endregion
        }

        #region FUNCION CAMBIO DE CLAVE
        private void CambiarClave()
        {

            try
            {
                this.user = new Usuarios();
                this.user.Usuario = this.stsUser.Text ;
                this.user.Clave = EncryptionHelper.Encrypt(this.txtClave.Text.TrimEnd());
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
                MessageBox.Show("La clave ha sido actualizada","Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region LIMPIAR CAMPOS
        private void limpiar()
        {
            this.txtClave.Text = "";
            this.txtConfirmar.Text = "";
        }
        #endregion

        private void chckView_CheckedChanged(object sender, EventArgs e)
        {
            #region OCULTAR O MOSTRAR CLAVE
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
                txtConfirmar.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
                lblShow.Text = "VER CONTRASEÑA";
            }
            #endregion
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }

        private void txtConfirmar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }
    } }