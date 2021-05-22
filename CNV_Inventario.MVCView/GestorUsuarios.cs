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
        private Usuarios user;
        private UsuariosHelper userHelper;
        private DataTable table;
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

        private void listar()
        {
            try
            {
                this.user = new Usuarios();
                this.user.opc = 1;

                this.userHelper = new UsuariosHelper(user);


                this.table = new DataTable();
                this.table = this.userHelper.Listar();

                if (this.table.Rows.Count > 0)
                {
                    this.dgvListar.DataSource = this.table;
                    this.dgvListar.ReadOnly = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guardar()
        {
            try
            {
                this.user = new Usuarios();
                this.user.Usuario = this.txtUsuario.Text;
                this.user.Clave = this.txtClave.Text;
                //this.user.Rol = int.Parse(this.textBox1.Text);
                //this.user.Activo = int.Parse(this.textBox2.Text);
                if (this.chckbxActivo.Checked)
                {
                    this.user.Activo = true;
                }
                else this.user.Activo = false;
                this.user.Rol = int.Parse(this.cmbRol.Text);
                this.user.Nombre = this.txtNombre.Text;
                this.user.Apellido = this.txtApellido.Text;
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
                        listar();
                        //limpiarCeldas();
                    }
                    else MessageBox.Show("Las claves deben ser iguales");
                }
                else
                {
                    if (this.txtClave.Text == this.txtConfirmar.Text)
                    {
                        guardar();
                        listar();
                        //limpiarCeldas();
                    }
                    else MessageBox.Show("Las claven deben ser iguales");
                }
            }
        }

        private void GestorUsuarios_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }