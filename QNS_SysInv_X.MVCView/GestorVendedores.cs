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
using System.IO;

namespace QNS_SysInv_X.MVCView
{
    public partial class GestorVendedores : Form
    {

        private Vendedores vendedor;
        private VendedoresHelper vendedorH;
        private Usuarios user;
        private UsuariosHelper userHelper;
        private DataTable table;
        private Bitacora bitacora;
        private BitacoraHelper bitH;


        public GestorVendedores(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsuario.Text = this.user.Usuario;
        }


        public GestorVendedores()
        {
            InitializeComponent();
        }

        #region LISTAR VENDEDORES
        private void listar()
        {
            try
            {

                this.vendedor = new Vendedores();
                this.vendedor.opc = 1;

                this.vendedorH = new VendedoresHelper(vendedor);

                this.table = new DataTable();
                this.table = this.vendedorH.Listar();

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

        #region GUARDAR VENDEDOR
        //FUNCION AGREGAR NUEVO USUARIO
        private void guardar()
        {
            try
            {
                //AGREGAR NUEVO USUARIO
                this.vendedor = new Vendedores();
                this.vendedor.Cedula = int.Parse(this.txtCedula.Text);
                this.vendedor.Nombre = this.txtNombre.Text;
                this.vendedor.Apellido1 = this.txtApellido.Text;
                this.vendedor.Apellido2 = this.txtApellido2.Text;
                this.vendedor.Genero = this.cmbGenero.Text;
                this.vendedor.Fechanacimiento = this.dtpFechaAnace.Value;
                this.vendedor.Correo = this.txtCorreo.Text;
                this.vendedor.opc = 2;
                this.vendedorH = new VendedoresHelper(vendedor);
                ///LOG PARA USUARIOS
                ///
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.stsUsuario.Text;
                this.bitacora.Movimiento = "Ingreso vendedor";
                this.bitacora.Detalle = "Se agrego el vendedor correctamente " + this.txtNombre.Text + " " + this.txtApellido.Text;
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();

                this.vendedorH.Guardar();
                MessageBox.Show("Vendedor  " + this.vendedor.Nombre + " Almacenado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
        private void btnReport_Click(object sender, EventArgs e)
        {

            

        }
        
        private void GestorRespaldos_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvListar_DoubleClick(object sender, EventArgs e)
        {
            CargarFromTable();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            #region VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA
            if (this.txtCedula.Text == "" || this.txtNombre.Text == "" || this.txtCorreo.Text == ""
             && this.txtApellido.Text == "" || this.txtApellido2.Text == "" || this.cmbGenero.Text == "")
            {
                MessageBox.Show("Tienes que llenar todos los campos, para agregar o actualizar");
            }
            else
            {
                if (this.txtCedula.ReadOnly)
                {

                    actualizar();
                    listar();
                    limpiar();
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
            this.txtApellido.Clear();
            this.txtApellido2.Clear();
            this.txtCedula.Clear();
            this.txtCorreo.Clear();
            this.txtNombre.Clear();
            this.cmbGenero.SelectedIndex = -1;
            this.txtCedula.ReadOnly = false;
            this.dtpFechaAnace.Value = DateTime.Today;
            this.btnAdd.Text = "AGREGAR";
            
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        #region ELIMINAR VENDEDOR
        private void eliminar()
        {
            try
            {
                this.table = (DataTable)this.dgvListar.DataSource;
                if (table == null)
                {
                    MessageBox.Show("No hay Vendedores para eliminar");
                }
                else
                {
                    int indice = dgvListar.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.vendedor = new Vendedores();
                    this.vendedor.Cedula = int.Parse(fila["cedula"].ToString());
                    this.vendedor.opc = 3;
                    this.vendedorH = new VendedoresHelper(vendedor);
                    ///LOG PARA ELIMINAR
                    ///

                    this.bitacora = new Bitacora();
                    this.bitacora.Usuario = this.stsUsuario.Text;
                    this.bitacora.Movimiento = "Eliminar Vendedor";
                    this.bitacora.Detalle = "Se elimino el vendedor " + fila["nombre"].ToString();
                    this.bitacora.opc = 5;
                    this.bitH = new BitacoraHelper(bitacora);
                    this.bitH.LogMovimientos();

                    this.vendedorH.Eliminar();
                    MessageBox.Show("Vendedor " + this.vendedor.Nombre + " Eliminado");
                    listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region ACTUALIZAR USUARIO
        private void actualizar()
        {
            try
            {
                this.vendedor = new Vendedores();
                this.vendedor.Cedula = int.Parse(this.txtCedula.Text);
                this.vendedor.Nombre = this.txtNombre.Text;
                this.vendedor.Apellido1 = this.txtApellido.Text;
                this.vendedor.Apellido2 = this.txtApellido2.Text;
                this.vendedor.Genero = this.cmbGenero.Text;
                this.vendedor.Fechanacimiento = this.dtpFechaAnace.Value;
                this.vendedor.Correo = this.txtCorreo.Text;

                this.vendedor.opc = 4;

                this.vendedorH = new VendedoresHelper(vendedor);


                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.stsUsuario.Text;
                this.bitacora.Movimiento = "Actualizar Vendedor";
                this.bitacora.Detalle = "Se actualizo el vendedor correctamente " + this.txtNombre.Text + " " + this.txtApellido.Text ;
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();

                this.vendedorH.Actualizar();
                MessageBox.Show("Datos del Vendedor " + this.vendedor.Nombre + " actualizados");
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
                    this.txtNombre.Text = fila["nombre"].ToString();
                    this.txtApellido.Text = fila["apellido1"].ToString();
                    this.txtApellido2.Text = fila["apellido2"].ToString();
                    this.txtCorreo.Text = fila["correo"].ToString();
                    this.cmbGenero.Text = fila["genero"].ToString();
                    this.txtCedula.ReadOnly = true;
                    this.dtpFechaAnace.Text = fila["fechaNacimiento"].ToString();
                    this.btnAdd.Text = "ACTUALIZAR";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        private void dgvListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminar();
            listar();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
