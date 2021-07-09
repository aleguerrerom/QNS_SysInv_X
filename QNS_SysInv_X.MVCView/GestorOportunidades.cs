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
    public partial class GestorOportunidades : Form
    {
        private Oportunidades oportunidades;
        private OportunidadesHelper oportunidadesH;
        private Clientes clientes;
        private ClientesHelper clientesH;
        private Usuarios user;
        private UsuariosHelper userHelper;
        private Vendedores vendedores;
        private VendedoresHelper vendedoresH;
        private DataTable table;
        private Bitacora bitacora;
        private BitacoraHelper bitH;

        static Regex validate_emailaddress = RegexExpression.email_validation();

        static Regex validate_letter = RegexExpression.letter_validation();

        static Regex validate_number = RegexExpression.number_validation();

        static Regex validate_Spaces = RegexExpression.AvoidSpaces_validation();

        public GestorOportunidades()
        {
            InitializeComponent();
        }

        public GestorOportunidades(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsuario.Text = this.user.Usuario;
        }

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
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                this.oportunidades.Nombrecliente = (this.cmbNombre.Text);
                this.oportunidades.Fechacierre = this.dtpFecha.Value;
                this.oportunidades.Marca = this.txtMarca.Text;
                this.oportunidades.Detalles = this.txtDetalles.Text;
                this.oportunidades.Presupuesto = int.Parse(this.txtPresupuesto.Text);
                //this.oportunidades.Vendedor = this.cmbVendedor.SelectedIndex + 1;
                if (this.cmbVendedor.SelectedIndex == 0)
                { this.oportunidades.Vendedor = 1; }
                else if (this.cmbVendedor.SelectedIndex == 1)
                { this.oportunidades.Vendedor = 2; }
                else if (this.cmbVendedor.SelectedIndex == 2)
                { this.oportunidades.Vendedor = 3; }
                else if (this.cmbVendedor.SelectedIndex == 3)
                { this.oportunidades.Vendedor = 4; }
                else if (this.cmbVendedor.SelectedIndex == 4)
                { this.oportunidades.Vendedor = 5; }
                this.oportunidades.Nombrecliente = this.cmbNombre.Text;
                //if (this.cmbNombre.SelectedIndex == 0)
                //{ this.oportunidades.Nombrecliente = 1; }
                //else if (this.cmbNombre.SelectedIndex == 1)
                //{ this.oportunidades.Nombrecliente = 2; }
                //else if (this.cmbNombre.SelectedIndex == 2)
                //{ this.oportunidades.Nombrecliente = 3; }
                //else if (this.cmbNombre.SelectedIndex == 3)
                //{ this.oportunidades.Nombrecliente = 4; }
                //else if (this.cmbNombre.SelectedIndex == 4)
                //{ this.oportunidades.Nombrecliente = 5; }

                this.oportunidades.opc = 2;
                this.oportunidadesH = new OportunidadesHelper(oportunidades);
                ///LOG PARA USUARIOS


                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.stsUsuario.Text;
                this.bitacora.Movimiento = "Oportunidad Insertada";
                this.bitacora.Detalle = "Se agrego la oportunidad correctamente ";
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();

                this.oportunidadesH.Guardar();
                MessageBox.Show("Oportunidad  Almacenada");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA
            if (this.cmbVendedor.Text == "" || this.cmbNombre.Text == "" || this.txtMarca.Text == ""
             || this.txtDetalles.Text == "" || this.txtPresupuesto.Text == "" || this.txtDetalles.Text == "")
            {
                MessageBox.Show("Tienes que llenar todos los campos, para agregar o actualizar");
            }

            else if (validate_Spaces.IsMatch(txtPresupuesto.Text) != true)
            {
                MessageBox.Show("No se permiten espacios en el campo presupuesto", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPresupuesto.Focus();
                return;
            }

            else if (validate_number.IsMatch(txtPresupuesto.Text) != true)
            {
                MessageBox.Show("El campo PRESUPUESTO solo permite numeros", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPresupuesto.Text.Remove(txtPresupuesto.Text.Length - 1);
                txtPresupuesto.Focus();
            }
            else
            {
                if (this.cmbNombre.Enabled == false)
                {
                    DialogResult dialogResult = MessageBox.Show("Desea actualziar la oportunidad?", "Actualizar", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        actualizar();
                    listar();
                    limpiar();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("No se actualizo la oportunidad");
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
            this.txtModelo.Clear();
            this.txtPresupuesto.Clear();
            this.cmbNombre.SelectedIndex = -1;
            this.cmbVendedor.SelectedIndex = -1;
            this.cmbNombre.Enabled = true;
            this.dtpFecha.Value = DateTime.Today;
            this.btnAdd.Text = "AGREGAR";

        }
        #endregion

        #region ELIMINAR OPORTUNIDAD
        private void eliminar()
        {/*
            try
            {
                this.table = (DataTable)this.dgvListar.DataSource;
                if (table == null)
                {
                    MessageBox.Show("No hay Oportunidades para eliminar");
                }
                else
                {
                    int indice = dgvListar.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.oportunidades = new Oportunidades();
                    this.oportunidades.Nombrecliente =
                    this.oportunidades.Nombrecliente = int.Parse(fila["nombreCliente"].ToString());
                    this.oportunidades.opc = 3;
                    this.oportunidadesH = new OportunidadesHelper(oportunidades);
                    ///LOG PARA ELIMINAR
                    ///

                     this.bitacora = new Bitacora();
                     this.bitacora.Usuario = this.stsUsuario.Text;
                     this.bitacora.Movimiento = "Eliminar Oportunidad";
                     this.bitacora.Detalle = "Se elimino la oportunidad seleccionada";
                     this.bitacora.opc = 5;
                     this.bitH = new BitacoraHelper(bitacora);
                     this.bitH.LogMovimientos();

                    this.oportunidadesH.Eliminar();
                    MessageBox.Show("Oportunidad Eliminada");
                    listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
        #endregion

        #region ACTUALIZAR OPORTUNIDADES
        private void actualizar()
        {
            try
            {
                this.oportunidades = new Oportunidades();

                this.oportunidades.Nombrecliente = (this.cmbNombre.Text);
                this.oportunidades.Fechacierre = this.dtpFecha.Value;
                this.oportunidades.Marca = this.txtMarca.Text;
                this.oportunidades.Detalles = this.txtDetalles.Text;
                this.oportunidades.Presupuesto = int.Parse(this.txtPresupuesto.Text);
                this.oportunidades.Id = int.Parse(this.idl.Text);
                this.oportunidades.Vendedor = this.cmbVendedor.SelectedIndex + 1;
                this.oportunidades.opc = 4;

                this.oportunidadesH = new OportunidadesHelper(oportunidades);
                
                 this.bitacora = new Bitacora();
                 this.bitacora.Usuario = this.stsUsuario.Text;
                 this.bitacora.Movimiento = "Actualizar Oportunidad";
                 this.bitacora.Detalle = "Se actualizo la oportunidad correctamente ";
                 this.bitacora.opc = 5;
                 this.bitH = new BitacoraHelper(bitacora);
                 this.bitH.LogMovimientos();

                this.oportunidadesH.Actualizar();
                MessageBox.Show("Datos de oportunidad actualizados");
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
                    this.cmbNombre.Enabled = false;
                    this.dtpFecha.Text = fila["Fecha_de_Cierre"].ToString();
                    this.idl.Text = fila["Cedula"].ToString();
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

        private void dgvListar_DoubleClick(object sender, EventArgs e)
        {
            CargarFromTable();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminar();
            listar();
        }

        private void GestorOportunidades_Load(object sender, EventArgs e)
        {
            listar();
            cargarComboVendedor();
            cargarComboCliente();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReporteOpor RedOpo = new ReporteOpor();
            RedOpo.Show();
            this.Close();
        }
        
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (this.cmbVendedor.Text != "" || this.cmbNombre.Text != "" || this.txtMarca.Text != ""
               || this.txtDetalles.Text != "" || this.txtPresupuesto.Text != "" || this.txtDetalles.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Desea salir? Si sale se eliminaran lo datos ingresados", "SALIR", MessageBoxButtons.YesNo);
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
            try
            {
                if (txtBuscar.Text == "")
                {
                    listar();
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
        }
    }
}
