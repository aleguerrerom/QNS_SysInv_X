using System;
using System.Data;
using System.Windows.Forms;
using QNS_SysInv_X.MVCController;
using System.Text.RegularExpressions;

namespace QNS_SysInv_X.MVCView
{
    public partial class GestorInventario : Form
    {
        private Bitacora bitacora;
        private BitacoraHelper bitH;
        private Inventario inventario;
        private InventarioHelper invH;
        private DataTable table;
        private Usuarios user;

        static Regex validate_letter = RegexExpression.letter_validation();

        public GestorInventario()
        {
            InitializeComponent();
        }

        public GestorInventario(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsua.Text = this.user.Usuario;
        }

        #region LISTAR INVENTARIO
        private void listar()
        {
            try
            {
                //cargarCombo();
                this.inventario = new Inventario();
                this.inventario.opc = 1;

                this.invH = new InventarioHelper(inventario);

                this.table = new DataTable();
                this.table = this.invH.Listar();

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

        #region GUARDAR Inventario
        //FUNCION AGREGAR NUEVO Inventario
        private void guardar()
        {
            try
            {
                //AGREGAR NUEVO REGISTRO
                this.inventario = new Inventario();
                this.inventario.Nombre1 = this.txtNombreActivo.Text;
                this.inventario.Tipo = this.txtTipo.Text;
                this.inventario.Serialnumber = this.txtSerialNumber.Text;
                this.inventario.Marca = this.cmbBrand.Text;
                this.inventario.Modelo = this.txtModelo.Text;
                this.inventario.Estado = this.cmbEstado.Text;
                this.inventario.Fechamodificacion = this.dtpFecha.Value;
                this.inventario.Usuario = this.stsUsua.Text;
                if (this.chckbxActivo.Checked)
                {
                    this.inventario.Activo = true;
                }
                else this.inventario.Activo = false;
                this.inventario.opc = 2;
                this.invH = new InventarioHelper(inventario);
                ///LOG PARA AGREGAR INVENTARIO
                ////

                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.stsUsua.Text;
                this.bitacora.Movimiento = "Articulo Agregado";
                this.bitacora.Detalle = "Se agrego el articulo "+this.txtNombreActivo.Text+" al inventario correctamente ";
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();
                
                this.invH.Guardar();
                MessageBox.Show("Registro Almacenado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #endregion
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarAlertas()
        {
            lblNombre.BackColor = System.Drawing.Color.White;
            lblNombre.ForeColor = System.Drawing.Color.Black;
            gbNombre.BackColor = System.Drawing.Color.White;
            lblTipo.BackColor = System.Drawing.Color.White;
            lblTipo.ForeColor = System.Drawing.Color.Black;
            gbTipo.BackColor = System.Drawing.Color.White;
            lblSN.BackColor = System.Drawing.Color.White;
            lblSN.ForeColor = System.Drawing.Color.Black;
            gbSN.BackColor = System.Drawing.Color.White;
            lblMarca.BackColor = System.Drawing.Color.White;
            lblMarca.ForeColor = System.Drawing.Color.Black;
            gbMarca.BackColor = System.Drawing.Color.White;
            lblModelo.BackColor = System.Drawing.Color.White;
            lblModelo.ForeColor = System.Drawing.Color.Black;
            gbModelo.BackColor = System.Drawing.Color.White;
            lblEstado.BackColor = System.Drawing.Color.White;
            lblEstado.ForeColor = System.Drawing.Color.Black;
            gbEstado.BackColor = System.Drawing.Color.White;
            lblFecha.BackColor = System.Drawing.Color.White;
            lblFecha.ForeColor = System.Drawing.Color.Black;
            gpFecha.BackColor = System.Drawing.Color.White;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA
            if (this.txtNombreActivo.Text == "" ){
                limpiarAlertas();
                MessageBox.Show("El campo de NOMBRE esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblNombre.BackColor = System.Drawing.Color.DarkRed;
                lblNombre.ForeColor = System.Drawing.Color.White;
                gbNombre.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtNombreActivo;
                return;
            }
            else if (this.txtTipo.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo de TIPO esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblTipo.BackColor = System.Drawing.Color.DarkRed;
                lblTipo.ForeColor = System.Drawing.Color.White;
                gbTipo.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtTipo;
                return;
            }
            else if (validate_letter.IsMatch(txtTipo.Text) != true)
            {
                limpiarAlertas();
                MessageBox.Show("El campo TIPO solo permite letras", "InvalidO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblTipo.BackColor = System.Drawing.Color.DarkRed;
                lblTipo.ForeColor = System.Drawing.Color.White;
                gbTipo.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtTipo;
                return;
            }
            else if (this.txtSerialNumber.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo de NUMERO DE SERIE esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblSN.BackColor = System.Drawing.Color.DarkRed;
                lblSN.ForeColor = System.Drawing.Color.White;
                gbSN.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtSerialNumber;
                return;
            }
            else if (this.cmbBrand.Text == "")
            {
                limpiarAlertas();
                MessageBox.Show("El campo de MARCA esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblMarca.BackColor = System.Drawing.Color.DarkRed;
                lblMarca.ForeColor = System.Drawing.Color.White;
                gbMarca.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = cmbBrand;
                return;
            }
            else if( this.txtModelo.Text == "" ){
                limpiarAlertas();
                MessageBox.Show("El campo de MODELO esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblModelo.BackColor = System.Drawing.Color.DarkRed;
                lblModelo.ForeColor = System.Drawing.Color.White;
                gbModelo.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = txtModelo;
                return;
            }
            else if( this.cmbEstado.Text == "" ){
                limpiarAlertas();
                MessageBox.Show("El campo de ESTADO esta vacio", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblEstado.BackColor = System.Drawing.Color.DarkRed;
                lblEstado.ForeColor = System.Drawing.Color.White;
                gbEstado.BackColor = System.Drawing.Color.DarkRed;
                this.ActiveControl = cmbEstado;
                return;
            }
            
            else
            {
                if (this.txtID.Enabled == false)
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

        private void limpiar()
        {
            this.txtNombreActivo.Clear();
            this.txtSerialNumber.Clear();
            this.chckbxActivo.Checked = false;
            this.txtTipo.Clear();
            this.txtID.Clear();
            this.cmbEstado.SelectedIndex = -1;
            this.cmbBrand.SelectedIndex = - 1;
            this.txtModelo.Clear();
            this.dtpFecha.Value = DateTime.Today;
            this.txtID.Enabled = true;
            this.btnAdd.Text = "AGREGAR";
            limpiarAlertas();
        }

        #region ELIMINAR USUARIO
        private void eliminar()
        {/*
            try
            {
                this.table = (DataTable)this.dgvListar.DataSource;
                if (table == null)
                {
                    MessageBox.Show("No hay Registros para eliminar");
                }
                else
                {
                    int indice = dgvListar.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.inventario = new Inventario();
                    this.inventario.Id = int.Parse(fila["id"].ToString());
                    this.inventario.opc = 3;
                    this.invH = new InventarioHelper(inventario);
                    ///LOG PARA ELIMINAR
                    ///
                    
                    this.bitacora = new Bitacora();
                    this.bitacora.Usuario = this.user.Usuario;
                    this.bitacora.Movimiento = "Eliminar";
                    this.bitacora.Detalle = "Se elimino el nuevo usuario " + fila["usuario"].ToString();
                    this.bitacora.opc = 5;
                    this.bitH = new BitacoraHelper(bitacora);
                    this.bitH.LogMovimientos();
                    
                    this.invH.Eliminar();
                    MessageBox.Show("Registro Eliminado correctamente");
                    listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
        #endregion

        #region ACTUALIZAR ARTICULO
        private void actualizar()
        {
            try
            {
                this.inventario = new Inventario();
                this.inventario.Nombre1 = this.txtNombreActivo.Text;
                this.inventario.Tipo = this.txtTipo.Text;
                this.inventario.Serialnumber = this.txtSerialNumber.Text;
                this.inventario.Marca = this.cmbBrand.Text;
                this.inventario.Modelo = this.txtModelo.Text;
                this.inventario.Estado = this.cmbEstado.Text;
                this.inventario.Fechamodificacion = this.dtpFecha.Value;
                this.inventario.Usuario = this.stsUsua.Text;
                this.inventario.Id = int.Parse(this.idl.Text);
                if (this.chckbxActivo.Checked)
                {
                    this.inventario.Activo = true;
                }
                else this.inventario.Activo = false;
                this.inventario.opc = 4;

                this.invH = new InventarioHelper(inventario);

                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.stsUsua.Text;
                this.bitacora.Movimiento = "Actualizar Inventario";
                this.bitacora.Detalle = "Se actualizo el articulo " + this.txtNombreActivo.Text + " correctamente ";
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();
                
                this.invH.Actualizar();
                MessageBox.Show("Registro de articulo actualizado");
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
                    MessageBox.Show("No hay Registros para actualizar");
                }
                else
                {
                    int indice = dgvListar.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.txtID.Text = fila["ID"].ToString();
                    this.txtNombreActivo.Text = fila["Nombre"].ToString();
                    this.txtTipo.Text = fila["Tipo"].ToString();
                    this.txtSerialNumber.Text = fila["Numero_de_Serie"].ToString();
                    this.cmbBrand.Text = fila["Marca"].ToString();
                    this.txtID.Enabled = false;
                    this.txtModelo.Text = fila["Modelo"].ToString();
                    this.cmbEstado.Text = fila["Estado"].ToString();
                    this.dtpFecha.Text = fila["Fecha_Modificación"].ToString();
                    this.idl.Text = fila["id"].ToString();
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

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarFromTable();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminar();
            listar();
        }

        private void GestorInventario_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtNombreActivo;
            dgvListar.AllowUserToAddRows = false;
            listar();
        }

        private void dgvListar_DoubleClick(object sender, EventArgs e)
        {
            CargarFromTable();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "REPORTE INVENTARIO  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                ReporteInventario entr = new ReporteInventario(user);
                entr.Show();
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void GestorInventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.txtNombreActivo.Text != "" || this.txtModelo.Text != "" || this.txtSerialNumber.Text != ""
            || this.cmbEstado.Text != "" || this.txtTipo.Text != "" || this.cmbBrand.Text != "")
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
                else
                {
                    this.inventario = new Inventario();
                    this.inventario.opc = 8;
                    this.inventario.Id = int.Parse(txtBuscar.Text);
                    this.invH = new InventarioHelper(inventario);

                    this.table = new DataTable();
                    dgvListar.DataSource = table;
                    this.table = this.invH.Buscar();

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

        private void gbEstado_Enter(object sender, EventArgs e)
        {

        }

        private void txtSerialNumber_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtNombreActivo_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarAlertas();
        }
    }
}
