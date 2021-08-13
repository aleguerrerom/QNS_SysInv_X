using System;
using System.Data;
using System.Windows.Forms;
using QNS_SysInv_X.MVCController;
using System.Text.RegularExpressions;

namespace QNS_SysInv_X.MVCView
{
    public partial class GestorEntregas : Form
    {
        public GestorEntregas()
        {
            InitializeComponent();
        }

        public GestorEntregas(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsua.Text = this.user.Usuario;
        }
        private Bitacora bitacora;
        private BitacoraHelper bitH;
        private Entrega entrega;
        private EntregaHelper entregaH;
        private Usuarios user;
        private Clientes clientes;
        private DataTable table;
        private ClientesHelper clientesH;

        static Regex validate_emailaddress = RegexExpression.email_validation();
        static Regex validate_Spaces = RegexExpression.AvoidSpaces_validation();
        static Regex validate_letter = RegexExpression.letter_validation();
        static Regex validate_numberANDletter = RegexExpression.numberANDletter_validation();
        static Regex OnlyLetterNumberssandSpaces = RegexExpression.OnlyLetterNumberssandSpaces();
        static Regex validate_number = RegexExpression.number_validation();

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                    this.cmbCliente.DataSource = this.table;
                    cmbCliente.ValueMember = "nombre";
                    cmbCliente.DisplayMember = "nombre";
                    this.cmbNombre.DataSource = this.table;
                    cmbNombre.ValueMember = "contacto";
                    cmbNombre.DisplayMember = "contacto";
                    this.cmbTelefono.DataSource = this.table;
                    cmbTelefono.ValueMember = "telefono";
                    cmbTelefono.DisplayMember = "telefono";
                    this.cmbDireccion.DataSource = this.table;
                    cmbDireccion.ValueMember = "direcion";
                    cmbDireccion.DisplayMember = "direcion";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #region GUARDAR entrega
        //FUNCION AGREGAR NUEVO USUARIO
        private void guardar()
        {
            try
            {
                //AGREGAR NUEVO USUARIO 
                this.entrega = new Entrega();
                this.entrega.Cliente = this.cmbCliente.Text;
                this.entrega.Fecha = this.dtpFecha.Value;
                this.entrega.Contacto = this.cmbNombre.Text;
                this.entrega.Dirrecion = this.cmbDireccion.Text;
                this.entrega.EntregadoPor = this.txtEntregadoPor.Text.TrimEnd();
                this.entrega.Telefono = this.cmbTelefono.Text.TrimEnd();
                this.entrega.NumeroFactura = this.txtNumFactura.Text.TrimEnd();

                this.entrega.opc = 2;
                this.entregaH = new EntregaHelper(entrega);
                ///LOG PARA USUARIOS
                ///
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.stsUsua.Text;
                this.bitacora.Movimiento = "Proceso entrega";
                this.bitacora.Detalle = "Se proceso la entrega correctamente";
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();

                this.entregaH.Entrega();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
        
        private void limpiar()
        {
            this.cmbCliente.Text = "";
            this.txtSN.Text = "";
            this.txtNumParte.Text = "";
            this.dtpFecha.Value = DateTime.Today;
            this.cmbCliente.Text = "";
            this.txtCantidad.Text = "";
            this.txtDescripcion.Text = "";
            this.txtEntregadoPor.Text = "";
            this.cmbNombre.Text = "";
            limpiarAlertas();
        }

        private void limpiarArticulos()
        {
            this.txtSN.Text = "";
            this.txtNumParte.Text = "";
            this.txtCantidad.Text = "";
            this.txtDescripcion.Text = "";
            limpiarAlertas();
        }
        
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "REPORTE ENTREGA  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                if (this.cmbCliente.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo de CLIENTE esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblCliente.BackColor = System.Drawing.Color.DarkRed;
                    lblCliente.ForeColor = System.Drawing.Color.White;
                    gbCliente.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = cmbCliente;
                    return;
                }
                else if (this.cmbDireccion.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo de DIRECCIÓN esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblDireccion.BackColor = System.Drawing.Color.DarkRed;
                    lblDireccion.ForeColor = System.Drawing.Color.White;
                    gbDireccion.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = cmbDireccion;
                }
                else if (this.cmbCliente.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo de CONTACTO esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblContacto.BackColor = System.Drawing.Color.DarkRed;
                    lblContacto.ForeColor = System.Drawing.Color.White;
                    gpContacto.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = cmbCliente;
                }
                else if (this.txtEntregadoPor.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo ENTREGADO POR no puede ir vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblEntregado.BackColor = System.Drawing.Color.DarkRed;
                    lblEntregado.ForeColor = System.Drawing.Color.White;
                    gpEntregado.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtEntregadoPor;
                }
                else if (OnlyLetterNumberssandSpaces.IsMatch(txtEntregadoPor.Text) != true)
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo ENTREGADO POR solo permite letras y numeros", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblEntregado.BackColor = System.Drawing.Color.DarkRed;
                    lblEntregado.ForeColor = System.Drawing.Color.White;
                    gpEntregado.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtEntregadoPor;
                }
                
                else if (this.txtNumFactura.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo NUMERO DE FACTURA no puede ir vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    label1.BackColor = System.Drawing.Color.DarkRed;
                    label1.ForeColor = System.Drawing.Color.White;
                    gpNumFactura.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtNumFactura;
                }
                else if (validate_numberANDletter.IsMatch(txtNumFactura.Text) != true)
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo NUMERO DE FACTURA solo permite letras y numeros", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    label1.BackColor = System.Drawing.Color.DarkRed;
                    label1.ForeColor = System.Drawing.Color.White;
                    gpNumFactura.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtNumFactura;
                }

                else if (this.cmbTelefono.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo de TELEFONO no puede estar esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    label2.BackColor = System.Drawing.Color.DarkRed;
                    label2.ForeColor = System.Drawing.Color.White;
                    gbTelefono.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = cmbTelefono;
                }
                else if (dgvListar.RowCount == 0)
                {
                    limpiarAlertas();
                    MessageBox.Show("Debes incluir al menos un articulos a la entrega", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.ActiveControl = txtSN;
                }
                else
                {
                    Entrega entrega = new Entrega();
                    ReporteEntrega repoEntrega = new ReporteEntrega(user);
                    entrega.Cliente = cmbCliente.Text;
                    entrega.EntregadoPor = txtEntregadoPor.Text;
                    entrega.Contacto = cmbNombre.Text;
                    entrega.Fecha = dtpFecha.Value;
                    entrega.Dirrecion = cmbDireccion.Text;
                    entrega.NumeroFactura = txtNumFactura.Text;
                    entrega.Telefono = cmbTelefono.Text;
                    repoEntrega.entregaLista.Add(entrega);

                    for (int i = 0; i < dgvListar.RowCount; i++)
                    {
                        Entrega loop = new Entrega();
                        loop.NumeroDeParte = this.dgvListar.Rows[i].Cells[0].Value.ToString();
                        loop.Cantidad = this.dgvListar.Rows[i].Cells[1].Value.ToString();
                        loop.Descripcion = this.dgvListar.Rows[i].Cells[2].Value.ToString();
                        loop.NumeroDeSerie = this.dgvListar.Rows[i].Cells[3].Value.ToString();
                        repoEntrega.entregaLista.Add(loop);
                    }
                    guardar();
                    repoEntrega.ShowDialog();
                }
            }
        }

        private void limpiarAlertas()
        {
            lblCliente.BackColor = System.Drawing.Color.White;
            lblCliente.ForeColor = System.Drawing.Color.Black;
            gbCliente.BackColor = System.Drawing.Color.White;
            lblDireccion.BackColor = System.Drawing.Color.White;
            lblDireccion.ForeColor = System.Drawing.Color.Black;
            gbDireccion.BackColor = System.Drawing.Color.White;
            lblNS.BackColor = System.Drawing.Color.White;
            lblNS.ForeColor = System.Drawing.Color.Black;
            gpSN.BackColor = System.Drawing.Color.White;
            lblDescripcion.BackColor = System.Drawing.Color.White;
            lblDescripcion.ForeColor = System.Drawing.Color.Black;
            gpDescripcion.BackColor = System.Drawing.Color.White;
            lblMarca.BackColor = System.Drawing.Color.White;
            lblMarca.ForeColor = System.Drawing.Color.Black;
            gpMarca.BackColor = System.Drawing.Color.White;
            lblContacto.BackColor = System.Drawing.Color.White;
            lblContacto.ForeColor = System.Drawing.Color.Black;
            gpContacto.BackColor = System.Drawing.Color.White;
            lblCantidad.BackColor = System.Drawing.Color.White;
            lblCantidad.ForeColor = System.Drawing.Color.Black;
            gpCantidad.BackColor = System.Drawing.Color.White;
            lblEntregado.BackColor = System.Drawing.Color.White;
            lblEntregado.ForeColor = System.Drawing.Color.Black;
            gpEntregado.BackColor = System.Drawing.Color.White;
            label1.BackColor = System.Drawing.Color.White;
            label1.ForeColor = System.Drawing.Color.Black;
            gpNumFactura.BackColor = System.Drawing.Color.White;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA

            if (this.txtSN.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo de Numero de Serie esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblNS.BackColor = System.Drawing.Color.DarkRed;
                lblNS.ForeColor = System.Drawing.Color.White;
                gpSN.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtSN;
            }
            else if (this.txtDescripcion.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo de DESCRIPCIÓN esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblDescripcion.BackColor = System.Drawing.Color.DarkRed;
                lblDescripcion.ForeColor = System.Drawing.Color.White;
                gpDescripcion.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtDescripcion;
            }
           
            else if (this.txtCantidad.Text == "" || String.IsNullOrEmpty(txtCantidad.Text))
            {
                limpiarAlertas();
                MessageBox.Show("El campo de CANTIDAD esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblCantidad.BackColor = System.Drawing.Color.DarkRed;
                lblCantidad.ForeColor = System.Drawing.Color.White;
                gpCantidad.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtCantidad;
            }
            else if (validate_Spaces.IsMatch(txtCantidad.Text) != true)
            {
                limpiarAlertas();
                MessageBox.Show("El campo de CANTIDAD no puede tener espacios", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblCantidad.BackColor = System.Drawing.Color.DarkRed;
                lblCantidad.ForeColor = System.Drawing.Color.White;
                gpCantidad.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtCantidad;
            }
            else if (validate_number.IsMatch(txtCantidad.Text) != true)
            {
                limpiarAlertas();
                MessageBox.Show("El campo de CANTIDAD solo puede tener números", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblCantidad.BackColor = System.Drawing.Color.DarkRed;
                lblCantidad.ForeColor = System.Drawing.Color.White;
                gpCantidad.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtCantidad;
            }
            else if (validate_Spaces.IsMatch(txtCantidad.Text) != true)
            {
                MessageBox.Show("No se permiten espacios en el campo cantidad", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblCantidad.BackColor = System.Drawing.Color.DarkRed;
                lblCantidad.ForeColor = System.Drawing.Color.White;
                gpCantidad.BackColor = System.Drawing.Color.DarkRed;
                txtCantidad.Focus();
                return;
            }
            else if (this.txtNumParte.Text == "" || String.IsNullOrEmpty(txtNumFactura.Text))
            {
                limpiarAlertas();
                MessageBox.Show("El campo de NUMERO DE PARTE esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblMarca.BackColor = System.Drawing.Color.DarkRed;
                lblMarca.ForeColor = System.Drawing.Color.White;
                gpMarca.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtNumParte;
            }
            else
            {
                this.dgvListar.Rows.Add(this.txtNumParte.Text, int.Parse(this.txtCantidad.Text), this.txtDescripcion.Text, this.txtSN.Text);
                limpiarArticulos();
            }
            #endregion
        }

        #region CARGAR DE TABLA
        private void CargarFromTable()
        {
            //try
            //{
            //    this.table = (DataTable)this.dgvListar.DataSource;
            //    if (table == null)
            //    {
            //        MessageBox.Show("No hay Entregas para actualizar");
            //    }
            //    else
            //    {
            //        int indice = dgvListar.CurrentRow.Index;
            //        DataRow fila = table.Rows[indice];
            //        this.txtCliente.Text = fila["cliente"].ToString();
            //        this.txtTipo.Text = fila["tipo"].ToString();
            //        this.dtpFecha.Text = fila["fecha"].ToString();
            //        this.txtContacto.Text = fila["contacto"].ToString();
            //        this.txtDireccion.Text = fila["direccion"].ToString();
            //        this.txtNumParte.Text = fila["marca"].ToString();
            //        this.txtSN.Text = fila["numeroDeSerie"].ToString();
            //        this.txtCantidad.Text = fila["cantidad"].ToString();
            //        this.txtDescripcion.Text = fila["descripcion"].ToString();
            //        this.txtEntregadoPor.Text = fila["entregadoPor"].ToString();
            //        this.btnAdd.Text = "ACTUALIZAR";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        #endregion

        private void Entregas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.cmbCliente.Text != "" || this.txtSN.Text != "" || this.txtNumParte.Text != "" || this.cmbDireccion.Text != ""
                || this.txtCantidad.Text != "" || this.txtDescripcion.Text != "" || this.txtEntregadoPor.Text != "" || this.cmbNombre.Text != "")
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

        private void Entregas_Load(object sender, EventArgs e)
        {
            cargarComboCliente();
            this.ActiveControl = cmbCliente;
            dgvListar.AllowUserToAddRows = false;
            cmbCliente.SelectedIndex = -1;
            cmbDireccion.SelectedIndex = -1;
            cmbNombre.SelectedIndex = -1;
            cmbTelefono.SelectedIndex = -1;
            foreach (DataGridViewColumn column in dgvListar.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void dgvListar_DoubleClick(object sender, EventArgs e)
        {
            CargarFromTable();
        }
        
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvListar.SelectedRows)
            {
                dgvListar.Rows.RemoveAt(item.Index);
                dgvListar.Refresh();
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtEntregadoPor_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtNumFactura_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void cmbNombre_SelectedValueChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void cmbDireccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void cmbTelefono_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtEntregadoPor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }

        private void txtNumFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }

        private void txtSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }

        private void txtNumParte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }
    }
}