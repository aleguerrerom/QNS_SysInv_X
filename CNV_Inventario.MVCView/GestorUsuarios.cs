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

namespace CNV_Inventario.MVCView.Resources
{
    public partial class GestorUsuarios : Form
    {
        public GestorUsuarios()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guardar()
        {
            try
            {
                this.user = new Usuarios();
                this.user.Nombre = this.txtNombreUser.Text;
                this.user.Cedula = this.txtCedulaUser.Text;
                this.user.FechaNacimiento = this.dtpFechaNaUsu.Value;
                this.user.Genero = this.cmbGeneroUsu.Text;
                this.user.Telefono = this.txtTelefonoUsu.Text;
                this.user.Correo = this.txtCorreoUsu.Text;
                this.user.Perfil = this.cmbPerfilUsu.Text;
                this.user.Usuario = this.txtUsuario.Text;
                this.user.Clave = this.txtClave.Text;
                this.user.opc = 2;

                this.userHelper = new UsuariosHelper(user);
                this.userHelper.Guardar();
                MessageBox.Show("Usuario Almacenado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "" || this.txtNombre.Text == ""
             && this.txtApellido.Text == "" || this.txtClave.Text == "" || this.txtConfirmar.Text == "")
            {
                MessageBox.Show("Tienes que llenar todos los campos, para agregar o actualizar");

            }
            else
            {
                if (this.txtUsuario.ReadOnly)
                {
                    if (this.txtClave.Text == this.txtConfirmar.Text)
                    {
                        //actualizar();
                        //listar();
                        //limpiarCeldas();
                    }
                    else MessageBox.Show("Las claves deben ser iguales");
                }
                else
                {
                    if (this.txtClave.Text == this.txtConfirmar.Text)
                    {
                        guardar();
                        //listar();
                        //limpiarCeldas();
                    }
                    else MessageBox.Show("Las claven deben ser iguales");
                }
            }
        }

    }