using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using QNS_SysInv_X.MVCController;
using System.Text.RegularExpressions;

namespace QNS_SysInv_X.MVCView
{
    public partial class GestorOportunidades : Form
    {
        private Oportunidades oportunidades;
        private OportunidadesHelper oportunidadesH;
        private Clientes clientes;
        private ClientesHelper clientesH;
        private Usuarios user;
        private Vendedores vendedores;
        private VendedoresHelper vendedoresH;
        private DataTable table;
        private Bitacora bitacora;
        private BitacoraHelper bitH;

        static Regex validate_emailaddress = RegexExpression.email_validation();
        static Regex validate_letter = RegexExpression.letter_validation();
        static Regex validate_number = RegexExpression.number_validation();
        static Regex validate_Spaces = RegexExpression.AvoidSpaces_validation();
        static Regex valida_numberandLetter = RegexExpression.numberANDletter_validation();
        static Regex OnlyLetterNumberssandSpaces = RegexExpression.OnlyLetterNumberssandSpaces();

        public GestorOportunidades()
        {
            InitializeComponent();
        }

        public GestorOportunidades(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsu.Text = this.user.Usuario;
        }

        #region LIMPIEZA DE ALERTAS
        private void limpiarAlertas()
        {
            lblNombreCliente.BackColor = System.Drawing.Color.White;
            lblNombreCliente.ForeColor = System.Drawing.Color.Black;
            gbClienteN.BackColor = System.Drawing.Color.White;
            lblMarca.BackColor = System.Drawing.Color.White;
            lblMarca.ForeColor = System.Drawing.Color.Black;
            gbMarca.BackColor = System.Drawing.Color.White;
            lblDetalles.BackColor = System.Drawing.Color.White;
            lblDetalles.ForeColor = System.Drawing.Color.Black;
            gbDetalles.BackColor = System.Drawing.Color.White;
            lblPresupuesto.BackColor = System.Drawing.Color.White;
            lblPresupuesto.ForeColor = System.Drawing.Color.Black;
            gbPresupuesto.BackColor = System.Drawing.Color.White;
            lblVendedor.BackColor = System.Drawing.Color.White;
            lblVendedor.ForeColor = System.Drawing.Color.Black;
            gbVendedor.BackColor = System.Drawing.Color.White;
        }
        #endregion

        #region CARGAR COMBOBOX DE VENDEDOR
        private void cargarComboVendedor()
        {
            try
            {
                this.vendedores = new Vendedores();
                this.vendedores.opc = 5;
                this.vendedoresH = new VendedoresHelper(vendedores);
                this.table = new DataTable();
                this.table = this.vendedoresH.Listar();

                if (this.table.Rows.Count > 0)
                {
                    this.cmbVendedor.DataSource = this.table;
                    cmbVendedor.ValueMember = "nombre";
                    cmbVendedor.DisplayMember = "nombre";
                    this.cmbCedVendedor.DataSource = this.table;
                    cmbCedVendedor.ValueMember = "cedula";
                    cmbCedVendedor.DisplayMember = "cedula";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region CARGAR COMBO BOX DE  CLIENTE
        private void cargarComboCliente()
        {
            try
            {
                this.clientes = new Clientes();
                this.clientes.opc = 5;
                this.clientesH = new ClientesHelper(clientes);
                this.table = new DataTable();
                this.table = this.clientesH.Listar();

                if (this.table.Rows.Count > 0)
                {
                    this.cmbNombre.DataSource = this.table;
                    cmbNombre.ValueMember = "nombre";
                    cmbNombre.DisplayMember = "nombre";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region LISTAR OPORTUNIDADES
        private void listar()
        {
            try
            {
                this.oportunidades = new Oportunidades();
                this.oportunidades.opc = 5;

                this.oportunidadesH = new OportunidadesHelper(oportunidades);

                this.table = new DataTable();
                this.table = this.oportunidadesH.Listar();

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


        #region GUARDAR OPORTUNIDAD
        //FUNCION AGREGAR NUEVO OPORTUNIDAD
        private void guardar()
        {
            try
            {
                //AGREGAR NUEVO USUARIO
                this.oportunidades = new Oportunidades();
                this.oportunidades.Nombrecliente = this.cmbNombre.Text;
                this.oportunidades.Fechacierre = this.dtpFecha.Value;
                this.oportunidades.Marca = this.txtMarca.Text.TrimEnd();
                this.oportunidades.Detalles = this.txtDetalles.Text.TrimEnd();
                this.oportunidades.Presupuesto = int.Parse(this.txtPresupuesto.Text.TrimEnd());
                this.oportunidades.Vendedor = int.Parse(this.cmbCedVendedor.Text);

                this.oportunidades.opc = 2;
                this.oportunidadesH = new OportunidadesHelper(oportunidades);
                ///LOG PARA USUARIOS

                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.stsUsu.Text;
                this.bitacora.Movimiento = "Oportunidad Insertada";
                this.bitacora.Detalle = "Se agregó la oportunidad correctamente. ";
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();

                this.oportunidadesH.Guardar();
                MessageBox.Show("Oportunidad  Almacenada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA
            if (this.cmbNombre.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("Debes de seleccionar un NOMBRE DE CLIENTE", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblNombreCliente.BackColor = System.Drawing.Color.DarkRed;
                lblNombreCliente.ForeColor = System.Drawing.Color.White;
                gbClienteN.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = cmbNombre;
                return;
            }
            else if (this.txtMarca.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo MARCA no puede estar vacío", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblMarca.BackColor = System.Drawing.Color.DarkRed;
                lblMarca.ForeColor = System.Drawing.Color.White;
                gbMarca.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtMarca;
                return;
            }
            else if (OnlyLetterNumberssandSpaces.IsMatch(txtMarca.Text) != true)
            {
                limpiarAlertas();
                MessageBox.Show("El campo MARCA solo permite números y letras", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblMarca.BackColor = System.Drawing.Color.DarkRed;
                lblMarca.ForeColor = System.Drawing.Color.White;
                gbMarca.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtMarca;
                return;
            }
            else if (this.txtPresupuesto.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo PRESUPUESTO no puede estar vacío", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblPresupuesto.BackColor = System.Drawing.Color.DarkRed;
                lblPresupuesto.ForeColor = System.Drawing.Color.White;
                gbPresupuesto.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtPresupuesto;
                return;
            }
            else if (validate_Spaces.IsMatch(txtPresupuesto.Text) != true)
            {
                limpiarAlertas();
                MessageBox.Show("No se permiten espacios en el campo presupuesto", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblPresupuesto.BackColor = System.Drawing.Color.DarkRed;
                lblPresupuesto.ForeColor = System.Drawing.Color.White;
                gbPresupuesto.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtPresupuesto;
                return;
            }
            else if (validate_number.IsMatch(txtPresupuesto.Text) != true)
            {
                limpiarAlertas();
                MessageBox.Show("El campo PRESUPUESTO solo permite numeros", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblPresupuesto.BackColor = System.Drawing.Color.DarkRed;
                lblPresupuesto.ForeColor = System.Drawing.Color.White;
                gbPresupuesto.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtPresupuesto;
                return;
            }
            else if (int.Parse(txtPresupuesto.Text) > 999999999 || int.Parse(txtPresupuesto.Text) < 100)
            {
                limpiarAlertas();
                MessageBox.Show("El campo PRESUPUESTO permite valores de $999999999 a $100", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblPresupuesto.BackColor = System.Drawing.Color.DarkRed;
                lblPresupuesto.ForeColor = System.Drawing.Color.White;
                gbPresupuesto.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtPresupuesto;
                return;
            }
            else if (this.txtDetalles.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo DETALLES no puede estar vacío", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblDetalles.BackColor = System.Drawing.Color.DarkRed;
                lblDetalles.ForeColor = System.Drawing.Color.White;
                gbDetalles.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtDetalles;
                return;
            }
            else if (this.cmbVendedor.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("Debes de seleccionar VENDEDOR", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblVendedor.BackColor = System.Drawing.Color.DarkRed;
                lblVendedor.ForeColor = System.Drawing.Color.White;
                gbVendedor.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = cmbVendedor;
                return;
            }
            else
            {
                if (this.cmbCedVendedor.Enabled == false)
                {
                    DialogResult dialogResult = MessageBox.Show("Desea actualizar la oportunidad?", "Actualizar", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        actualizar();
                        listar();
                        limpiar();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("No se actualizo la oportunidad", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            this.txtDetalles.Clear();
            this.txtMarca.Clear();
            this.txtPresupuesto.Clear();
            this.cmbNombre.SelectedIndex = -1;
            this.cmbVendedor.SelectedIndex = -1;
            this.cmbCedVendedor.Enabled = true;
            this.dtpFecha.Value = DateTime.Today;
            this.btnAdd.Text = "AGREGAR";
            limpiarAlertas();
        }
        #endregion
        
        #region ACTUALIZAR OPORTUNIDADES
        private void actualizar()
        {
            try
            {
                this.oportunidades = new Oportunidades();

                this.oportunidades.Nombrecliente = this.cmbNombre.Text.TrimEnd();
                this.oportunidades.Fechacierre = this.dtpFecha.Value;
                this.oportunidades.Marca = this.txtMarca.Text.TrimEnd();
                this.oportunidades.Detalles = this.txtDetalles.Text.TrimEnd();
                this.oportunidades.Presupuesto = int.Parse(this.txtPresupuesto.Text);
                this.oportunidades.Id = int.Parse(this.idl.Text);
                this.oportunidades.Vendedor = int.Parse(this.cmbCedVendedor.Text);
                this.oportunidades.opc = 4;

                this.oportunidadesH = new OportunidadesHelper(oportunidades);

                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.stsUsu.Text;
                this.bitacora.Movimiento = "Actualizar Oportunidad";
                this.bitacora.Detalle = "Se actualizó la oportunidad correctamente ";
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();

                this.oportunidadesH.Actualizar();
                MessageBox.Show("Datos de oportunidad actualizados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("No hay Registros de Oportunidades");
                }
                else
                {
                    int indice = dgvListar.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.cmbNombre.Text = fila["Nombre_Cliente"].ToString();
                    this.txtMarca.Text = fila["marca"].ToString();
                    this.txtDetalles.Text = fila["detalles"].ToString();
                    this.txtPresupuesto.Text = fila["presupuesto"].ToString();
                    this.cmbVendedor.Text = fila["Nombre_Vendedor"].ToString();
                    this.cmbCedVendedor.Text = fila["Cedula_Vendedor"].ToString();
                    this.cmbCedVendedor.Enabled = false;
                    this.dtpFecha.Text = fila["Fecha_de_Cierre"].ToString();
                    this.idl.Text = fila["ID"].ToString();
                    this.btnAdd.Text = "ACTUALIZAR";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void dgvListar_DoubleClick(object sender, EventArgs e)
        {
            CargarFromTable();
        }

        private void GestorOportunidades_Load(object sender, EventArgs e)
        {
            listar();
            this.ActiveControl = cmbNombre;
            dgvListar.AllowUserToAddRows = false;
            cargarComboVendedor();
            cargarComboCliente();
            this.cmbNombre.SelectedIndex = -1;
            this.cmbCedVendedor.SelectedIndex = -1;
            this.cmbVendedor.SelectedIndex = -1;
            foreach (DataGridViewColumn column in dgvListar.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "REPORTE OPORTUNIDADES  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                ReporteOpor RedOpo = new ReporteOpor(user);
                RedOpo.Show();
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void GestorOportunidades_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (this.cmbVendedor.Text != "" || this.cmbNombre.Text != "" || this.txtMarca.Text != ""
                || this.txtDetalles.Text != "" || this.txtPresupuesto.Text != "" || this.txtDetalles.Text != "")
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            #region BUSCQUEDA DE OPORTUNIDAD POR ID
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
                    this.oportunidades = new Oportunidades();
                    this.oportunidades.opc = 6;
                    this.oportunidades.Id = int.Parse(txtBuscar.Text);
                    this.oportunidadesH = new OportunidadesHelper(oportunidades);

                    this.table = new DataTable();
                    dgvListar.DataSource = table;
                    this.table = this.oportunidadesH.Buscar();

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
        
        private void txtDetalles_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtPresupuesto_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void cmbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }

        private void txtPresupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }

        private void txtDetalles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }
    }
}