﻿using System;
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
        private DataTable table;
        private Bitacora bitacora;
        private BitacoraHelper bitH;
        private Entrega entrega;
        private EntregaHelper entregaH;
        private Usuarios user;

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
        {/*
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
            }*/
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
                this.entrega.Fecha = this.dtpFecha.Value;
                this.entrega.Contacto = this.txtContacto.Text;
                this.entrega.Dirrecion = this.txtDireccion.Text;
                this.entrega.EntregadoPor = this.txtEntregadoPor.Text;
                this.entrega.Telefono = this.txtTelefono.Text;
                this.entrega.NumeroFactura = this.txtNumFactura.Text;

                this.entrega.opc = 2;
                this.entregaH = new EntregaHelper(entrega);
                ///LOG PARA USUARIOS
                ///
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.stsUsua.Text;
                this.bitacora.Movimiento = "Ingreso entrega";
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
            this.txtCliente.Text = "";
            this.txtSN.Text = "";
            this.txtNumParte.Text = "";
            this.dtpFecha.Value = DateTime.Today;
            this.txtDireccion.Text = "";
            this.txtCantidad.Text = "";
            this.txtDescripcion.Text = "";
            this.txtEntregadoPor.Text = "";
            this.txtContacto.Text = "";
            // this.txtID.ReadOnly = false;
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
                if (this.txtCliente.Text == "")
                {
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
                else if (this.txtEntregadoPor.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo ENTREGADO POR solo permite no puede ir vacio", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblEntregado.BackColor = System.Drawing.Color.DarkRed;
                    lblEntregado.ForeColor = System.Drawing.Color.White;
                    gpEntregado.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtNumFactura;
                }
                else if (this.txtNumFactura.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo NUMERO DE FACTURA solo permite no puede ir vacio", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    label1.BackColor = System.Drawing.Color.DarkRed;
                    label1.ForeColor = System.Drawing.Color.White;
                    gpNumFactura.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtNumFactura;
                }
                else if (this.txtTelefono.Text == "")
                {
                    limpiarAlertas();
                    MessageBox.Show("El campo de TELEFONO no puede estar esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    label2.BackColor = System.Drawing.Color.DarkRed;
                    label2.ForeColor = System.Drawing.Color.White;
                    gbTelefono.BackColor = System.Drawing.Color.DarkRed;
                    this.ActiveControl = txtTelefono;
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
                    
                    entrega.Cliente = txtEntregadoPor.Text;
                    entrega.EntregadoPor = txtEntregadoPor.Text;
                    entrega.Contacto = txtContacto.Text;
                    entrega.Fecha = dtpFecha.Value;
                    entrega.Dirrecion = txtDireccion.Text;
                    entrega.NumeroFactura = txtNumFactura.Text;
                    entrega.Telefono = txtTelefono.Text;
                    for (int i = 0; i < dgvListar.RowCount; i++)
                    {
                    entrega.NumeroDeParte = this.dgvListar.Rows[i].Cells[0].Value.ToString();
                    entrega.Cantidad = this.dgvListar.Rows[i].Cells[1].Value.ToString();
                    entrega.Descripcion = this.dgvListar.Rows[i].Cells[2].Value.ToString();
                    entrega.NumeroDeSerie = this.dgvListar.Rows[i].Cells[3].Value.ToString();
                    repoEntrega.entregaLista.Add(entrega);
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
            else if (this.txtNumParte.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo de MARCA esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblMarca.BackColor = System.Drawing.Color.DarkRed;
                lblMarca.ForeColor = System.Drawing.Color.White;
                gpMarca.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtNumParte;
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
            else if (validate_Spaces.IsMatch(txtCantidad.Text) != true)
            {
                MessageBox.Show("No se permiten espacios en el campo cantidad", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                return;
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
            if (this.txtCliente.Text != "" || this.txtSN.Text != "" || this.txtNumParte.Text != "" || this.txtDireccion.Text != ""
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
            this.ActiveControl = txtCliente;
            dgvListar.AllowUserToAddRows = false;
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
            try
            {/*
                if (txtBuscar.Text == "")
                {
                    listar();
                }
                else
                {
                    this.entrega = new Entrega();
                    this.entrega.Opc = 4;
                    this.entrega.Id = int.Parse(txtBuscar.Text);
                    this.entregaH = new EntregaHelper(entrega);
                    this.table = new DataTable();
                    dgvListar.DataSource = table;
                    this.table = this.entregaH.Buscar();
                    if (this.table.Rows.Count > 0)
                    {
                        this.dgvListar.DataSource = this.table;
                        this.dgvListar.ReadOnly = true;
                    }
                    else listar();
                }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvListar.SelectedRows)
            {
                dgvListar.Rows.RemoveAt(item.Index);
                dgvListar.Refresh();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}