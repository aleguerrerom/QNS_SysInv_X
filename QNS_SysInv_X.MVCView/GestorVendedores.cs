using System;
using System.Data;
using System.Windows.Forms;
using QNS_SysInv_X.MVCController;
using System.Text.RegularExpressions;

namespace QNS_SysInv_X.MVCView
{
    public partial class GestorVendedores : Form
    {
        private Vendedores vendedor;
        private VendedoresHelper vendedorH;
        private Usuarios user;
        private DataTable table;
        private Bitacora bitacora;
        private BitacoraHelper bitH;

        static Regex validate_emailaddress = RegexExpression.email_validation();

        static Regex validate_letter = RegexExpression.letter_validation();

        static Regex validate_number = RegexExpression.number_validation();

        public GestorVendedores(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsu.Text = this.user.Usuario;
        }
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
            try
            {
                //AGREGAR NUEVO USUARIO
                this.vendedor = new Vendedores();
                this.vendedor.Cedula = int.Parse(this.txtCedula.Text);
                this.vendedor.Nombre = this.txtNombre.Text;
                this.vendedor.Apellido1 = this.txtApellido.Text;
                this.vendedor.Apellido2 = this.txtApellido2.Text;
                this.vendedor.Genero = this.cmbGenero.Text;
                this.vendedor.Fechanacimiento = this.dtpFechaAnace.Value;
                this.vendedor.Correo = this.txtCorreo.Text;
                this.vendedor.opc = 2;
                this.vendedorH = new VendedoresHelper(vendedor);
                ///LOG PARA USUARIOS
                ///
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.stsUsu.Text;
                this.bitacora.Movimiento = "Ingreso vendedor";
                this.bitacora.Detalle = "Se agrego el vendedor correctamente " + this.txtNombre.Text + " " + this.txtApellido.Text;
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();

                this.vendedorH.Guardar();
                MessageBox.Show("Vendedor  " + this.vendedor.Nombre + " Almacenado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
      
        private void GestorRespaldos_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtCedula;
            dgvListar.AllowUserToAddRows = false;
            listar();
        }
        
        private void dgvListar_DoubleClick(object sender, EventArgs e)
        {
            CargarFromTable();
        }
        

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {
            if (validate_emailaddress.IsMatch(txtCorreo.Text) != true)
            {
                MessageBox.Show("Formato de Correo incorrecto!", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreo.Focus();
                return;
            }
            else
            {
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            #region VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA
            if (this.txtCedula.Text == "") {
                limpiarAlertas();
                MessageBox.Show("El campo CEDULA no puede estar vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblCedula.BackColor = System.Drawing.Color.DarkRed;
                lblCedula.ForeColor = System.Drawing.Color.White;
                gbCedula.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtCedula;
                return;
            }
            else if (validate_number.IsMatch(txtCedula.Text) != true)
            {
                limpiarAlertas();
                MessageBox.Show("El campo CEDULA solo permite numeros", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblCedula.BackColor = System.Drawing.Color.DarkRed;
                lblCedula.ForeColor = System.Drawing.Color.White;
                gbCedula.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtCedula;
                return;
            }
            else if (this.txtApellido.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo PRIMER APELLIDO no puede estar vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblApellido1.BackColor = System.Drawing.Color.DarkRed;
                lblApellido1.ForeColor = System.Drawing.Color.White;
                gbApellido1.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtApellido;
                return;
            }
            else if (validate_letter.IsMatch(txtApellido.Text) != true)
            {
                limpiarAlertas();
                MessageBox.Show("El campo PRIMER APELLIDO solo permite letras", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblApellido1.BackColor = System.Drawing.Color.DarkRed;
                lblApellido1.ForeColor = System.Drawing.Color.White;
                gbApellido1.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtApellido;
                return;
            }
            else if (this.cmbGenero.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo GENERO no puede estar vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblGenero.BackColor = System.Drawing.Color.DarkRed;
                lblGenero.ForeColor = System.Drawing.Color.White;
                gbGenero.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = cmbGenero;
                return;
            }
            else if (this.txtCorreo.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo CORREO no puede estar vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblCorreo.BackColor = System.Drawing.Color.DarkRed;
                lblCorreo.ForeColor = System.Drawing.Color.White;
                gbCorreo.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtCorreo;
                return;
            }
            else if (validate_emailaddress.IsMatch(txtCorreo.Text) != true)
            {
                limpiarAlertas();
                MessageBox.Show("Correo Invalido", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblCorreo.BackColor = System.Drawing.Color.DarkRed;
                lblCorreo.ForeColor = System.Drawing.Color.White;
                gbCorreo.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtCorreo;
                return;
            }
            else if (this.txtNombre.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo NOMBRE no puede estar vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblNombre.BackColor = System.Drawing.Color.DarkRed;
                lblNombre.ForeColor = System.Drawing.Color.White;
                gbNombre.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtNombre;
                return;
            }

            else if (validate_letter.IsMatch(txtNombre.Text) != true)
            {
                limpiarAlertas();
                MessageBox.Show("El campo NOMBRE solo permite letras", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblNombre.BackColor = System.Drawing.Color.DarkRed;
                lblNombre.ForeColor = System.Drawing.Color.White;
                gbNombre.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtNombre;
                return;
            }
            else if (this.txtApellido2.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo SEGUNDO APELLIDO no puede estar vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblApellido2.BackColor = System.Drawing.Color.DarkRed;
                lblApellido2.ForeColor = System.Drawing.Color.White;
                gbApellido2.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtApellido2;
                return;
            }
            else if (validate_letter.IsMatch(txtApellido2.Text) != true)
            {
                limpiarAlertas();
                MessageBox.Show("El campo SEGUNDO APELLIDO solo permite letras", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show("No se eliminó el vendedor");
                    }
                }
                else
                {
                        guardar();
                        listar();
                        limpiar();
                }
            }
            #endregion
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

        #region ELIMINAR VENDEDOR
        private void eliminar()
        {/*
            try
            {
                this.table = (DataTable)this.dgvListar.DataSource;
                if (table == null)
                {
                    MessageBox.Show("No hay Vendedores para eliminar");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Desea eliminar los datos del vendedor??", "Eliminar", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int indice = dgvListar.CurrentRow.Index;
                        DataRow fila = table.Rows[indice];
                        this.vendedor = new Vendedores();
                        this.vendedor.Cedula = int.Parse(fila["cedula"].ToString());
                        this.vendedor.opc = 3;
                        this.vendedorH = new VendedoresHelper(vendedor);
                        ///LOG PARA ELIMINAR
                        ///

                        this.bitacora = new Bitacora();
                        this.bitacora.Usuario = this.stsUsuario.Text;
                        this.bitacora.Movimiento = "Eliminar Vendedor";
                        this.bitacora.Detalle = "Se elimino el vendedor " + fila["nombre"].ToString();
                        this.bitacora.opc = 5;
                        this.bitH = new BitacoraHelper(bitacora);
                        this.bitH.LogMovimientos();

                        this.vendedorH.Eliminar();
                        MessageBox.Show("Vendedor " + this.vendedor.Nombre + " Eliminado");
                        listar();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("No se elimino el vendedor");
                    }

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
                this.vendedor = new Vendedores();
                this.vendedor.Cedula = int.Parse(this.txtCedula.Text);
                this.vendedor.Nombre = this.txtNombre.Text;
                this.vendedor.Apellido1 = this.txtApellido.Text;
                this.vendedor.Apellido2 = this.txtApellido2.Text;
                this.vendedor.Genero = this.cmbGenero.Text;
                this.vendedor.Fechanacimiento = this.dtpFechaAnace.Value;
                this.vendedor.Correo = this.txtCorreo.Text;
                this.vendedor.opc = 4;

                this.vendedorH = new VendedoresHelper(vendedor);
                ///LOGS ACTUALIZAR USUARIO
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.stsUsu.Text;
                this.bitacora.Movimiento = "Actualizar Vendedor";
                this.bitacora.Detalle = "Se actualizo el vendedor correctamente " + this.txtNombre.Text + " " + this.txtApellido.Text ;
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();

                this.vendedorH.Actualizar();
                MessageBox.Show("Datos del Vendedor " + this.vendedor.Nombre + " actualizados");
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
                    this.btnAdd.Text = "ACTUALIZAR";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminar();
            listar();
        }

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
                ReporteVendedores repoVendedores = new ReporteVendedores(user);
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
            try
            {
                if (txtBuscar.Text == "")
                {
                    listar();
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
        }
    }

}
