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
    public partial class GestorInventario : Form
    {
        private Bitacora bitacora;
        private BitacoraHelper bitH;
        private Inventario inventario;
        private InventarioHelper invH;
        private DataTable table;
        private Usuarios user;

        public GestorInventario()
        {
            InitializeComponent();
        }

        public GestorInventario(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
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
                this.inventario.Nombre1 = this.txtModelo.Text;
                this.inventario.Tipo = this.txtTipo.Text;
                this.inventario.Serialnumber = this.txtSerialNumber.Text;
                this.inventario.Marca = this.cmbRol.Text;
                this.inventario.Modelo = this.txtModelo.Text;
                this.inventario.Estado = this.txtEstado.Text;
                this.inventario.Fechamodificacion = this.dtpFecha.Value;
                this.inventario.Usuario = this.txtModelo.Text;
                this.inventario.opc = 2;
                this.invH = new InventarioHelper(inventario);
                ///LOG PARA USUARIOS
                //LogMovimientos();

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA
            if (this.txtNombreActivo.Text == "" || this.txtModelo.Text == "" || this.txtSerialNumber.Text == ""
             && this.txtEstado.Text == "" || this.txtEstado.Text == "" || this.txtTipo.Text == "")
            {
                MessageBox.Show("Tienes que llenar todos los campos, para agregar o actualizar");
            }
            else
            {
                if (this.txtNombreActivo.ReadOnly)
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

        private void limpiar()
        {
            this.txtNombreActivo.Clear();
            this.txtSerialNumber.Clear();
            this.txtTipo.Clear();
            this.txtEstado.Clear();
            this.cmbRol.SelectedIndex = - 1;
            this.txtModelo.Clear();
            this.dtpFecha.Value = DateTime.Today;
            this.btnAdd.Text = "AGREGAR";  
           
        }

        #region ELIMINAR USUARIO
        private void eliminar()
        {
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
                    this.inventario.Nombre1 = fila["nombre"].ToString();
                    this.inventario.opc = 3;
                    this.invH = new InventarioHelper(inventario);
                    ///LOG PARA ELIMINAR
                    ///
                    /*
                    this.bitacora = new Bitacora();
                    this.bitacora.Usuario = this.user.Usuario;
                    this.bitacora.Movimiento = "Eliminar";
                    this.bitacora.Detalle = "Se elimino el nuevo usuario " + fila["usuario"].ToString();
                    this.bitacora.opc = 5;
                    this.bitH = new BitacoraHelper(bitacora);
                    this.bitH.LogMovimientos();
                    */
                    this.invH.Eliminar();
                    MessageBox.Show("Registro Eliminado correctamente");
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
                this.inventario = new Inventario();
                this.inventario.Nombre1 = this.txtModelo.Text;
                this.inventario.Tipo = this.txtTipo.Text;
                this.inventario.Serialnumber = this.txtSerialNumber.Text;
                this.inventario.Marca = this.cmbRol.Text;
                this.inventario.Modelo = this.txtModelo.Text;
                this.inventario.Estado = this.txtEstado.Text;
                this.inventario.Fechamodificacion = this.dtpFecha.Value;
                this.inventario.Usuario = this.user.Usuario;
                this.inventario.opc = 4;

                this.invH = new InventarioHelper(inventario);

                /*
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.user.Usuario;
                this.bitacora.Movimiento = "Actualizar";
                this.bitacora.Detalle = "Se actualizo el usuario correctamente " + this.txtUsuario.Text;
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();
                */
                this.invH.Actualizar();
                MessageBox.Show("Registro actualizado");
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
                    this.txtNombreActivo.Text = fila["nombre"].ToString();
                    this.txtTipo.Text = fila["tipo"].ToString();
                    this.txtSerialNumber.Text = fila["serialnumber"].ToString();
                    this.cmbRol.Text = fila["marca"].ToString();
        
                    this.txtModelo.Text = fila["modelo"].ToString();
                    this.txtEstado.Text = fila["estado"].ToString();
                    this.dtpFecha.Text = fila["fechamodificacion"].ToString();
                    //this.txtCorreo.Text = fila["correo"].ToString();
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
            listar();
        }

        private void dgvListar_DoubleClick(object sender, EventArgs e)
        {
            CargarFromTable();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReporteInventario entr = new ReporteInventario();
            entr.Show();
        }
    }
}
