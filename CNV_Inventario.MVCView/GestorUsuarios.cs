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
using System.Data.SqlClient;

namespace CNV_Inventario.MVCView.Resources
{
    public partial class GestorUsuarios : Form
    {
        private Usuarios user;
        private RolesHelper rolH;
        private Roles roles;
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
        
        private void listar()
        {
            try
            {
                cargarCombo();
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

        private void cargarCombo()
        {
            try
            {

                this.roles = new Roles();
                this.roles.opc = 5;
                this.rolH = new RolesHelper(roles);
                this.table = new DataTable();
                this.table = this.userHelper.Listar();

                if (this.table.Rows.Count > 0)
                {
                    this.cmbRol.DataSource = table.DefaultView.ToString();
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
                this.user.Clave = EncryptionHelper.Encrypt(this.txtClave.Text);
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
                        actualizar();
                        listar();
                        limpiar();
                    }
                    else MessageBox.Show("Las claves deben ser iguales");
                }
                else
                {
                    if (this.txtClave.Text == this.txtConfirmar.Text)
                    {
                        guardar();
                        listar();
                        limpiar();
                    }
                    else MessageBox.Show("Las claven deben ser iguales");
                }
            }
        }

        public void limpiar()
        {
            this.txtApellido.Clear();
            this.txtClave.Clear();
            this.txtUsuario.Clear();
            this.txtConfirmar.Clear();
            this.txtNombre.Clear();
            this.chckbxActivo.Checked = false;
            this.btnAdd.Text = "AGREGAR";
            this.txtUsuario.ReadOnly = false;
        }


        private void GestorUsuarios_Load(object sender, EventArgs e)
        {
            listar();
            cargarCombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.table = (DataTable)this.dgvListar.DataSource;
                if (table == null)
                {
                    MessageBox.Show("No hay Usuarios para eliminar");
                }
                else
                {
                    int indice = dgvListar.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.user = new Usuarios();
                    this.user.Usuario = fila["usuario"].ToString();
                    this.user.opc = 3;
                    this.userHelper = new UsuariosHelper(user);
                    this.userHelper.Eliminar();
                    MessageBox.Show("Usuario Eliminado Eliminado");
                    listar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void actualizar()
        {
            this.user = new Usuarios();
            this.user.Usuario = this.txtUsuario.Text;
            this.user.Clave = EncryptionHelper.Encrypt(this.txtClave.Text);
           
            if (this.chckbxActivo.Checked)
            {
                this.user.Activo = true;
            }
            else this.user.Activo = false;
            this.user.Rol = int.Parse(this.cmbRol.Text);
            this.user.Nombre = this.txtNombre.Text;
            this.user.Apellido = this.txtApellido.Text;
            this.user.opc = 4;


            this.userHelper = new UsuariosHelper(user);
            this.userHelper.Actualizar();
            MessageBox.Show("Datos del Usuario actualizados");
    }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void dgvListar_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.table = (DataTable)this.dgvListar.DataSource;
                if (table == null)
                {
                    MessageBox.Show("No hay Registros de estudiante para actualizar");
                }
                else
                {
                    int indice = dgvListar.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.txtUsuario.Text = fila["usuario"].ToString();
                    this.txtClave.Text = EncryptionHelper.Encrypt(fila["clave"].ToString());
                    this.chckbxActivo.Checked = bool.Parse(fila["activo"].ToString());
                    this.txtConfirmar.Text = "";
                    this.cmbRol.Text = fila["rol"].ToString();
                    this.txtNombre.Text = fila["nombre"].ToString();
                    this.txtApellido.Text = fila["apellido"].ToString();
                    this.txtUsuario.ReadOnly = true;
                    this.btnAdd.Text = "ACTUALIZAR";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
    }