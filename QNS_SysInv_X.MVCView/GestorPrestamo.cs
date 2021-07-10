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


namespace QNS_SysInv_X.MVCView
{
    public partial class GestorPrestamo : Form
    {
        public GestorPrestamo()
        {
            InitializeComponent();
        }

        public GestorPrestamo(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsuario.Text = this.user.Usuario;
        }

        private Prestamos prestamos;
        private PrestamoHelper presH;
        private Inventario inventario;
        private InventarioHelper invH;
        private Clientes clientes;
        private ClientesHelper clientesH;
        private DataTable table;
        private Usuarios user;

        private Bitacora bitacora;
        private BitacoraHelper bitH;
        private void toolStripLabel1_Click(object sender, EventArgs e)
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
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Prestamo_Load(object sender, EventArgs e)
        {
            listar();
            cargarComboCliente();
        }
        #region LISTAR INVENTARIO
        private void listar()
        {
            try
            {
                //cargarCombo();
                this.inventario = new Inventario();
                this.inventario.opc = 5;

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

        #endregion 

        #region CARGAR DE TABLA
        private void CargarFromTable()
        {
            try
            {
                this.table = (DataTable)this.dgvListar.DataSource;
                if (table == null)
                {
                    MessageBox.Show("No hay Registros para prestamo");
                }
                else
                {
                    int indice = dgvListar.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.txtID.Text = fila["ID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        #endregion

        private void dgvListar_DoubleClick(object sender, EventArgs e)
        {
            CargarFromTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA
            if (this.txtID.Text == "" || this.cmbCliente.Text == "")
            {
                MessageBox.Show("Tienes que completar todos los campos, para procesar el prestamo");
            }
            else
            {
                procesarPrestamo();
                AlmacenarPrestamo();
                limpiar();
                listar();
            }
            #endregion
        }

        private void limpiar()
        {
            this.txtID.Text = "";
            this.cmbCliente.SelectedIndex = -1;
        }

        private void procesarPrestamo()
        {
            try
            {
                //AGREGAR NUEVO USUARIO
                this.inventario = new Inventario();
                this.inventario.Id = int.Parse(this.txtID.Text);
              
                this.inventario.opc = 6;
                this.invH = new InventarioHelper(inventario);
                ///LOG PARA USUARIOS
                ///
                
                this.invH.CambioDeEstado();
                MessageBox.Show("El articulo fue procesado para prestamo correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void AlmacenarPrestamo()
        {
            try
            {
                //AGREGAR NUEVO USUARIO
                this.prestamos = new Prestamos();
                this.prestamos.Id_articulo = int.Parse(this.txtID.Text);
                
                if (this.cmbCliente.SelectedIndex == 0)
                { this.prestamos.Id_cliente = 1; }
                else if (this.cmbCliente.SelectedIndex == 1)
                { this.prestamos.Id_cliente = 2; }
                else if (this.cmbCliente.SelectedIndex == 2)
                { this.prestamos.Id_cliente = 3; }
               
                this.prestamos.opc = 7;
                this.presH = new PrestamoHelper(prestamos);

                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.stsUsuario.Text;
                this.bitacora.Movimiento = "Prestamo ";
                this.bitacora.Detalle = "Se proceso el prestamo correctamente";
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();
                ///LOG PARA PRESTAMOS
                
                this.presH.Prestamo();
                MessageBox.Show("El articulo fue procesado para prestamo correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            ReportePrestamo repoPrestamo = new ReportePrestamo();
            repoPrestamo.Show();
        }
    }
}

