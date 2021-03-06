using System;
using System.Data;
using System.Windows.Forms;
using QNS_SysInv_X.MVCController;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

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
        static Regex OnlyLettersandSpaces = RegexExpression.OnlyLettersandSpaces();
        
        public GestorUsuarios()
        {
            InitializeComponent();
        }

        public GestorUsuarios(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.toolStripStatusLabel2.Text = this.user.Usuario;
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
                this.user.opc = 1;
                //this.user.opc = 8;
                this.userHelper = new UsuariosHelper(user);
                this.table = new DataTable();
                this.table = this.userHelper.Listar();
                if (this.table.Rows.Count > 0)
                {
                    this.dataGridView1.DataSource = this.table;
                    this.dataGridView1.ReadOnly = true;
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

            if (!ValidarExistencia())
            {
                try
                {
                    //AGREGAR NUEVO USUARIO
                    this.user = new Usuarios();
                    this.user.Usuario = this.txtUsuario.Text.TrimEnd();
                    this.user.Clave = EncryptionHelper.Encrypt(this.txtClave.Text.TrimEnd());
                    if (this.chckbxActivo.Checked)
                    {
                        this.user.Activo = true;
                    }
                    else this.user.Activo = false;
                    this.user.Rol = this.cmbRol.SelectedIndex + 1;
                    this.user.Nombre = this.txtNombre.Text.TrimEnd();
                    this.user.Apellido = this.txtApellido.Text.TrimEnd();
                    this.user.Correo = this.txtCorreo.Text.TrimEnd();
                    this.user.opc = 2;
                    this.userHelper = new UsuariosHelper(user);
                    ///LOG PARA USUARIOS

                    this.bitacora = new Bitacora();
                    this.bitacora.Usuario = this.toolStripStatusLabel2.Text;
                    this.bitacora.Movimiento = "Agregar Usuario";
                    this.bitacora.Detalle = "Se agrego un nuevo usuario" + this.txtUsuario.Text;
                    this.bitacora.opc = 5;
                    this.bitH = new BitacoraHelper(bitacora);
                    this.bitH.LogMovimientos();

                    this.userHelper.Guardar();
                    MessageBox.Show("Usuario " + this.user.Usuario + " Almacenado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion

        private bool ValidarExistencia()
        {
            this.user = new Usuarios();
            this.user.Usuario = this.txtUsuario.Text;
            this.user.opc = 10;

            this.userHelper = new UsuariosHelper(user);
            this.table = new DataTable();
            this.table = this.userHelper.Validar();
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("El usuario " + this.txtUsuario.Text + " ya existe en la base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblUsuario.BackColor = System.Drawing.Color.DarkRed;
                lblUsuario.ForeColor = System.Drawing.Color.White;
                groupBox1.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtUsuario;
                return true;
            }
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA
            
                if (this.txtUsuario.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo de USUARIO esta vacío", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblUsuario.BackColor = System.Drawing.Color.DarkRed;
                    lblUsuario.ForeColor = System.Drawing.Color.White;
                    groupBox1.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtUsuario;
                    return;
                }
                else if (validate_numberANDletter.IsMatch(txtUsuario.Text) != true)
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo de USUARIO solo letras y numeros son permitio", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    lblUsuario.BackColor = System.Drawing.Color.DarkRed;
                    lblUsuario.ForeColor = System.Drawing.Color.White;
                    groupBox1.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtUsuario;
                    return;
                }
                else if (this.txtClave.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo CONTRASEÑA esta vacío", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblClave.BackColor = System.Drawing.Color.DarkRed;
                    lblClave.ForeColor = System.Drawing.Color.White;
                    groupBox2.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtClave;
                    return;
                }
                else if (validate_Spaces.IsMatch(txtClave.Text) != true)
                {
                    limpiarAlertas();
                    MessageBox.Show("No se permiten espacios en la CONTRASEÑA", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    lblClave.BackColor = System.Drawing.Color.DarkRed;
                    lblClave.ForeColor = System.Drawing.Color.White;
                    groupBox2.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtClave;
                    return;
                }
                else if (this.txtConfirmar.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo de CONFIRMAR esta vacío", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblConfirmar.BackColor = System.Drawing.Color.DarkRed;
                    lblConfirmar.ForeColor = System.Drawing.Color.White;
                    groupBox7.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = cmbRol;
                    return;
                }
                else if (this.cmbRol.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("Debes seleccionar una opción en Rol", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblRol.BackColor = System.Drawing.Color.DarkRed;
                    lblRol.ForeColor = System.Drawing.Color.White;
                    groupBox3.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtConfirmar;
                    return;
                }
                else if (this.cmbRol.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo ROL esta vacío", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbRol.BackColor = System.Drawing.Color.DarkRed;
                    cmbRol.ForeColor = System.Drawing.Color.White;
                    groupBox3.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = cmbRol;
                    return;
                }
                else if (this.txtNombre.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo NOMBRE esta vacío", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblNombre.BackColor = System.Drawing.Color.DarkRed;
                    lblNombre.ForeColor = System.Drawing.Color.White;
                    groupBox4.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtNombre;
                    return;
                }
                else if (OnlyLettersandSpaces.IsMatch(txtNombre.Text) != true)
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo NOMBRE solo permite letras", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombre.Text.Remove(txtNombre.Text.Length - 1);
                    lblNombre.BackColor = System.Drawing.Color.DarkRed;
                    lblNombre.ForeColor = System.Drawing.Color.White;
                    groupBox4.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtNombre;
                    return;
                }
                else if (this.txtApellido.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo APELLIDO esta vacío", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblApellido.BackColor = System.Drawing.Color.DarkRed;
                    lblApellido.ForeColor = System.Drawing.Color.White;
                    groupBox5.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtApellido;
                    return;
                }

                else if (OnlyLettersandSpaces.IsMatch(txtApellido.Text) != true)
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo APELLIDO solo permite letras", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtApellido.Text.Remove(txtApellido.Text.Length - 1);
                    lblApellido.BackColor = System.Drawing.Color.DarkRed;
                    lblApellido.ForeColor = System.Drawing.Color.White;
                    groupBox5.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtApellido;
                    return;
                }
                else if (this.txtCorreo.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo CORREO esta vacío", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblCorreo.BackColor = System.Drawing.Color.DarkRed;
                    lblCorreo.ForeColor = System.Drawing.Color.White;
                    groupBox8.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtCorreo;
                    return;
                }
                else if (validate_emailaddress.IsMatch(txtCorreo.Text) != true)
                {
                    limpiarAlertas();
                    MessageBox.Show("Formato Correo Inválido", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblCorreo.BackColor = System.Drawing.Color.DarkRed;
                    lblCorreo.ForeColor = System.Drawing.Color.White;
                    groupBox8.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtCorreo;
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
                                MessageBox.Show("No se actualizo el usuario", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Las claves deben ser iguales", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarAlertas();
                            lblClave.BackColor = System.Drawing.Color.DarkRed;
                            lblClave.ForeColor = System.Drawing.Color.White;
                            groupBox2.BackColor = System.Drawing.Color.DarkRed;
                            lblConfirmar.BackColor = System.Drawing.Color.DarkRed;
                            lblConfirmar.ForeColor = System.Drawing.Color.White;
                            groupBox7.BackColor = System.Drawing.Color.DarkRed;
                        }
                    }
                    else
                    {
                        if (this.txtClave.Text == this.txtConfirmar.Text)
                        {
                            guardar();
                            listar();
                        }
                        else
                        {
                            MessageBox.Show("Las claven deben ser iguales", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarAlertas();
                            lblClave.BackColor = System.Drawing.Color.DarkRed;
                            lblClave.ForeColor = System.Drawing.Color.White;
                            groupBox2.BackColor = System.Drawing.Color.DarkRed;
                            lblConfirmar.BackColor = System.Drawing.Color.DarkRed;
                            lblConfirmar.ForeColor = System.Drawing.Color.White;
                            groupBox7.BackColor = System.Drawing.Color.DarkRed;
                        }
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
            limpiarAlertas();
        }

        #endregion

        #region limpiar alertas
        private void limpiarAlertas()
        {
            lblCorreo.BackColor = System.Drawing.Color.White;
            lblCorreo.ForeColor = System.Drawing.Color.Black;
            groupBox8.BackColor = System.Drawing.Color.White;
            lblApellido.BackColor = System.Drawing.Color.White;
            lblApellido.ForeColor = System.Drawing.Color.Black;
            groupBox5.BackColor = System.Drawing.Color.White;
            lblNombre.BackColor = System.Drawing.Color.White;
            lblNombre.ForeColor = System.Drawing.Color.Black;
            groupBox4.BackColor = System.Drawing.Color.White;
            lblUsuario.BackColor = System.Drawing.Color.White;
            lblUsuario.ForeColor = System.Drawing.Color.Black;
            groupBox1.BackColor = System.Drawing.Color.White;
            lblClave.BackColor = System.Drawing.Color.White;
            lblClave.ForeColor = System.Drawing.Color.Black;
            groupBox2.BackColor = System.Drawing.Color.White;
            lblConfirmar.BackColor = System.Drawing.Color.White;
            lblConfirmar.ForeColor = System.Drawing.Color.Black;
            groupBox7.BackColor = System.Drawing.Color.White;
            cmbRol.BackColor = System.Drawing.Color.White;
            cmbRol.ForeColor = System.Drawing.Color.Black;
            groupBox3.BackColor = System.Drawing.Color.White;
            lblRol.BackColor = System.Drawing.Color.White;
            lblRol.ForeColor = System.Drawing.Color.Black;
            groupBox3.BackColor = System.Drawing.Color.White;
        }
        #endregion

        private void GestorUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_CNVDataSet1.Rol' table. You can move, or remove it, as needed.
            dataGridView1.AllowUserToAddRows = false;
            this.ActiveControl = txtUsuario;
            listar();
            cargarCombo();
            this.cmbRol.SelectedIndex = -1;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
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
        

        #region ACTUALIZAR USUARIO
        private void actualizar()
        {
            try
            {
                this.user = new Usuarios();
                this.user.Usuario = this.txtUsuario.Text.TrimEnd();
                this.user.Clave = EncryptionHelper.Encrypt(this.txtClave.Text).TrimEnd();
                if (this.chckbxActivo.Checked)
                {
                    this.user.Activo = true;
                }
                else { this.user.Activo = false; }
                this.user.Rol = this.cmbRol.SelectedIndex + 1;
                this.user.Nombre = this.txtNombre.Text.TrimEnd();
                this.user.Apellido = this.txtApellido.Text.TrimEnd();
                this.user.Correo = this.txtCorreo.Text.TrimEnd();
                this.user.opc = 4;
                this.userHelper = new UsuariosHelper(user);
                //Bitacora 
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.toolStripStatusLabel2.Text;
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
        
        private void dgvListar_DoubleClick(object sender, EventArgs e)
        {
            CargarFromTable();
        }

        #region CARGAR DE TABLA
        private void CargarFromTable()
        {
            try
            {
                this.table = (DataTable)this.dataGridView1.DataSource;
                if (table == null)
                {
                    MessageBox.Show("No hay Registros de Usuario para actualizar");
                }
                else
                {
                    int indice = dataGridView1.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.txtUsuario.Text = fila["Usuario"].ToString();
                    this.txtClave.Text = fila["Clave"].ToString();
                    this.txtConfirmar.Text = fila["Clave"].ToString();
                    this.chckbxActivo.Checked = bool.Parse(fila["activo"].ToString());
                    this.txtConfirmar.Text = "";
                    this.cmbRol.Text = fila["Nombre_Rol"].ToString();
                    this.txtNombre.Text = fila["Nombre"].ToString();
                    this.txtApellido.Text = fila["Apellido"].ToString();
                    this.txtUsuario.ReadOnly = true;
                    this.txtCorreo.Text = fila["Correo"].ToString();
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
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "REPORTE USUARIOS  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                ReporteUsuarios repU = new ReporteUsuarios(user);
                repU.Show();
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            #region BUSCAR USUARIO
            try
            {
                if (txtBuscar.Text == "")
                {
                    listar();
                }
                else if (validate_Spaces.IsMatch(txtBuscar.Text) != true)
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo de busqueda no permite espacios", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtBuscar.Text = txtBuscar.Text.Remove(txtBuscar.Text.Length - 1);
                    return;
                }
                else
                {
                    this.user = new Usuarios();
                    this.user.opc = 7;
                    this.user.Usuario = txtBuscar.Text;
                    this.userHelper = new UsuariosHelper(user);

                    this.table = new DataTable();
                    dataGridView1.DataSource = table;
                    this.table = this.userHelper.Buscar();

                    if (this.table.Rows.Count > 0)
                    {
                        this.dataGridView1.DataSource = this.table;
                        this.dataGridView1.ReadOnly = true;
                    }

                    else listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        private void GestorUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region VALIDACION DE CIERRE DE FORM
            if (this.txtUsuario.Text != "" || this.txtNombre.Text != "" || this.txtCorreo.Text != ""
            || this.txtApellido.Text != "" || this.txtClave.Text != "" || this.txtConfirmar.Text != ""
            || this.cmbRol.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Desea salir? Si sale se perderán lo datos ingresados", "SALIR", MessageBoxButtons.YesNo);
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
            #endregion
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = true;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = false;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            txtConfirmar.UseSystemPasswordChar = false;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            txtConfirmar.UseSystemPasswordChar = true;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        #region ACTIVAR O DESACTIVAR
        private void ActivarDesactivarUsuario()
        {
            try
            {
                if (this.dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debes seleccionar al menos un usuario para el Activar/Desactivar");
                }
                else
                {
                    int indice = dataGridView1.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.table = (DataTable)this.dataGridView1.DataSource;
                    this.textBox1.Text = fila["Usuario"].ToString();
                    this.user = new Usuarios();
                    //this.chckbxActivo.Checked = bool.Parse(fila["activo"].ToString());
                    if (activarToolStripMenuItem.Text == "Desactivar")
                    {
                        user.Usuario = this.textBox1.Text;
                        user.opc = 8;
                        this.userHelper = new UsuariosHelper(user);
                        this.userHelper.Buscar();

                        MessageBox.Show("Se desactivo el Usuario: " + user.Usuario);
                        //Bitacora 
                        this.bitacora = new Bitacora();
                        this.bitacora.Usuario = this.toolStripStatusLabel2.Text;
                        this.bitacora.Movimiento = "Inactivacion de Usuario";
                        this.bitacora.Detalle = "Se desactivo el usuario correctamente " + user.Usuario;
                        this.bitacora.opc = 5;
                        this.bitH = new BitacoraHelper(bitacora);
                        this.bitH.LogMovimientos();
                    }
                    else if (activarToolStripMenuItem.Text == "Activar")
                    {
                        user.Usuario = this.textBox1.Text;
                        user.opc = 9;
                        this.userHelper = new UsuariosHelper(user);
                        this.userHelper.Buscar();
                        MessageBox.Show("Se activo el Usuario: " + user.Usuario);
                        //Bitacora 
                        this.bitacora = new Bitacora();
                        this.bitacora.Usuario = this.toolStripStatusLabel2.Text;
                        this.bitacora.Movimiento = "Activación Usuario";
                        this.bitacora.Detalle = "Se activo el usuario correctamente " + user.Usuario;
                        this.bitacora.opc = 5;
                        this.bitH = new BitacoraHelper(bitacora);
                        this.bitH.LogMovimientos();
                    }
                    listar();
                    limpiar();
                    dataGridView1.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void activarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ActivarDesactivarUsuario();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            CargarFromTable();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            #region VALIDAR  VALOR DE TOOL STRIP VALUE
            try
            {
                int indice = dataGridView1.CurrentRow.Index;
                DataRow fila = table.Rows[indice];
                this.table = (DataTable)this.dataGridView1.DataSource;
                if (bool.Parse(fila["activo"].ToString()) == true)
                {
                    activarToolStripMenuItem.Text = "Desactivar";
                }
                else if (bool.Parse(fila["activo"].ToString()) == false)
                {
                    activarToolStripMenuItem.Text = "Activar";
                }
            }

            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            #endregion
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
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

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }
    }
}