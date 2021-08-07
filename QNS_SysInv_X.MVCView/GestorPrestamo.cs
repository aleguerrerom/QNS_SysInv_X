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
        #region CARGAR COMBO BOX DE CLIENTE
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
        #endregion

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Prestamo_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cmbCliente;
            dataGridView1.AllowUserToAddRows = false;
            listar();
            cargarComboCliente();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                    this.dataGridView1.DataSource = this.table;
                    this.dataGridView1.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion 
        
        private void limpiar()
        {
            this.cmbCliente.SelectedIndex = -1;
        }
        #region PROCESAMIENTO DE PRESTAMO
        private void procesarPrestamo()
        {
            try
            {
                for (int i = 0; i < dataGridView1.RowCount; i = i + 1)
                {
                    if (bool.Parse(this.dataGridView1.Rows[i].Cells[1].Selected.ToString()) == true)
                    {
                        //AGREGAR NUEVO USUARIO
                        this.table = (DataTable)this.dataGridView1.DataSource;
                if (table == null)
                {
                    MessageBox.Show("No hay Registros de roles para actualizar");
                }
                else
                {
                    this.inventario = new Inventario();
                    int indice = dataGridView1.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                            // row is selected
                            Prestamos loop = new Prestamos();
                            this.inventario.Id = int.Parse(this.dataGridView1.Rows[i].Cells[0].Value.ToString());
                        }
                    }
                    this.inventario.opc = 6;
                    this.invH = new InventarioHelper(inventario);

                    this.invH.CambioDeEstado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region ALMACENAR PRESTAMO
        private void AlmacenarPrestamo()
        {
            try
            {
                //AGREGAR NUEVO PRESTAMO
                this.prestamos = new Prestamos();
                int indice = dataGridView1.CurrentRow.Index;
                DataRow fila = table.Rows[indice];
                for (int i = 0; i < dataGridView1.RowCount; i = i + 1)
                {
                    if (bool.Parse(this.dataGridView1.Rows[i].Cells[1].Selected.ToString()) == true)
                    {
                        // row is selected
                        Prestamos loop = new Prestamos();
                        this.prestamos.Id_articulo = int.Parse(this.dataGridView1.Rows[i].Cells[0].Value.ToString());
                    }
                }
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
            #region PROCESO DE PRESTAMO Y REPORTE CON RESTRICCIONES
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

                if (this.dataGridView1.SelectedRows.Count == 0)
                {

                    MessageBox.Show("Debes seleccionar al menos un articulo para el prestamo");
                }
               else if (this.cmbCliente.Text == "")
                {
                    MessageBox.Show("Selecciona un cliente para prestar el articulo", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.ActiveControl = cmbCliente;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Desea procesar los articulos prestamo?", "PRESTAMO", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Prestamos prestamos = new Prestamos();
                        ReportePrestamo repoPrestamo = new ReportePrestamo(user);

                        prestamos.Contacto = cmbContacto.Text;
                        prestamos.Telefono = cmbTelefono.Text;
                        prestamos.Nombre = cmbCliente.Text;
                        prestamos.Direcicon = cmbDireccion.Text;
                        repoPrestamo.prestamoLista.Add(prestamos);
                        
                        for (int i = 0; i < dataGridView1.RowCount; i = i + 1)
                        {
                            if (bool.Parse(this.dataGridView1.Rows[i].Cells[1].Selected.ToString()) == true)
                            {
                                // row is selected
                                Prestamos loop = new Prestamos();
                                loop.Id = int.Parse(this.dataGridView1.Rows[i].Cells[0].Value.ToString());
                                loop.NombreArticulo = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                                loop.Tipo = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                                loop.NumerodeSerie = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
                                loop.Marca = this.dataGridView1.Rows[i].Cells[4].Value.ToString();
                                loop.Modelo = this.dataGridView1.Rows[i].Cells[5].Value.ToString();
                                loop.Estado = this.dataGridView1.Rows[i].Cells[6].Value.ToString();
                                //loop.Fecha = DateTime.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                                repoPrestamo.prestamoLista.Add(loop);
                            }
                        }
                        procesarPrestamo();
                        AlmacenarPrestamo();
                        limpiar();
                        listar();
                        MessageBox.Show("El articulo fue procesado para prestamo correctamente");
                        repoPrestamo.ShowDialog();
                    }
                   
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("No se procesaron los articulos");
                    }
                }
            }

            #endregion
        }

        #region PROCESO DE MULTI SELECCION DE ROW EN DATAGRIDVIEW
        List<int> listaPrestamo = new List<int>();
      
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int n = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[n].Selected = false;
            dataGridView1.ClearSelection();
            if (listaPrestamo.Contains(n))
                listaPrestamo.Remove(n);
            else
                listaPrestamo.Add(n);
            foreach (int i in listaPrestamo)
            { dataGridView1.Rows[i].Selected = true; }
        }
        #endregion
    }
}