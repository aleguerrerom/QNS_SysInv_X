using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QNS_SysInv_X.MVCController;
using System.Text.RegularExpressions;

namespace QNS_SysInv_X.MVCView.Resources
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
        
        static Regex validate_emailaddress = RegexExpression.email_validation();

        static Regex validate_letter = RegexExpression.letter_validation();

        static Regex validate_number = RegexExpression.number_validation();

        static Regex validate_numberANDletter = RegexExpression.numberANDletter_validation();

        static Regex validate_Spaces = RegexExpression.AvoidSpaces_validation();
        
        public GestorUsuarios()
        {
            InitializeComponent();
        }
        
        public GestorUsuarios(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsuario.Text = this.user.Usuario;
        }
        

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region LISTAR USUARIOS
        private void listar()
        {
            try
            {
                this.user = new Usuarios();
                //this.user.opc = 1;
                this.user.opc = 8;
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
                this.user.Rol = this.cmbRol.SelectedIndex + 1;
                this.user.Nombre = this.stsUsuario.Text;
                this.user.Apellido = this.txtApellido.Text;
                this.user.Correo = this.txtCorreo.Text;
                this.user.opc = 2;
                this.userHelper = new UsuariosHelper(user);
                ///LOG PARA USUARIOS

                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.user.Usuario;
                this.bitacora.Movimiento = "Agregar Usuario";
                this.bitacora.Detalle = "Se agrego un nuevo usuario" + this.txtUsuario;
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();

                this.userHelper.Guardar();
                MessageBox.Show("Usuario "+this.user.Usuario+" Almacenado");
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
            if (this.txtUsuario.Text == "" || this.txtNombre.Text == "" || this.txtCorreo.Text == ""
             || this.txtApellido.Text == "" || this.txtClave.Text == "" || this.txtConfirmar.Text == "")
            {
                MessageBox.Show("Tienes que llenar todos los campos, para agregar o actualizar");
            }
            else if (validate_emailaddress.IsMatch(txtCorreo.Text) != true)
            {
                MessageBox.Show("Correo Invalido", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreo.Focus();
                return;
            }

            else if (validate_letter.IsMatch(txtApellido.Text) != true)
            {
                MessageBox.Show("El campo PRIMER APELLIDO solo permite letras", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApellido.Text.Remove(txtApellido.Text.Length - 1);
                txtApellido.Focus();
            }

            else if (validate_letter.IsMatch(txtNombre.Text) != true)
            {
                MessageBox.Show("El campo NOMBRE solo permite letras", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Text.Remove(txtNombre.Text.Length - 1);
                txtNombre.Focus();
            }
            else if (validate_numberANDletter.IsMatch(txtUsuario.Text) != true)
            {
                MessageBox.Show("El campo de USUARIO solo letras y numeros son permitio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Focus();
                return;
            }
            else if (validate_Spaces.IsMatch(txtClave.Text) != true)
            {
                MessageBox.Show("No se permiten espacios en la Clave", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtClave.Focus();
                return;
            }
            else if (validate_numberANDletter.IsMatch(txtUsuario.Text) != true)
            {
                MessageBox.Show("Solo letras y numeros son permitios en campo de Usuario", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Focus();
                return;
            }

            else
            {
                if (this.txtUsuario.ReadOnly)
                {
                    if (this.txtClave.Text == this.txtConfirmar.Text)
                    {

                        DialogResult dialogResult = MessageBox.Show("Desea actualizar el usuario?", "Actualizar", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            actualizar();
                            listar();
                            limpiar();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("No se actualizo el usuario");
                        }
                    
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
            DialogResult dialogResult = MessageBox.Show("Desea borrar los datos ingresados?", "SALIR", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                limpiar();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        #region ELIMINAR USUARIO
        private void eliminar()
        {/*
            try
            {
                this.table = (DataTable)this.dgvListar.DataSource;
                if (table == null)
                {
                    MessageBox.Show("No hay Usuarios para eliminar");
                }
                else
                {

                    DialogResult dialogResult = MessageBox.Show("Desea eliminar el usuario", "Eliminar", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int indice = dgvListar.CurrentRow.Index;
                        DataRow fila = table.Rows[indice];
                        this.user = new Usuarios();
                        this.user.Usuario = fila["usuario"].ToString();
                        this.user.opc = 3;
                        this.userHelper = new UsuariosHelper(user);
                        ///LOG PARA ELIMINAR
                        ///

                        this.bitacora = new Bitacora();
                        this.bitacora.Usuario = this.stsUsuario.Text;
                        this.bitacora.Movimiento = "Eliminar Usuario";
                        this.bitacora.Detalle = "Se elimino el usuario " + fila["usuario"].ToString();
                        this.bitacora.opc = 5;
                        this.bitH = new BitacoraHelper(bitacora);
                        this.bitH.LogMovimientos();

                        this.userHelper.Eliminar();
                        MessageBox.Show("Usuario " + this.user.Usuario + " Eliminado");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("No se elimino el usuario");
                    }
                    
                    listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
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
                else { this.user.Activo = false; }
            this.user.Rol = this.cmbRol.SelectedIndex +1;
            this.user.Nombre = this.txtNombre.Text;
            this.user.Apellido = this.txtApellido.Text;
            this.user.Correo = this.txtCorreo.Text;
            this.user.opc = 4;
            this.userHelper = new UsuariosHelper(user);
            //Bitacora 
            this.bitacora = new Bitacora();
            this.bitacora.Usuario = this.stsUsuario.Text;
            this.bitacora.Movimiento = "Actualizar Usuario";
            this.bitacora.Detalle = "Se actualizo el usuario correctamente " + this.txtUsuario.Text;
            this.bitacora.opc = 5;
            this.bitH = new BitacoraHelper(bitacora);
            this.bitH.LogMovimientos();
            
            this.userHelper.Actualizar();
            MessageBox.Show("Datos del Usuario " + this.user.Usuario + " actualizados");
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
                    this.txtClave.Text = EncryptionHelper.Decrypt(fila["clave"].ToString());
                    this.txtConfirmar.Text = EncryptionHelper.Decrypt(fila["clave"].ToString());
                    this.chckbxActivo.Checked = bool.Parse(fila["activo"].ToString());
                    this.txtConfirmar.Text = "";
                    this.cmbRol.Text = fila["Nombre_Rol"].ToString();
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
            ReporteUsuarios repU = new ReporteUsuarios();
            repU.Show();
            this.Close();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
             if (this.txtUsuario.Text != "" || this.txtNombre.Text != "" || this.txtCorreo.Text != ""
             || this.txtApellido.Text != "" || this.txtClave.Text != "" || this.txtConfirmar.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Desea salir? Si sale se eliminaran lo datos ingresados", "SALIR", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
            else
                this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text == "")
                {
                    listar();
                }
                else
                {
                    this.user = new Usuarios();
                    this.user.opc = 7;
                    this.user.Usuario = txtBuscar.Text;
                    this.userHelper = new UsuariosHelper(user);

                    this.table = new DataTable();
                    dgvListar.DataSource = table;
                    this.table = this.userHelper.Buscar();

                    if (this.table.Rows.Count > 0)
                    {
                        this.dgvListar.DataSource = this.table;
                        this.dgvListar.ReadOnly = true;
                    }

                    else listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GestorUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.txtUsuario.Text != "" || this.txtNombre.Text != "" || this.txtCorreo.Text != ""
            || this.txtApellido.Text != "" || this.txtClave.Text != "" || this.txtConfirmar.Text != "")
            { 
                DialogResult dialogResult = MessageBox.Show("Desea salir? Si sale se perderan lo datos ingresados", "SALIR", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}