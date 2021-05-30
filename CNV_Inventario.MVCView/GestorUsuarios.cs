using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CNV_Inventario.MVCController;

namespace CNV_Inventario.MVCView.Resources
{
    public partial class GestorUsuarios : Form
    {
        private Usuarios user;
        private RolesHelper rolH;
        private Roles roles;
        private UsuariosHelper userHelper;
        private DataTable table;
        private Bitacora bitacora;
        private BitacoraHelper bitH;

        public GestorUsuarios()
        {
            InitializeComponent();
        }
        
        public GestorUsuarios(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
        }

        #region LOGS MOVIMIENTO
        
        private void LogMovimientos()
        {
            try
            {
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.user.Usuario;
                this.bitacora.Movimiento = "Agregar";
                this.bitacora.Detalle = "Se agrego un nuevo usuario";
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region LISTAR USUARIOS
        private void listar()
        {
            try
            {
                //cargarCombo();
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

        #endregion

        #region CARGAR COMBO BOX DE ROL
        private void cargarCombo()
        {
            try
            {
                this.roles = new Roles();
                this.roles.opc = 5;
                this.rolH = new RolesHelper(roles);
                this.table = new DataTable();
                this.table = this.rolH.ListarRol();


                if (this.table.Rows.Count > 0)
                {
                    this.cmbRol.DataSource = this.table;
                    cmbRol.ValueMember = "nombre";
                    cmbRol.DisplayMember = "nombre";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region GUARDAR USUARIO
        //FUNCION AGREGAR NUEVO USUARIO
        private void guardar()
        {
            try
            {
                //AGREGAR NUEVO USUARIO
                this.user = new Usuarios();
                this.user.Usuario = this.txtUsuario.Text;
                this.user.Clave = EncryptionHelper.Encrypt(this.txtClave.Text);
                if (this.chckbxActivo.Checked)
                {
                    this.user.Activo = true;
                }
                else this.user.Activo = false;
                if (this.cmbRol.SelectedIndex==0)
                { this.user.Rol = 1; }
                else if (this.cmbRol.SelectedIndex == 1)
                { this.user.Rol = 2; }
                else if (this.cmbRol.SelectedIndex == 2)
                { this.user.Rol = 3; }
                //this.user.Rol = int.Parse(this.cmbRol.Text);
                this.user.Nombre = this.txtNombre.Text;
                this.user.Apellido = this.txtApellido.Text;
                this.user.Correo = this.txtCorreo.Text;
                this.user.opc = 2;
                this.userHelper = new UsuariosHelper(user);
                ///LOG PARA USUARIOS
                LogMovimientos();
                
                this.userHelper.Guardar();
                MessageBox.Show("Usuario Almacenado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA
            if (this.txtUsuario.Text == "" || this.txtNombre.Text == "" ||  this.txtCorreo.Text == "" 
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
            #endregion
        }

        #region LIMPIAR CAMPOS
        public void limpiar()
        {
            this.txtApellido.Clear();
            this.txtClave.Clear();
            this.txtUsuario.Clear();
            this.txtConfirmar.Clear();
            this.txtNombre.Clear();
            this.cmbRol.SelectedIndex = -1;
            this.chckbxActivo.Checked = false;
            this.btnAdd.Text = "AGREGAR";
            this.txtUsuario.ReadOnly = false;
            this.txtCorreo.Clear();
        }
        #endregion

        private void GestorUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_CNVDataSet1.Rol' table. You can move, or remove it, as needed.
            
            listar();
            cargarCombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        #region ELIMINAR USUARIO
        private void eliminar()
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
                    ///LOG PARA ELIMINAR
                    ///
                    /*
                    this.bitacora = new Bitacora();
                    this.bitacora.Usuario = this.user.Usuario;
                    this.bitacora.Movimiento = "Eliminar";
                    this.bitacora.Detalle = "Se elimino el nuevo usuario " + fila["usuario"].ToString();
                    this.bitacora.opc = 5;
                    this.bitH = new BitacoraHelper(bitacora);
                    this.bitH.LogMovimientos();
                    */
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
        #endregion

        #region ACTUALIZAR USUARIO
        private void actualizar()
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
                if (this.cmbRol.SelectedIndex == 0)
                { this.user.Rol = 1; }
                else if (this.cmbRol.SelectedIndex == 1)
                { this.user.Rol = 2; }
                else if (this.cmbRol.SelectedIndex == 2)
                { this.user.Rol = 3; }
                this.user.Nombre = this.txtNombre.Text;
            this.user.Apellido = this.txtApellido.Text;
            this.user.Correo = this.txtCorreo.Text;
                this.user.opc = 4;
            
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
            this.userHelper.Actualizar();
            MessageBox.Show("Datos del Usuario actualizados");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
      
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void dgvListar_DoubleClick(object sender, EventArgs e)
        {
            CargarFromTable();
            }

        #region CARGAR DE TABLA
        private void CargarFromTable()
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
                    if (this.cmbRol.Text == "1")
                    {
                        this.cmbRol.SelectedIndex = 0;
                    }
                    else if (this.cmbRol.Text == "2")
                    {
                        this.cmbRol.SelectedIndex = 1;
                    }
                    else if (this.cmbRol.Text == "3")
                    {
                        this.cmbRol.SelectedIndex = 2;
                    }
                    this.txtNombre.Text = fila["nombre"].ToString();
                    this.txtApellido.Text = fila["apellido"].ToString();
                    this.txtUsuario.ReadOnly = true;
                    this.txtCorreo.Text = fila["correo"].ToString();
                    this.btnAdd.Text = "ACTUALIZAR";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        private void btnReport_Click(object sender, EventArgs e)
        {
            UsuariosReport report = new UsuariosReport();
            report.Show();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}