using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QNS_SysInv_X.MVCView.Resources;
using QNS_SysInv_X.MVCController;

namespace QNS_SysInv_X.MVCView
{
    public partial class CambiodeClave : Form
    {


        private Usuarios user;
        private UsuariosHelper userHelper;
        private RolesHelper rolH;
        private Roles roles;
        private DataTable table;
        private Bitacora bitacora;
        private BitacoraHelper bitH;

        public CambiodeClave()
        {
            InitializeComponent();
        }

        public CambiodeClave(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUser.Text = this.user.Nombre;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA
            if (this.txtClave.Text == "" || this.txtConfirmar.Text == "")
            {
                MessageBox.Show("Tienes que llenar todos los campos, para agregar o actualizar");
            }
            else
            {

                if (this.txtClave.Text == this.txtConfirmar.Text)
                {
                    CambiarClave();
                    limpiar();
                }
                else MessageBox.Show("Las claven deben ser iguales");

            }
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
                /*
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.user.Usuario;
                this.bitacora.Movimiento = "Actualizar";
                this.bitacora.Detalle = "Se actualizo el usuario correctamente " + this.txtUsuario.Text;
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();
                */
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
    } }