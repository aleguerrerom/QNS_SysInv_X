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
            this.stsUsu.Text = this.user.Usuario;
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
                this.inventario.Marca = this.cmbBrand.Text;
                this.inventario.Modelo = this.txtModelo.Text;
                this.inventario.Estado = this.cmbEstado.Text;
                this.inventario.Fechamodificacion = this.dtpFecha.Value;
                this.inventario.Usuario = this.txtModelo.Text;
                this.inventario.opc = 2;
                this.invH = new InventarioHelper(inventario);
                ///LOG PARA USUARIOS
                ////
                
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.user.Usuario;
                this.bitacora.Movimiento = "Inventario Agregado";
                this.bitacora.Detalle = "Se agrego el articulo al inventario correctamente ";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA
            if (this.txtNombreActivo.Text == "" || this.txtModelo.Text == "" || this.txtSerialNumber.Text == ""
             || this.cmbEstado.Text == "" || this.txtTipo.Text == "" || this.cmbBrand.Text == "")
            {
                MessageBox.Show("Tienes que llenar todos los campos, para agregar o actualizar");
            }
            else if (validate_letter.IsMatch(txtTipo.Text) != true)
            {
                MessageBox.Show("El campo TIPO solo permite letras", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTipo.Text.Remove(txtTipo.Text.Length - 1);
                txtTipo.Focus();
            }
            else
            {
                if (this.txtNombreActivo.Enabled == false)
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
            this.txtTipo.Clear();
            this.cmbEstado.SelectedIndex = -1;
            this.cmbBrand.SelectedIndex = - 1;
            this.txtModelo.Clear();
            this.dtpFecha.Value = DateTime.Today;
            this.txtNombreActivo.Enabled = true;
            this.btnAdd.Text = "AGREGAR";  
           
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
                this.inventario.Nombre1 = this.txtModelo.Text;
                this.inventario.Tipo = this.txtTipo.Text;
                this.inventario.Serialnumber = this.txtSerialNumber.Text;
                this.inventario.Marca = this.cmbBrand.Text;
                this.inventario.Modelo = this.txtModelo.Text;
                this.inventario.Estado = this.cmbEstado.Text;
                this.inventario.Fechamodificacion = this.dtpFecha.Value;
                this.inventario.Usuario = this.txtModelo.Text;
                this.inventario.Id = int.Parse(this.idl.Text);
                this.inventario.opc = 4;

                this.invH = new InventarioHelper(inventario);

                
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.user.Usuario;
                this.bitacora.Movimiento = "Actualizar Inventario";
                this.bitacora.Detalle = "Se actualizo el inventario correctamente ";
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
                    this.txtNombreActivo.Text = fila["nombre"].ToString();
                    this.txtTipo.Text = fila["tipo"].ToString();
                    this.txtSerialNumber.Text = fila["serialnumber"].ToString();
                    this.cmbBrand.Text = fila["marca"].ToString();
                    this.txtNombreActivo.Enabled = false;
                    this.txtModelo.Text = fila["modelo"].ToString();
                    this.cmbEstado.Text = fila["estado"].ToString();
                    this.dtpFecha.Text = fila["fechamodificacion"].ToString();
                    this.idl.Text = fila["id"].ToString();
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
            this.Close();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (this.txtNombreActivo.Text != "" || this.txtModelo.Text != "" || this.txtSerialNumber.Text != ""
            || this.cmbEstado.Text != "" || this.txtTipo.Text != "" || this.cmbBrand.Text != "")
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
    }
}
