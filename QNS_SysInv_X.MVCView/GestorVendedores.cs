using System;
using System.Data;
using System.Windows.Forms;
using QNS_SysInv_X.MVCController;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace QNS_SysInv_X.MVCView
{
    public partial class GestorVendedores : Form
    {
        private Vendedores vendedor;
        private Vendedores validar;
        private VendedoresHelper validarH;
        private VendedoresHelper vendedorH;
        private Usuarios user;
        private DataTable table;
        private Bitacora bitacora;
        private BitacoraHelper bitH;

        static Regex validate_emailaddress = RegexExpression.email_validation();
        static Regex validate_letter = RegexExpression.letter_validation();
        static Regex validate_number = RegexExpression.number_validation();
        static Regex validate_Spaces = RegexExpression.AvoidSpaces_validation();
        static Regex OnlyLetterNumberssandSpaces = RegexExpression.OnlyLetterNumberssandSpaces();
        static Regex OnlyLettersandSpaces = RegexExpression.OnlyLettersandSpaces();

        public GestorVendedores(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.toolStripStatusLabel1.Text = this.user.Usuario;
        }

        #region LIMPIAR ALERTAS
        private void limpiarAlertas()
        {
            lblCedula.BackColor = System.Drawing.Color.White;
            lblCedula.ForeColor = System.Drawing.Color.Black;
            gbCedula.BackColor = System.Drawing.Color.White;
            lblApellido2.BackColor = System.Drawing.Color.White;
            lblApellido2.ForeColor = System.Drawing.Color.Black;
            gbApellido2.BackColor = System.Drawing.Color.White;
            lblApellido1.BackColor = System.Drawing.Color.White;
            lblApellido1.ForeColor = System.Drawing.Color.Black;
            gbApellido1.BackColor = System.Drawing.Color.White;
            lblNombre.BackColor = System.Drawing.Color.White;
            lblNombre.ForeColor = System.Drawing.Color.Black;
            gbNombre.BackColor = System.Drawing.Color.White;
            gbGenero.BackColor = System.Drawing.Color.White;
            lblGenero.ForeColor = System.Drawing.Color.Black;
            lblGenero.BackColor = System.Drawing.Color.White;
            lblCorreo.BackColor = System.Drawing.Color.White;
            lblCorreo.ForeColor = System.Drawing.Color.Black;
            gbCorreo.BackColor = System.Drawing.Color.White;
        }
        #endregion

        public GestorVendedores()
        {
            InitializeComponent();
        }

        #region LISTAR VENDEDORES
        private void listar()
        {
            try
            {
                this.vendedor = new Vendedores();
                this.vendedor.opc = 1;

                this.vendedorH = new VendedoresHelper(vendedor);

                this.table = new DataTable();
                this.table = this.vendedorH.Listar();

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

        #region GUARDAR VENDEDOR
        //FUNCION AGREGAR NUEVO USUARIO
        private void guardar()
        {

            if (!ValidarExistencia())
            {
                try
                {
                    this.vendedor = new Vendedores();
                    this.vendedor.opc = 2;
                    this.vendedor.Cedula = int.Parse(this.txtCedula.Text.TrimEnd());
                    this.vendedor.Nombre = this.txtNombre.Text.TrimEnd();
                    this.vendedor.Apellido1 = this.txtApellido.Text.TrimEnd();
                    this.vendedor.Apellido2 = this.txtApellido2.Text.TrimEnd();
                    this.vendedor.Genero = this.cmbGenero.Text;
                    this.vendedor.Fechanacimiento = this.dtpFechaAnace.Value;
                    this.vendedor.Correo = this.txtCorreo.Text.TrimEnd();
                    if (this.chckbxActivo.Checked)
                    {
                        this.vendedor.Activo = true;
                    }
                    else this.vendedor.Activo = false;
                    this.vendedor.opc = 2;
                    this.vendedorH = new VendedoresHelper(vendedor);
                    ///LOG PARA USUARIOS
                    ///
                    this.bitacora = new Bitacora();
                    this.bitacora.Usuario = this.toolStripStatusLabel1.Text;
                    this.bitacora.Movimiento = "Ingreso vendedor";
                    this.bitacora.Detalle = "Se agrego el vendedor correctamente " + this.txtNombre.Text + " " + this.txtApellido.Text;
                    this.bitacora.opc = 5;
                    this.bitH = new BitacoraHelper(bitacora);
                    this.bitH.LogMovimientos();

                    this.vendedorH.Guardar();
                    MessageBox.Show("Vendedor  " + this.vendedor.Nombre + " Almacenado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
      
        private void GestorRespaldos_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtCedula;
            dgvListar.AllowUserToAddRows = false;
            listar();
            dgvListar.ClearSelection();
            foreach (DataGridViewColumn column in dgvListar.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        
        private void dgvListar_DoubleClick(object sender, EventArgs e)
        {
            CargarFromTable();
        }
        

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {
            if (validate_emailaddress.IsMatch(txtCorreo.Text) != true)
            {
                MessageBox.Show("Formato de Correo incorrecto!", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreo.Focus();
                return;
            }
            else
            {
            }

        }

        private bool ValidarExistencia()
           { 

            this.vendedor = new Vendedores();
            this.vendedor.Cedula = int.Parse(this.txtCedula.Text);
            this.vendedor.opc = 9;

            this.vendedorH = new VendedoresHelper(vendedor);
            this.table = new DataTable();
            this.table = this.vendedorH.Validar();
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("La cédula del vendedor  "+ this.txtCedula.Text+" ya existe en la base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblCedula.BackColor = System.Drawing.Color.DarkRed;
                lblCedula.ForeColor = System.Drawing.Color.White;
                gbCedula.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtCedula;
                return true;
            }
            else
            return false;
        }

    private void btnAdd_Click_1(object sender, EventArgs e)
        {
            #region VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA
            
                if (this.txtCedula.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo CÉDULA no puede estar vacío", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblCedula.BackColor = System.Drawing.Color.DarkRed;
                    lblCedula.ForeColor = System.Drawing.Color.White;
                    gbCedula.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtCedula;
                    return;
                }
                else if (validate_number.IsMatch(txtCedula.Text) != true)
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo CÉDULA solo permite numeros", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblCedula.BackColor = System.Drawing.Color.DarkRed;
                    lblCedula.ForeColor = System.Drawing.Color.White;
                    gbCedula.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtCedula;
                    return;
                }
                else if (this.txtApellido.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo PRIMER APELLIDO no puede estar vacío", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblApellido1.BackColor = System.Drawing.Color.DarkRed;
                    lblApellido1.ForeColor = System.Drawing.Color.White;
                    gbApellido1.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtApellido;
                    return;
                }
                else if (OnlyLettersandSpaces.IsMatch(txtApellido.Text) != true)
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo PRIMER APELLIDO solo permite letras", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblApellido1.BackColor = System.Drawing.Color.DarkRed;
                    lblApellido1.ForeColor = System.Drawing.Color.White;
                    gbApellido1.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtApellido;
                    return;
                }
                else if (this.cmbGenero.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo GÉNERO no puede estar vacío", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblGenero.BackColor = System.Drawing.Color.DarkRed;
                    lblGenero.ForeColor = System.Drawing.Color.White;
                    gbGenero.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = cmbGenero;
                    return;
                }
                else if (this.txtCorreo.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo CORREO no puede estar vacío", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblCorreo.BackColor = System.Drawing.Color.DarkRed;
                    lblCorreo.ForeColor = System.Drawing.Color.White;
                    gbCorreo.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtCorreo;
                    return;
                }
                else if (validate_emailaddress.IsMatch(txtCorreo.Text) != true)
                {
                    limpiarAlertas();
                    MessageBox.Show("Correo Inválido", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblCorreo.BackColor = System.Drawing.Color.DarkRed;
                    lblCorreo.ForeColor = System.Drawing.Color.White;
                    gbCorreo.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtCorreo;
                    return;
                }
                else if (this.txtNombre.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo NOMBRE no puede estar vacío", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblNombre.BackColor = System.Drawing.Color.DarkRed;
                    lblNombre.ForeColor = System.Drawing.Color.White;
                    gbNombre.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtNombre;
                    return;
                }

                else if (OnlyLettersandSpaces.IsMatch(txtNombre.Text) != true)
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo NOMBRE solo permite letras", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblNombre.BackColor = System.Drawing.Color.DarkRed;
                    lblNombre.ForeColor = System.Drawing.Color.White;
                    gbNombre.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtNombre;
                    return;
                }
                else if (this.txtApellido2.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo SEGUNDO APELLIDO no puede estar vacío", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblApellido2.BackColor = System.Drawing.Color.DarkRed;
                    lblApellido2.ForeColor = System.Drawing.Color.White;
                    gbApellido2.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtApellido2;
                    return;
                }
                else if (OnlyLettersandSpaces.IsMatch(txtApellido2.Text) != true)
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo SEGUNDO APELLIDO solo permite letras", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblApellido2.BackColor = System.Drawing.Color.DarkRed;
                    lblApellido2.ForeColor = System.Drawing.Color.White;
                    gbApellido2.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtApellido2;
                    return;
                }
                else
                {
                    if (this.txtCedula.ReadOnly)
                    {
                        DialogResult dialogResult = MessageBox.Show("Desea actualizar datos del vendedor", "Actualizar", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            actualizar();
                            listar();
                            limpiar();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("No se actualizó el vendedor", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        guardar();
                        listar();
                    }
                    #endregion
                }
            
        }
        #region LIMPIAR CAMPOS
        public void limpiar()
        {
            this.txtApellido.Clear();
            this.txtApellido2.Clear();
            this.txtCedula.Clear();
            this.txtCorreo.Clear();
            this.txtNombre.Clear();
            this.cmbGenero.SelectedIndex = -1;
            this.txtCedula.ReadOnly = false;
            this.dtpFechaAnace.Value = DateTime.Today;
            this.btnAdd.Text = "AGREGAR";
            this.chckbxActivo.Checked = false;
            this.textBox1.Clear();
            limpiarAlertas();
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
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
                this.vendedor = new Vendedores();
                this.vendedor.Cedula = int.Parse(this.txtCedula.Text.TrimEnd());
                this.vendedor.Nombre = this.txtNombre.Text.TrimEnd();
                this.vendedor.Apellido1 = this.txtApellido.Text.TrimEnd();
                this.vendedor.Apellido2 = this.txtApellido2.Text.TrimEnd();
                this.vendedor.Genero = this.cmbGenero.Text;
                this.vendedor.Fechanacimiento = this.dtpFechaAnace.Value;
                this.vendedor.Correo = this.txtCorreo.Text.TrimEnd();
                if (this.chckbxActivo.Checked)
                {
                    this.vendedor.Activo = true;
                }
                else this.vendedor.Activo = false;
                this.vendedor.opc = 4;

                this.vendedorH = new VendedoresHelper(vendedor);
                ///LOGS ACTUALIZAR USUARIO
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.toolStripStatusLabel1.Text;
                this.bitacora.Movimiento = "Actualizar Vendedor";
                this.bitacora.Detalle = "Se actualizo el vendedor correctamente " + this.txtNombre.Text + " " + this.txtApellido.Text ;
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();

                this.vendedorH.Actualizar();
                MessageBox.Show("Datos del Vendedor " + this.vendedor.Nombre + " actualizados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region CARGAR DE TABLA
        private void CargarFromTable()
        {
            try
            {
                this.table = (DataTable)this.dgvListar.DataSource;
                if (table == null)
                {
                    MessageBox.Show("No hay Registros de Vendedor para actualizar");
                }
                else
                {
                    int indice = dgvListar.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.txtCedula.Text = fila["Cedula"].ToString();
                    this.txtNombre.Text = fila["Nombre"].ToString();
                    this.txtApellido.Text = fila["Primer_Apellido"].ToString();
                    this.txtApellido2.Text = fila["Segundo_Apellido"].ToString();
                    this.txtCorreo.Text = fila["Correo"].ToString();
                    this.cmbGenero.Text = fila["Genero"].ToString();
                    this.txtCedula.ReadOnly = true;
                    this.dtpFechaAnace.Text = fila["Fecha_de_nacimiento"].ToString();
                    this.chckbxActivo.Checked = bool.Parse(fila["Activo"].ToString());
                    this.btnAdd.Text = "ACTUALIZAR";
                }
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

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "REPORTE VENDEDORES  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                ReporteVendedor repoVendedores = new ReporteVendedor(user);
                repoVendedores.Show();
                this.Close();
            }
        }

        private void GestorVendedores_FormClosing(object sender, FormClosingEventArgs e)
        {
                if (this.txtCedula.Text != "" || this.txtNombre.Text != "" || this.txtCorreo.Text != ""
                  || this.txtApellido.Text != "" || this.txtApellido2.Text != "" || this.cmbGenero.Text != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Desea salir? Si sale se perderán lo datos ingresados", "SALIR", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                    e.Cancel = false;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    e.Cancel =true;
                    }
                }
                else
            {
                e.Cancel = false;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            #region BUSQUEDA DE VENDEDOR
            try
            {
                if (txtBuscar.Text == "")
                {
                    listar();
                }
                else if (validate_number.IsMatch(txtBuscar.Text) != true)
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo de busqueda solo permite números", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtBuscar.Text = txtBuscar.Text.Remove(txtBuscar.Text.Length - 1);
                    return;
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
                    this.vendedor = new Vendedores();
                    this.vendedor.opc = 6;
                    this.vendedor.Cedula = int.Parse(txtBuscar.Text);
                    this.vendedorH = new VendedoresHelper(vendedor);

                    this.table = new DataTable();
                    dgvListar.DataSource = table;
                    this.table = this.vendedorH.Buscar();

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
            #endregion
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtApellido2_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void activarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivarDesactivarVendedor();
        }
        #region ACTIVAR DESACTIVAR
        private void ActivarDesactivarVendedor()
        {
            try
            {
                if (this.dgvListar.SelectedRows.Count == 0)
                {

                    MessageBox.Show("Debes seleccionar al menos un vendedor para Activar/Desactivar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int indice = dgvListar.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.table = (DataTable)this.dgvListar.DataSource;
                    this.textBox1.Text = fila["Cedula"].ToString();
                    this.vendedor = new Vendedores();
                    //    this.chckbxActivo.Checked = bool.Parse(fila["Activo"].ToString());
                    if (activarToolStripMenuItem.Text == "Desactivar")
                    {
                        vendedor.Cedula = int.Parse(fila["Cedula"].ToString());
                        vendedor.opc = 7;
                        this.vendedorH = new VendedoresHelper(vendedor);
                        this.vendedorH.Buscar();
                        MessageBox.Show("Se desactivo el vendedor");

                        this.bitacora = new Bitacora();
                        this.bitacora.Usuario = this.toolStripStatusLabel1.Text;
                        this.bitacora.Movimiento = "Inactivacion de Vendedor";
                        this.bitacora.Detalle = "Se desactivo el vendedor correctamente cédula: " + vendedor.Cedula;
                        this.bitacora.opc = 5;
                        this.bitH = new BitacoraHelper(bitacora);
                        this.bitH.LogMovimientos();
                    }
                    else if (activarToolStripMenuItem.Text == "Activar")
                    {
                        vendedor.Cedula = int.Parse(fila["Cedula"].ToString());
                        vendedor.opc = 8;
                        this.vendedorH = new VendedoresHelper(vendedor);
                        this.vendedorH.Buscar();
                        MessageBox.Show("Se activo el vendedor");

                        this.bitacora = new Bitacora();
                        this.bitacora.Usuario = this.toolStripStatusLabel1.Text;
                        this.bitacora.Movimiento = "Activación de vendedor";
                        this.bitacora.Detalle = "Se activo el vendedor correctamente cédula: " + vendedor.Cedula;
                        this.bitacora.opc = 5;
                        this.bitH = new BitacoraHelper(bitacora);
                        this.bitH.LogMovimientos();
                    }
                    listar();
                    limpiar();
                    dgvListar.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void dgvListar_Click(object sender, EventArgs e)
        {
            #region VLIDAR VALOR DE TOOL STRIP
            try
            {
                int indice = dgvListar.CurrentRow.Index;
                DataRow fila = table.Rows[indice];
                this.table = (DataTable)this.dgvListar.DataSource;
              //  this.chckbxActivo.Checked = bool.Parse(fila["Activo"].ToString());
                if (bool.Parse(fila["Activo"].ToString()) == true)
                {
                    activarToolStripMenuItem.Text = "Desactivar";
                }
                else if (bool.Parse(fila["Activo"].ToString()) == false)
                {
                    activarToolStripMenuItem.Text = "Activar";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }

        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            
        }
    }

}
