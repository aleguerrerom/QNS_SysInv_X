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
    public partial class GestorClientes : Form
    {
        public GestorClientes()
        {
            InitializeComponent();
        }

        public GestorClientes(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsuario.Text = this.user.Usuario;
        }
        
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
                    this.cmbVende.DataSource = this.table;
                    cmbVende.ValueMember = "nombre";
                    cmbVende.DisplayMember = "nombre";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region LISTAR CLientes
        private void listar()
        {
            try
            {

                this.clientes = new Clientes();
                this.clientes.opc = 1;

                this.clientesH = new ClientesHelper(clientes);

                this.table = new DataTable();
                this.table = this.clientesH.Listar();

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

        #region GUARDAR Clientes
        //FUNCION AGREGAR NUEVO Clientes
        private void guardar()
        {
            try
            {
                //AGREGAR NUEVO USUARIO
                this.clientes = new Clientes();
                this.clientes.Cedula = int.Parse(this.txtCedula.Text);
                this.clientes.Tipo = this.cmbTipo.Text;
                this.clientes.Contacto = this.txtContacto.Text;
                this.clientes.Nombre = this.txtNomb.Text;
                this.clientes.Correo = this.txtMail.Text;
                if (this.cmbVende.SelectedIndex == 0)
                { this.clientes.Agente = 1; }
                else if (this.cmbVende.SelectedIndex == 1)
                { this.clientes.Agente = 2; }
                else if (this.cmbVende.SelectedIndex == 2)
                { this.clientes.Agente = 3; }
                else if (this.cmbVende.SelectedIndex == 3)
                { this.clientes.Agente = 4; }
                else if (this.cmbVende.SelectedIndex == 4)
                { this.clientes.Agente = 5; }
                else if (this.cmbVende.SelectedIndex == 5)
                { this.clientes.Agente = 6; }
                else if (this.cmbVende.SelectedIndex == 6)
                { this.clientes.Agente = 7; }
                else if (this.cmbVende.SelectedIndex == 7)
                { this.clientes.Agente = 8; }
                else if (this.cmbVende.SelectedIndex == 8)
                { this.clientes.Agente = 9; }
                else if (this.cmbVende.SelectedIndex == 9)

                { this.clientes.Agente = 10; }
                this.clientes.Direccion = this.rtbDireccion.Text;
                this.clientes.opc = 2;
                this.clientesH = new ClientesHelper(clientes);
                ///LOG PARA USUARIOS

                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.stsUsuario.Text;
                this.bitacora.Movimiento = "Agregar Cliente";
                this.bitacora.Detalle = "Se agrego el cliente correctamente " + this.txtNomb.Text;
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();

                this.clientesH.Guardar();
                MessageBox.Show("Datos de Cliente Almacenado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void GestorClientes_Load(object sender, EventArgs e)
        {
            cargarComboVendedor();
            listar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA
            if (this.cmbVendedor.Text == "" || this.txtCedula.Text == "" || this.txtContacto.Text == "" ||
              this.txtContacto.Text == ""  || this.txtMail.Text == "" ||
                this.cmbTipo.Text == "" || this.txtTel.Text == "" ||  this.txtNomb.Text == "")
            {
                MessageBox.Show("Tienes que llenar todos los campos, para agregar o actualizar");
            }
            else if (validate_emailaddress.IsMatch(txtMail.Text) != true)
            {
                MessageBox.Show("Correo Invalido", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTel.Focus();
                return;
            }

            else if (validate_letter.IsMatch(txtContacto.Text) != true)
            {
                MessageBox.Show("El campo CONTACTO solo permite letras", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContacto.Text.Remove(txtContacto.Text.Length - 1);
                txtContacto.Focus();
            }

            else if (validate_letter.IsMatch(txtNombre.Text) != true)
            {
                MessageBox.Show("El campo NOMBRE solo permite letras", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Text.Remove(txtNombre.Text.Length - 1);
                txtNombre.Focus();
            }

            else if (validate_number.IsMatch(txtTel.Text) != true)
            {
                MessageBox.Show("El campo TELÉFONO solo permite numeros", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTel.Text.Remove(txtTel.Text.Length - 1);
                txtTel.Focus();
            }


            else if (validate_number.IsMatch(txtCedula.Text) != true)
            {
                MessageBox.Show("El campo CEDULA solo permite numeros", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCedula.Text.Remove(txtCedula.Text.Length - 1);
                txtCedula.Focus();
            }

            else
            {
                if (this.txtCedula.ReadOnly == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Desea actualizar los datos del cliente?", "Eliminar", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                    actualizar();
                    listar();
                    limpiar();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("No se actualizaron los datos del cliente");
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
            this.txtCedula.Clear();
            this.txtContacto.Clear();
            this.txtNomb.Clear();
            this.txtMail.Clear();
            this.txtTel.Clear();
            this.rtbDireccion.Clear();
            this.cmbTipo.SelectedIndex = -1;
            this.cmbVende.SelectedIndex = -1;
            this.txtCedula.ReadOnly = false;
            this.btnAdd.Text = "AGREGAR";

        }
        #endregion

        #region ELIMINAR CLIENTE
        private void eliminar()
        {/*
            try
            {
                this.table = (DataTable)this.dgvListar.DataSource;
                if (table == null)
                {
                    MessageBox.Show("No hay Clientes para eliminar");
                }
                else
                {
                    int indice = dgvListar.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.clientes = new Clientes();
                    this.clientes.Cedula =
                    this.clientes.Cedula = int.Parse(fila["cedula"].ToString());
                    this.clientes.opc = 3;
                    this.clientesH = new ClientesHelper(clientes);
                    ///LOG PARA ELIMINAR
                    ///

                     this.bitacora = new Bitacora();
                     this.bitacora.Usuario = this.stsUsuario.Text;
                     this.bitacora.Movimiento = "Eliminar";
                     this.bitacora.Detalle = "Se elimino el nuevo usuario " + fila["nombre"].ToString();
                     this.bitacora.opc = 5;
                     this.bitH = new BitacoraHelper(bitacora);
                     this.bitH.LogMovimientos();

                    this.clientesH.Eliminar();
                    MessageBox.Show("Clientes Eliminado");
                    listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
        #endregion

        #region ACTUALIZAR CLIENTE
        private void actualizar()
        {
            try
            {
                //ACTUALIZAR CLIENTE
                this.clientes = new Clientes();
                this.clientes.Cedula = int.Parse(this.txtCedula.Text);
                this.clientes.Tipo = this.cmbTipo.Text;
                this.clientes.Contacto = this.txtContacto.Text;
                this.clientes.Nombre= this.txtNomb.Text;
                this.clientes.Correo = this.txtMail.Text;
                if (this.cmbVende.SelectedIndex == 0)
                { this.clientes.Agente = 1; }
                else if (this.cmbVende.SelectedIndex == 1)
                { this.clientes.Agente = 2; }
                else if (this.cmbVende.SelectedIndex == 2)
                { this.clientes.Agente = 3; }
                else if (this.cmbVende.SelectedIndex == 3)
                { this.clientes.Agente = 4; }
                else if (this.cmbVende.SelectedIndex == 4)
                { this.clientes.Agente = 5; }
                 else if (this.cmbVende.SelectedIndex == 4)
                { this.clientes.Agente = 5; }
                else if (this.cmbVende.SelectedIndex == 5)
                { this.clientes.Agente = 6; }
                else if (this.cmbVende.SelectedIndex == 6)
                { this.clientes.Agente = 7; }
                else if (this.cmbVende.SelectedIndex == 7)
                { this.clientes.Agente = 8; }

                this.clientes.Direccion = this.rtbDireccion.Text;

                this.clientes.opc = 4;

                this.clientesH = new ClientesHelper(clientes);
                
                 this.bitacora = new Bitacora();
                 this.bitacora.Usuario = this.stsUsuario.Text;
                 this.bitacora.Movimiento = "Actualizar Cliente";
                 this.bitacora.Detalle = "Se actualizo el cliente correctamente " + this.txtNomb.Text;
                 this.bitacora.opc = 5;
                 this.bitH = new BitacoraHelper(bitacora);
                 this.bitH.LogMovimientos();

                this.clientesH.Actualizar();
                MessageBox.Show("Datos de clientes actualizados");
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
                    MessageBox.Show("No hay Registros de estudiante para actualizar");
                }
                else
                {
                    int indice = dgvListar.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.txtCedula.Text = fila["cedula"].ToString();
                    this.cmbTipo.Text = fila["tipo"].ToString();
                    this.txtContacto.Text = fila["contacto"].ToString();
                    this.txtNomb.Text = fila["nombre"].ToString();
                    this.txtTel.Text = fila["telefono"].ToString();
                    this.txtMail.Text = fila["correo"].ToString();
                    this.txtCedula.ReadOnly = true;
                    this.cmbVende.Text = fila["agente"].ToString();
                    this.rtbDireccion.Text = fila["direcion"].ToString();
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
            limpiar();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            RerporteClientes RepoClientes = new RerporteClientes();
            RepoClientes.Show();
            this.Close();
        }

        private void dgvListar_DoubleClick(object sender, EventArgs e)
        {
            CargarFromTable();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

            if (this.cmbVendedor.Text != "" || this.txtCedula.Text != "" || this.txtContacto.Text != "" ||
                   this.txtContacto.Text != "" || this.txtMail.Text != "" ||
                     this.cmbTipo.Text != "" || this.txtTel.Text != "" || this.txtNomb.Text == "")
            {
                DialogResult dialogResult = MessageBox.Show("Desea salir? Si sale se eliminaaran lo datos ingresados", "SALIR", MessageBoxButtons.YesNo);
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

        private void GestorClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.cmbVendedor.Text != "" || this.txtCedula.Text != "" || this.txtContacto.Text != "" ||
                   this.txtContacto.Text != "" || this.txtMail.Text != "" ||
                     this.cmbTipo.Text != "" || this.txtTel.Text != "" || this.txtNomb.Text == "")
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
