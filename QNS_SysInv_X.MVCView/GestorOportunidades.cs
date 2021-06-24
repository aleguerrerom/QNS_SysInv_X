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
    public partial class GestorOportunidades : Form
    {
        private Oportunidades oportunidades;
        private OportunidadesHelper oportunidadesH;
        private Usuarios user;
        private UsuariosHelper userHelper;
        private DataTable table;
        private Bitacora bitacora;
        private BitacoraHelper bitH;

        public GestorOportunidades()
        {
            InitializeComponent();
        }

        #region LISTAR OPORTUNIDADES
        private void listar()
        {
            try
            {

                this.oportunidades = new Oportunidades();
                this.oportunidades.opc = 1;

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


        #region GUARDAR VENDEDOR
        //FUNCION AGREGAR NUEVO USUARIO
        private void guardar()
        {
            try
            {
                //AGREGAR NUEVO USUARIO
                this.oportunidades = new Oportunidades();
                this.oportunidades.Nombrecliente = int.Parse(this.cmbNombre.Text);
                this.oportunidades.Fechacierre = this.dtpFecha.Value;
                this.oportunidades.Marca = this.txtMarca.Text;
                this.oportunidades.Detalles = this.txtDetalles.Text;
                this.oportunidades.Presupuesto = int.Parse(this.txtPresupuesto.Text);
                this.oportunidades.Vendedor = int.Parse(this.cmbVendedor.Text);
                this.oportunidades.opc = 2;
                this.oportunidadesH = new OportunidadesHelper(oportunidades);
                ///LOG PARA USUARIOS
              // LogMovimientos();

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA
            if (this.cmbVendedor.Text == "" || this.cmbNombre.Text == "" || this.txtMarca.Text == ""
             && this.txtDetalles.Text == "" || this.txtPresupuesto.Text == "")
            {
                MessageBox.Show("Tienes que llenar todos los campos, para agregar o actualizar");
            }
            else
            {
                if (this.cmbNombre.Enabled == false)
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

        #region ELIMINAR VENDEDOR
        private void eliminar()
        {
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

                    /* this.bitacora = new Bitacora();
                     this.bitacora.Usuario = this.stsUsuario.Text;
                     this.bitacora.Movimiento = "Eliminar";
                     this.bitacora.Detalle = "Se elimino el nuevo usuario " + fila["usuario"].ToString();
                     this.bitacora.opc = 5;
                     this.bitH = new BitacoraHelper(bitacora);
                     this.bitH.LogMovimientos();*/

                    this.oportunidadesH.Eliminar();
                    MessageBox.Show("Oportunidad Eliminada");
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
                this.oportunidades = new Oportunidades();

                this.oportunidades.Nombrecliente = int.Parse(this.cmbNombre.Text);
                this.oportunidades.Fechacierre = this.dtpFecha.Value;
                this.oportunidades.Marca = this.txtMarca.Text;
                this.oportunidades.Detalles = this.txtDetalles.Text;
                this.oportunidades.Presupuesto = int.Parse(this.txtPresupuesto.Text);
                this.oportunidades.Vendedor = int.Parse(this.cmbVendedor.Text);

                this.oportunidades.opc = 4;

                this.oportunidadesH = new OportunidadesHelper(oportunidades);


                /* this.bitacora = new Bitacora();
                 this.bitacora.Usuario = this.stsUsuario.Text;
                 this.bitacora.Movimiento = "Actualizar";
                 this.bitacora.Detalle = "Se actualizo el usuario correctamente " + this.txtUsuario.Text;
                 this.bitacora.opc = 5;
                 this.bitH = new BitacoraHelper(bitacora);
                 this.bitH.LogMovimientos();*/

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
                    MessageBox.Show("No hay Registros de estudiante para actualizar");
                }
                else
                {
                    int indice = dgvListar.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.cmbNombre.Text = fila["nombreCliente"].ToString();
                    this.txtMarca.Text = fila["marca"].ToString();
                    this.txtDetalles.Text = fila["detalles"].ToString();
                    this.txtPresupuesto.Text = fila["presupuesto"].ToString();
                    this.cmbVendedor.Text = fila["vendedor"].ToString();
                    this.cmbNombre.Enabled = false;
                    this.dtpFecha.Text = fila["fechaCierre"].ToString();
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
        }
    }
}
