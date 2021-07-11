﻿using System;
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
                    this.cmbCed.DataSource = this.table;
                    cmbCed.ValueMember = "cedula";
                    cmbCed.DisplayMember = "cedula";
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
                this.clientes.opc = 6;
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
                this.clientes.Agente = int.Parse(this.cmbCed.Text);
                this.clientes.Direccion = this.rtbDireccion.Text;
                this.clientes.Telefono = this.lblTelefono.Text;
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

        private void GestorClientes_Load(object sender, EventArgs e)
        {
            cargarComboVendedor();
            listar();
        }

        private void limpiarAlertas()
        {
            lblCedula.BackColor = System.Drawing.Color.White;
            lblCedula.ForeColor = System.Drawing.Color.Black;
            gpCedula.BackColor = System.Drawing.Color.White;
            lblTipo.BackColor = System.Drawing.Color.White;
            lblTipo.ForeColor = System.Drawing.Color.Black;
            gbCedula.BackColor = System.Drawing.Color.White;
            lblContacto.BackColor = System.Drawing.Color.White;
            lblContacto.ForeColor = System.Drawing.Color.Black;
            gpContacto.BackColor = System.Drawing.Color.White;
            lblNombre.BackColor = System.Drawing.Color.White;
            lblNombre.ForeColor = System.Drawing.Color.Black;
            gpNombre.BackColor = System.Drawing.Color.White;
            lblCorreo.BackColor = System.Drawing.Color.White;
            lblCorreo.ForeColor = System.Drawing.Color.Black;
            gpCorreo.BackColor = System.Drawing.Color.White;
            lblTelefono.BackColor = System.Drawing.Color.White;
            lblTelefono.ForeColor = System.Drawing.Color.Black;
            gpTelefono.BackColor = System.Drawing.Color.White;
            lblVendedor.BackColor = System.Drawing.Color.White;
            lblVendedor.ForeColor = System.Drawing.Color.Black;
            gpVendedor.BackColor = System.Drawing.Color.White;
            lblDireccion.BackColor = System.Drawing.Color.White;
            lblDireccion.ForeColor = System.Drawing.Color.Black;
            gpDireccion.BackColor = System.Drawing.Color.White;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA
            if (this.txtCedula.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo de CEDULA esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblCedula.BackColor = System.Drawing.Color.DarkRed;
                lblCedula.ForeColor = System.Drawing.Color.White;
                gpCedula.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtCedula;
                return;
            }
            else if (validate_number.IsMatch(txtCedula.Text) != true)
            {
                limpiarAlertas();
                MessageBox.Show("El campo CEDULA solo permite numeros", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblCedula.BackColor = System.Drawing.Color.DarkRed;
                lblCedula.ForeColor = System.Drawing.Color.White;
                gpCedula.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtCedula;
                return;
            }
            else if (this.txtContacto.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo de CONTACTO esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblContacto.BackColor = System.Drawing.Color.DarkRed;
                lblContacto.ForeColor = System.Drawing.Color.White;
                gpContacto.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtContacto;
                return;
            }
            else if (validate_letter.IsMatch(txtContacto.Text) != true)
            {
                MessageBox.Show("El campo CONTACTO solo permite letras", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpiarAlertas();
                lblContacto.BackColor = System.Drawing.Color.DarkRed;
                lblContacto.ForeColor = System.Drawing.Color.White;
                gpContacto.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtContacto;
                return;
            }
            else if (this.txtMail.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo de CORREO esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblCorreo.BackColor = System.Drawing.Color.DarkRed;
                lblCorreo.ForeColor = System.Drawing.Color.White;
                gpCorreo.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtMail;
                return;
            }
            else if (validate_emailaddress.IsMatch(txtMail.Text) != true)
            {
                MessageBox.Show("Correo Invalido", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpiarAlertas();
                lblCorreo.BackColor = System.Drawing.Color.DarkRed;
                lblCorreo.ForeColor = System.Drawing.Color.White;
                gpCorreo.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtMail;
                return;
            }
            else if (this.cmbVende.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo de VENDEDOR esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblVendedor.BackColor = System.Drawing.Color.DarkRed;
                lblVendedor.ForeColor = System.Drawing.Color.White;
                gpVendedor.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = cmbVende;
                return;
            }
            else if (this.cmbTipo.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo de TIPO CEDULA esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblTipo.BackColor = System.Drawing.Color.DarkRed;
                lblTipo.ForeColor = System.Drawing.Color.White;
                gbCedula.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtMail;
                return;
            }
            else if ( this.txtNomb.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo de NOMBRE esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblNombre.BackColor = System.Drawing.Color.DarkRed;
                lblNombre.ForeColor = System.Drawing.Color.White;
                gpNombre.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtNomb;
                return;
            }
            else if (validate_letter.IsMatch(txtNomb.Text) != true)
            {
                limpiarAlertas();
                MessageBox.Show("El campo NOMBRE solo permite letras", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblNombre.BackColor = System.Drawing.Color.DarkRed;
                lblNombre.ForeColor = System.Drawing.Color.White;
                gpNombre.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtNomb;
                return;
            }
            else if (this.txtTel.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo de TELÉFONO esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblTelefono.BackColor = System.Drawing.Color.DarkRed;
                lblTelefono.ForeColor = System.Drawing.Color.White;
                gpTelefono.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtTel;
                return;
            }
            else if (validate_number.IsMatch(txtTel.Text) != true)
            {
                limpiarAlertas();
                MessageBox.Show("El campo TELÉFONO solo permite numeros", "InvalidO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblTelefono.BackColor = System.Drawing.Color.DarkRed;
                lblTelefono.ForeColor = System.Drawing.Color.White;
                gpTelefono.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtTel;
                return;
            }
            else if (this.rtbDireccion.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo de DIRECCIÓN esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblDireccion.BackColor = System.Drawing.Color.DarkRed;
                lblDireccion.ForeColor = System.Drawing.Color.White;
                gpDireccion.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = rtbDireccion;
                return;
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
            limpiarAlertas();
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
                this.clientes.Agente = int.Parse(this.cmbCed.Text);
                this.clientes.Direccion = this.rtbDireccion.Text;
                this.clientes.Telefono = this.lblTelefono.Text;
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
                    this.txtNomb.Text = fila["Nombre_Cliente"].ToString();
                    this.txtTel.Text = fila["telefono"].ToString();
                    this.txtMail.Text = fila["correo"].ToString();
                    this.txtCedula.ReadOnly = true;
                    this.cmbVende.Text = fila["Nombre_Vendedor"].ToString();
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
            this.Close();
        }

        private void GestorClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.cmbVende.Text != "" || this.txtCedula.Text != "" || this.txtContacto.Text != "" ||
                this.txtMail.Text != "" || this.rtbDireccion.Text != "" ||
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
        

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text == "")
                {
                    listar();
                }
                else {
                    this.clientes = new Clientes();
                    this.clientes.opc = 7;
                    this.clientes.Cedula = int.Parse(txtBuscar.Text);
                    this.clientesH = new ClientesHelper(clientes);

                    this.table = new DataTable();
                    dgvListar.DataSource = table;
                    this.table = this.clientesH.Buscar();

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
