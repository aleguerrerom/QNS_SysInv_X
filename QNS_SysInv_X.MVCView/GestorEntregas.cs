using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.stsUsuario.Text = this.user.Usuario;
        }
        private DataTable table;
        private Bitacora bitacora;
        private BitacoraHelper bitH;
        private Entrega entrega;
        private EntregaHelper entregaH;
        private Usuarios user;
        private RegexExpression regexEx;

        static Regex validate_emailaddress = RegexExpression.email_validation();
        
        static Regex validate_Spaces = RegexExpression.AvoidSpaces_validation();

        static Regex validate_letter = RegexExpression.letter_validation();

        static Regex validate_number = RegexExpression.number_validation();

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
                    this.Close();
        }

        #region LISTAR entrega
        private void listar()
        {
            try
            {
                this.entrega = new Entrega();
                this.entrega.Opc = 1;
                this.entregaH = new EntregaHelper(entrega);
                this.table = new DataTable();
                this.table = this.entregaH.Listar();

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

        #region GUARDAR entrega
        //FUNCION AGREGAR NUEVO USUARIO
        private void guardar()
        {
            try
            {
                //AGREGAR NUEVO USUARIO int.Parse(
                this.entrega = new Entrega();
                this.entrega.Cliente = this.txtCliente.Text;
                this.entrega.Tipo = this.txtTipo.Text;
                this.entrega.NumeroDeSerie = this.txtSN.Text;
                this.entrega.Marca = this.txtMarca.Text;
                this.entrega.Fecha = this.dtpFecha.Value;
                this.entrega.Contacto = this.txtContacto.Text;
                this.entrega.Dirrecion = this.txtDireccion.Text;
                this.entrega.Cantidad = int.Parse(this.txtCantidad.Text);
                this.entrega.Descripcion = this.txtDescripcion.Text;
                this.entrega.EntregadoPor = this.txtEntregadoPor.Text;
                
                this.entrega.Opc = 2;
                this.entregaH = new EntregaHelper(entrega);
                ///LOG PARA USUARIOS
                ///
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.stsUsuario.Text;
                this.bitacora.Movimiento = "Ingreso entrega";
                this.bitacora.Detalle = "Se proceso la entrega correctamente";
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();

                this.entregaH.Entrega();
                MessageBox.Show("Entrega almacenada");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region GUARDAR entrega
        //FUNCION AGREGAR NUEVO USUARIO
        private void actualizar()
        {
            try
            {
                //AGREGAR NUEVO USUARIO int.Parse(
                this.entrega = new Entrega();
                this.entrega.Cliente = this.txtCliente.Text;
                this.entrega.Tipo = this.txtTipo.Text;
                this.entrega.NumeroDeSerie = this.txtSN.Text;
                this.entrega.Marca = this.txtMarca.Text;
                this.entrega.Fecha = this.dtpFecha.Value;
                this.entrega.Contacto = this.txtContacto.Text;
                this.entrega.Dirrecion = this.txtDireccion.Text;
                this.entrega.Cantidad = int.Parse(this.txtCantidad.Text);
                this.entrega.Descripcion = this.txtDescripcion.Text;
                this.entrega.EntregadoPor = this.txtEntregadoPor.Text;
                this.entrega.Id = int.Parse(this.txtID.Text);

                this.entrega.Opc = 3;
                this.entregaH = new EntregaHelper(entrega);
                ///LOG PARA USUARIOS
                ///
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.stsUsuario.Text;
                this.bitacora.Movimiento = "Actualización de entrega";
                this.bitacora.Detalle = "Se actualizo la entrega correctamente";
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();

                this.entregaH.Entrega();
                MessageBox.Show("Entrega actualizada");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void limpiar()
        {
            this.txtCliente.Text = "";
            this.txtTipo.Text = "";
            this.txtSN.Text = "";
            this.txtMarca.Text = "";
            this.dtpFecha.Value = DateTime.Today;
            this.txtDireccion.Text = "";
            this.txtCantidad.Text = "";
            this.txtDescripcion.Text = "";
            this.txtEntregadoPor.Text = "";
            this.txtContacto.Text = "";
            this.txtID.ReadOnly = false;
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
                if (f.Text == "GESTOR DE ENTREGAS  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                ReporteEntrega repoPrestamo = new ReporteEntrega();
                repoPrestamo.Show();
                this.Close();
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
            lblTipo.BackColor = System.Drawing.Color.White;
            lblTipo.ForeColor = System.Drawing.Color.Black;
            gpTipo.BackColor = System.Drawing.Color.White;
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA
            if (this.txtCliente.Text == "" ) {
                limpiarAlertas();
                MessageBox.Show("El campo de CLIENTE esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblCliente.BackColor = System.Drawing.Color.DarkRed;
                lblCliente.ForeColor = System.Drawing.Color.White;
                gbCliente.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtCliente;
                return;
            }
            else if (this.txtDireccion.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo de DIRECCIÓN esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblDireccion.BackColor = System.Drawing.Color.DarkRed;
                lblDireccion.ForeColor = System.Drawing.Color.White;
                gbDireccion.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtDireccion;
            }
            else if ( this.txtSN.Text == "" ) {
                limpiarAlertas();
                MessageBox.Show("El campo de Numero de Serie esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblNS.BackColor = System.Drawing.Color.DarkRed;
                lblNS.ForeColor = System.Drawing.Color.White;
                gpSN.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtSN;
            }
            
            else if ( this.txtDescripcion.Text == "" ) {
                limpiarAlertas();
                MessageBox.Show("El campo de DESCRIPCIÓN esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblDescripcion.BackColor = System.Drawing.Color.DarkRed;
                lblDescripcion.ForeColor = System.Drawing.Color.White;
                gpDescripcion.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtDescripcion;
            }
            else if (this.txtTipo.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo de TIPO esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblTipo.BackColor = System.Drawing.Color.DarkRed;
                lblTipo.ForeColor = System.Drawing.Color.White;
                gpTipo.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtTipo;
            }
            else if (validate_letter.IsMatch(txtTipo.Text) != true)
            {
                limpiarAlertas();
                MessageBox.Show("El campo TIPO solo permite letras", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblTipo.BackColor = System.Drawing.Color.DarkRed;
                lblTipo.ForeColor = System.Drawing.Color.White;
                gpTipo.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtTipo;
            }
            else if (this.txtMarca.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo de MARCA esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblMarca.BackColor = System.Drawing.Color.DarkRed;
                lblMarca.ForeColor = System.Drawing.Color.White;
                gpMarca.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtTipo;
            }
            else if (this.txtContacto.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo de CONTACTO esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblContacto.BackColor = System.Drawing.Color.DarkRed;
                lblContacto.ForeColor = System.Drawing.Color.White;
                gpContacto.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtContacto;
            }
            else if (validate_letter.IsMatch(txtContacto.Text) != true)
            {
                limpiarAlertas();
                MessageBox.Show("El campo CONTACTO solo permite letras", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblContacto.BackColor = System.Drawing.Color.DarkRed;
                lblContacto.ForeColor = System.Drawing.Color.White;
                gpContacto.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtContacto;
            }
            else if (this.txtCantidad.Text == "")
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
            else if (validate_number.IsMatch(txtCantidad.Text) != true)
            {
                limpiarAlertas();
                MessageBox.Show("El campo CEDULA solo permite numeros", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblCantidad.BackColor = System.Drawing.Color.DarkRed;
                lblCantidad.ForeColor = System.Drawing.Color.White;
                gpCantidad.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtCantidad;
            }
            else if (this.txtEntregadoPor.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo de ENTREGADO POR esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblEntregado.BackColor = System.Drawing.Color.DarkRed;
                lblEntregado.ForeColor = System.Drawing.Color.White;
                gpEntregado.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtEntregadoPor;
            }
                else if (validate_letter.IsMatch(txtEntregadoPor.Text) != true)
                {
                limpiarAlertas();
                MessageBox.Show("El campo ENTREGADO POR solo permite letras", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblEntregado.BackColor = System.Drawing.Color.DarkRed;
                lblEntregado.ForeColor = System.Drawing.Color.White;
                gpEntregado.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtEntregadoPor;
            }
                  else if (validate_Spaces.IsMatch(txtCantidad.Text) != true)
                {
                MessageBox.Show("No se permiten espacios en el campo cantidad", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                return;
                }
                     else
                {
                if (this.txtID.ReadOnly == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Desea actualiar el articulo?", "Actualizar", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        actualizar();
                        listar();
                        limpiar();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("No se actualizo el articulo");
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
        
        #region CARGAR DE TABLA
        private void CargarFromTable()
        {
            try
            {
                this.table = (DataTable)this.dgvListar.DataSource;
                if (table == null)
                {
                    MessageBox.Show("No hay Entregas para actualizar");
                }
                else
                {
                    int indice = dgvListar.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.txtCliente.Text = fila["cliente"].ToString();
                    this.txtTipo.Text = fila["tipo"].ToString();
                    this.dtpFecha.Text = fila["fecha"].ToString();
                    this.txtContacto.Text = fila["contacto"].ToString();
                    this.txtDireccion.Text = fila["direccion"].ToString();
                    this.txtID.ReadOnly = true;
                    this.txtID.Text = fila["ID"].ToString();
                    this.txtMarca.Text = fila["marca"].ToString();
                    this.txtSN.Text = fila["numeroDeSerie"].ToString();
                    this.txtCantidad.Text = fila["cantidad"].ToString();
                    this.txtDescripcion.Text = fila["descripcion"].ToString();
                    this.txtEntregadoPor.Text = fila["entregadoPor"].ToString();
                    this.btnAdd.Text = "ACTUALIZAR";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void Entregas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.txtCliente.Text != "" || this.txtTipo.Text != "" || this.txtSN.Text != "" || this.txtMarca.Text != "" || this.txtDireccion.Text != ""
                || this.txtCantidad.Text != "" || this.txtDescripcion.Text != "" || this.txtEntregadoPor.Text != "" || this.txtContacto.Text != "")
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
            listar();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void dgvListar_DoubleClick(object sender, EventArgs e)
        {
            CargarFromTable();
            listar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
