using System;
using System.Data;
using System.Windows.Forms;
using QNS_SysInv_X.MVCController;
using System.Collections.Generic;

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
            this.stsUsu.Text = this.user.Usuario;
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
                    this.cmbCedula.DataSource = this.table;
                    cmbCedula.ValueMember = "cedula";
                    cmbCedula.DisplayMember = "cedula";
                    this.cmbContacto.DataSource = this.table;
                    cmbContacto.ValueMember = "contacto";
                    cmbContacto.DisplayMember = "contacto";
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
        
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Prestamo_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtID;
            dgvListar.AllowUserToAddRows = false;
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
            if (this.txtID.Text == "" )
            {
                MessageBox.Show("Selecciona un articulo para procesar prestamo", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.ActiveControl = txtID;
            }
            else if (this.cmbCliente.Text == "")
            {
                MessageBox.Show("Selecciona un cliente para prestar el articulo", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.ActiveControl = cmbCliente;
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
               
                //AGREGAR NUEVO PRESTAMO
                this.prestamos = new Prestamos();

                this.prestamos.Id_articulo = int.Parse(this.txtID.Text);
                this.prestamos.Id_cliente = int.Parse(this.cmbCedula.Text);
               
                this.prestamos.opc = 7;
                this.presH = new PrestamoHelper(prestamos);

                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.stsUsu.Text;
                this.bitacora.Movimiento = "Prestamo ";
                this.bitacora.Detalle = "Se proceso el prestamo correctamente";
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();
                ///LOG PARA PRESTAMOS
                
                this.presH.Prestamo();
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
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "REPORTE PRESTAMO  | QNS_SysInv_X")
                {
                    IsOpen = true;
                    f.BringToFront();
                }
            }
            if (IsOpen == false)
            {
                Prestamos prestamos = new Prestamos();
                ReportePrestamo repoPrestamo = new ReportePrestamo(user);
                
                        prestamos.Contacto = cmbContacto.Text;
                        prestamos.Telefono = cmbTelefono.Text;
                        prestamos.Nombre = cmbCliente.Text;
                        prestamos.Direcicon = cmbDireccion.Text;
                repoPrestamo.prestamoLista.Add(prestamos);
                for (int i = 0; i < dgvListar.RowCount; i++)
                {
                        prestamos.Id = int.Parse(this.dgvListar.Rows[i].Cells[0].Value.ToString());
                        prestamos.NombreArticulo = this.dgvListar.Rows[i].Cells[1].Value.ToString();
                        prestamos.Tipo = this.dgvListar.Rows[i].Cells[2].Value.ToString();
                        prestamos.NumerodeSerie = this.dgvListar.Rows[i].Cells[3].Value.ToString();
                        prestamos.Marca = this.dgvListar.Rows[i].Cells[4].Value.ToString();
                        prestamos.Modelo = this.dgvListar.Rows[i].Cells[5].Value.ToString();
                        prestamos.Estado = this.dgvListar.Rows[i].Cells[6].Value.ToString();
                        prestamos.Fecha = DateTime.Parse(dgvListar.Rows[i].Cells[7].Value.ToString());
                       repoPrestamo.prestamoLista.Add(prestamos);
                }
                repoPrestamo.ShowDialog();
            }
        }

        List<int> listaPrestamo = new List<int>();
        private void dgvListar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int n = dgvListar.CurrentRow.Index;
            dgvListar.Rows[n].Selected = false;
            dgvListar.ClearSelection();
            if (listaPrestamo.Contains(n))
            listaPrestamo.Remove(n);
            else
            listaPrestamo.Add(n);
            foreach (int i in listaPrestamo)
            { dgvListar.Rows[i].Selected = true; }
        }
    }
}

