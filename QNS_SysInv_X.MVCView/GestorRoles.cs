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
    public partial class GestorRoles : Form
    {
        private Roles roles;
        private RolesHelper rolH;
        private DataTable table;
        private Bitacora bitacora;
        private BitacoraHelper bitH;
        private Usuarios user;
        private UsuariosHelper userHelper;
        public static string inventario;
        public static string usuarios;
        public static string prestamo;
        public static string entrega;
        public static string roless;


        static Regex validate_Spaces = RegexExpression.AvoidSpaces_validation();

        public GestorRoles()
        {
            InitializeComponent();
        }

        public GestorRoles(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.statusStrip1.Text = this.user.Usuario;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtRol.Text == "")
            {
                MessageBox.Show("Tienes que llenar el campo de nombre de rol para agregar o actualizar");
            }
            else if (validate_Spaces.IsMatch(txtRol.Text) != true)
            {
                MessageBox.Show("No se permiten espacios en el campo nombre de Rol", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRol.Focus();
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Desea actualizar el rol?", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (this.txtRol.ReadOnly)
                {
                    actualizar();
                        listar();
                        limpiar();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("No se elimino el rol");
                }
            }
                else
                {
                        guardar();
                        listar();
                        limpiar();
                }
            }
        }

#region ACTUALIZAR ROLES
        private void actualizar()
        {
            try
            {
                this.roles = new Roles();
            roles.Nombre = this.txtRol.Text;
            if (chkInventario.Checked)
                roles.Inventario = true;
            else
                roles.Inventario = false;
            if (chckUsuarios.Checked)
                roles.Usuarios = true;
            else
                roles.Usuarios = false;
            if (chkPrestamo.Checked)
                roles.Prestamo = true;
            else
                roles.Prestamo = false;
            if (chkEntrega.Checked)
                roles.Entrega = true;
            else
                roles.Entrega = false;
            if (chckRoles.Checked)
                roles.Roless = true;
            else
                roles.Roless = false;
            if (chkBitacora.Checked)
                roles.Bitacora = true;
            else
                roles.Bitacora = false;
            if (chkOportunidades.Checked)
                roles.Oportunidades = true;
            else
                roles.Oportunidades = false;
            if (chkVendedores.Checked)
                roles.Vendedores = true;
            else
                roles.Vendedores = false;
            if (chkClientesx.Checked)
                roles.Clientes = true;
            else
                roles.Clientes = false;
                roles.opc = 4;
                
            this.rolH = new RolesHelper(roles);
                ///LOG PARA ROLES
                ///
                
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.user.Usuario;
                this.bitacora.Movimiento = "actualizo";
                this.bitacora.Detalle = "Se actualizo el rol " + this.txtRol.Text;
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();
                
                //

                this.rolH.ActualizarRol();
                limpiar();
                MessageBox.Show("Datos del Rol actualizados");
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

        #region GUARDAR ROL
        private void guardar()
        {
            try
            {
                // inicializo Usuario
                roles = new Roles();
                roles.Nombre = this.txtRol.Text;
                if (chkInventario.Checked)
                    roles.Inventario = true;
                else
                    roles.Inventario = false;
                if (chckUsuarios.Checked)
                    roles.Usuarios = true;
                else
                    roles.Usuarios = false;
                if (chkPrestamo.Checked)
                    roles.Prestamo = true;
                else
                    roles.Prestamo = false;
                if (chkEntrega.Checked)
                    roles.Entrega = true;
                else
                    roles.Entrega = false;
                if (chckRoles.Checked)
                    roles.Roless = true;
                else
                    roles.Roless = false;
                if (chkBitacora.Checked)
                    roles.Bitacora = true;
                else
                    roles.Bitacora = false;
                if (chkOportunidades.Checked)
                    roles.Oportunidades = true;
                else
                    roles.Oportunidades = false;
                if (chkVendedores.Checked)
                    roles.Vendedores = true;
                else
                    roles.Vendedores = false;
                if (chkClientesx.Checked)
                    roles.Clientes = true;
                else
                    roles.Clientes = false;
                roles.opc = 2;
                //roles.id_username_bitacora = Principal.id_username_bitacora;
                if (this.txtRol.Text != "")
                {
                   this.rolH = new RolesHelper(roles);
                    ///LOG PARA ROLES
                    
                    this.bitacora = new Bitacora();
                    this.bitacora.Usuario = this.user.Usuario;
                    this.bitacora.Movimiento = "Agregar";
                    this.bitacora.Detalle = "Se agrego el nuevo rol " + this.txtRol.Text;
                    this.bitacora.opc = 5;
                    this.bitH = new BitacoraHelper(bitacora);
                    this.bitH.LogMovimientos();
                    
                    this.rolH.GuardarRol();
                    MessageBox.Show("Rol almacenado");
                    limpiar();
                }
                else
                    MessageBox.Show("Debe indicar el nombre del rol");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region LIMPIAR CAMPOS
        public void limpiar()
        {
            this.txtRol.Clear();
            this.chckRoles.Checked = false;
            this.chkEntrega.Checked = false;
            this.chckUsuarios.Checked = false;
            this.chkInventario.Checked = false;
            this.chkPrestamo.Checked = false;
            this.chkBitacora.Checked = false;
            this.chkOportunidades.Checked = false;
            this.chkClientesx.Checked = false;
            this.chkVendedores.Checked = false;
            this.btnAdd.Text = "AGREGAR";
            this.txtRol.ReadOnly = false;
        }
        #endregion

#region LISTAR ROLES
        private void listar()
        {
            try
            {
                this.roles = new Roles();
                this.roles.opc = 1;

                this.rolH = new RolesHelper(roles);
                this.table = new DataTable();

                this.table = rolH.ListarRol();
                if (table.Rows.Count > 0)
                    this.dgvListar.DataSource = table;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void GestorRoles_Load(object sender, EventArgs e)
        {
            limpiar();
            listar();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar();
            listar();

        }

        #region ELIMINAR ROLES
        private void Eliminar()
        {/*
            try
            {
                this.table = (DataTable)this.dgvListar.DataSource;
                if (table == null)
                {
                    MessageBox.Show("No hay Usuarios para eliminar");
                }
                else
                {
                    int indice = dgvListar.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.roles = new Roles();
                    this.roles.Nombre = fila["nombre"].ToString();
                    this.roles.opc = 3;
                    this.rolH = new RolesHelper(roles);
///LOG PARA USUARIOS

                    this.bitacora = new Bitacora();
                    this.bitacora.Usuario = this.user.Usuario;
                    this.bitacora.Movimiento = "Eliminar Rol";
                    this.bitacora.Detalle = "Se elimino el rol " + this.txtRol.Text;
                    this.bitacora.opc = 5;
                    this.bitH = new BitacoraHelper(bitacora);
                    this.bitH.LogMovimientos();
                   
                    this.rolH.Eliminar();
                    MessageBox.Show("Usuario Eliminado Eliminado");
                    listar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }*/
        }
    #endregion

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargardatosSeleccionado();
        }

        private void dgvListar_DoubleClick(object sender, EventArgs e)
        {
            cargardatosSeleccionado();
        }
        #region CARGAR DATOS SELECCIONADOS

        private void cargardatosSeleccionado()
            {
             try
            {
                this.table = (DataTable)this.dgvListar.DataSource;
                if (table == null)
                {
                    MessageBox.Show("No hay Registros de roles para actualizar");
                }
                else
                {
                    int indice = dgvListar.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.txtRol.Text = fila["nombre"].ToString();
                    this.chckRoles.Checked = bool.Parse(fila["roles"].ToString());
                    this.chckUsuarios.Checked = bool.Parse(fila["usuarios"].ToString());
                    this.chkEntrega.Checked = bool.Parse(fila["entrega"].ToString());
                    this.chkInventario.Checked = bool.Parse(fila["inventario"].ToString());
                    this.chkPrestamo.Checked = bool.Parse(fila["prestamo"].ToString());
                    this.chkBitacora.Checked = bool.Parse(fila["bitacora"].ToString());
                    this.chkOportunidades.Checked = bool.Parse(fila["oportunidades"].ToString());
                    this.chkVendedores.Checked = bool.Parse(fila["vendedores"].ToString());
                    this.chkClientesx.Checked = bool.Parse(fila["clientes"].ToString());
                    this.txtRol.ReadOnly = true;
                    this.btnAdd.Text = "ACTUALIZAR";
                
                }
}
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    this.roles = new Roles();
                    this.roles.opc = 6;
                    this.roles.ID1 = int.Parse(txtBuscar.Text);
                    this.rolH = new RolesHelper(roles);

                    this.table = new DataTable();
                    dgvListar.DataSource = table;
                    this.table = this.rolH.Buscar();

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
