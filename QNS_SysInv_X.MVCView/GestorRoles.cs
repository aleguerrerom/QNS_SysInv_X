using System;
using System.Data;
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

        static Regex validate_Spaces = RegexExpression.AvoidSpaces_validation();
        static Regex validate_number = RegexExpression.number_validation();
        static Regex validate_numberANDletter = RegexExpression.numberANDletter_validation();

        public GestorRoles()
        {
            InitializeComponent();
        }

        public GestorRoles(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsu.Text = this.user.Usuario;
        }

        private bool ValidarExistencia()
        {
            this.roles = new Roles();
            this.roles.Nombre = (this.txtRol.Text);
            this.roles.opc = 9;

            this.rolH = new RolesHelper(roles);
            this.table = new DataTable();
            this.table = this.rolH.Validar();
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("El rol con el nombre " + this.txtRol.Text + " ya existe en la base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.ActiveControl = txtRol;
                return true;
            }
            else
                return false;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
                #region VALIDACIONES PARA AGREGAR O ACTUALIZAR
                if (this.txtRol.Text == "")
                {
                    MessageBox.Show("Tienes que llenar el campo de nombre de rol para agregar o actualizar", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (validate_Spaces.IsMatch(txtRol.Text) != true)
                {
                    MessageBox.Show("No se permiten espacios en el campo nombre de Rol", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRol.Focus();
                    return;
                }
                else if (validate_numberANDletter.IsMatch(txtRol.Text) != true)
                {
                    MessageBox.Show("No se permiten caracter especiales en el campo nombre de Rol", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRol.Focus();
                    return;
                }
                else
                {
                    if (this.txtID.ReadOnly)
                    {
                        DialogResult dialogResult = MessageBox.Show("Desea actualizar el rol?", "Actualizar", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            actualizar();
                            listar();
                            limpiar();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("No se actualizó el rol", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        guardar();
                        listar();
                    }
                }
            
            #endregion
        }

        #region ACTUALIZAR ROLES
        private void actualizar()
        {
            try
            {
                this.roles = new Roles();
            roles.Nombre = this.txtRol.Text.TrimEnd();
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
                if (this.chckbxActivo.Checked)
                {
                    this.roles.Activo = true;
                }
                else this.roles.Activo = false;
                roles.opc = 4;
                
            this.rolH = new RolesHelper(roles);
                ///LOG PARA ROLES
                ///
                
                this.bitacora = new Bitacora();
                this.bitacora.Usuario = this.stsUsu.Text;
                this.bitacora.Movimiento = "Actualizar Rol";
                this.bitacora.Detalle = "Se actualizo el rol " + this.txtRol.Text;
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();
                
                //

                this.rolH.ActualizarRol();
                limpiar();
                MessageBox.Show("Datos del Rol actualizados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                if (!ValidarExistencia())
                {
                    roles = new Roles();
                    roles.Nombre = this.txtRol.Text.TrimEnd();
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
                    if (this.chckbxActivo.Checked)
                    {
                        this.roles.Activo = true;
                    }
                    else this.roles.Activo = false;
                    roles.opc = 2;
                    if (this.txtRol.Text != "")
                    {
                        this.rolH = new RolesHelper(roles);
                        ///LOG PARA ROLES

                        this.bitacora = new Bitacora();
                        this.bitacora.Usuario = this.stsUsu.Text;
                        this.bitacora.Movimiento = "Agregar Rol";
                        this.bitacora.Detalle = "Se agregó el nuevo rol " + this.txtRol.Text;
                        this.bitacora.opc = 5;
                        this.bitH = new BitacoraHelper(bitacora);
                        this.bitH.LogMovimientos();

                        this.rolH.GuardarRol();
                        MessageBox.Show("Rol almacenado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else
                        MessageBox.Show("Debe indicar el nombre del rol", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            this.txtID.ReadOnly = false;
            this.chckbxActivo.Checked = false;
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
            this.ActiveControl = txtRol;
            dgvListar.AllowUserToAddRows = false;
            limpiar();
            listar();
            dgvListar.ClearSelection();
            foreach (DataGridViewColumn column in dgvListar.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        
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
                    MessageBox.Show("No hay Registros de roles para actualizar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int indice = dgvListar.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.txtID.Text = fila["ID"].ToString();
                    this.txtRol.Text = fila["Nombre"].ToString();
                    this.chckRoles.Checked = bool.Parse(fila["Roles"].ToString());
                    this.chckUsuarios.Checked = bool.Parse(fila["Usuarios"].ToString());
                    this.chkEntrega.Checked = bool.Parse(fila["Entregas"].ToString());
                    this.chkInventario.Checked = bool.Parse(fila["Inventarios"].ToString());
                    this.chkPrestamo.Checked = bool.Parse(fila["Prestamos"].ToString());
                    this.chkBitacora.Checked = bool.Parse(fila["Bitacoras"].ToString());
                    this.chkOportunidades.Checked = bool.Parse(fila["Oportunidades"].ToString());
                    this.chkVendedores.Checked = bool.Parse(fila["Vendedores"].ToString());
                    this.chkClientesx.Checked = bool.Parse(fila["Clientes"].ToString());
                    this.chckbxActivo.Checked = bool.Parse(fila["Activo"].ToString());
                    this.txtID.ReadOnly = true;
                    this.btnAdd.Text = "ACTUALIZAR";
                }
}
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            #endregion
        }
        
        #region ACTIVAR DESACTIVAR ROL
        private void ActivarDesactivarRol()
        {
            try
            {
                if (this.dgvListar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debes seleccionar al menos un rol para el Activar/Desactivar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int indice = dgvListar.CurrentRow.Index;
                    DataRow fila = table.Rows[indice];
                    this.table = (DataTable)this.dgvListar.DataSource;
                    this.txtID.Text = fila["ID"].ToString();
                    this.roles = new Roles();
                    //    this.chckbxActivo.Checked = bool.Parse(fila["Activo"].ToString());
                    if (activarToolStripMenuItem.Text == "Desactivar")
                    {
                        roles.ID1 = int.Parse(fila["ID"].ToString());
                        roles.opc = 7;
                        this.rolH = new RolesHelper(roles);
                        this.rolH.Buscar();

                        MessageBox.Show("Se desactivo el rol", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.bitacora = new Bitacora();
                        this.bitacora.Usuario = this.stsUsu.Text;
                        this.bitacora.Movimiento = "Inactivación de rol";
                        this.bitacora.Detalle = "Se desactivo el rol correctamente ";
                        this.bitacora.opc = 5;
                        this.bitH = new BitacoraHelper(bitacora);
                        this.bitH.LogMovimientos();
                    }
                    else if (activarToolStripMenuItem.Text == "Activar")
                    {
                        roles.ID1 = int.Parse(fila["ID"].ToString());
                        roles.opc = 8;
                        this.rolH = new RolesHelper(roles);
                        this.rolH.Buscar();
                        MessageBox.Show("Se activo el rol");

                        this.bitacora = new Bitacora();
                        this.bitacora.Usuario = this.stsUsu.Text;
                        this.bitacora.Movimiento = "Activacion de rol";
                        this.bitacora.Detalle = "Se activo el rol correctamente ";
                        this.bitacora.opc = 5;
                        this.bitH = new BitacoraHelper(bitacora);
                        this.bitH.LogMovimientos();
                    }
                    listar();
                    limpiar();
                    dgvListar.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

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
            #region BUSCAR POR ID de rol
            try
            {
                if (txtBuscar.Text == "")
                {
                    listar();
                }
                else if (validate_number.IsMatch(txtBuscar.Text) != true)
                {
                    MessageBox.Show("El campo de busqueda solo permite numeros", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtBuscar.Text = txtBuscar.Text.Remove(txtBuscar.Text.Length - 1);
                    return;
                }
                else if (validate_Spaces.IsMatch(txtBuscar.Text) != true)
                {
                    MessageBox.Show("El campo de busqueda no permite espacios", "Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtBuscar.Text = txtBuscar.Text.Remove(txtBuscar.Text.Length - 1);
                    return;
                }
                else
                {
                    if (validate_number.IsMatch(txtBuscar.Text) != true)
                    {
                        MessageBox.Show("El campo BUSCAR solo permite numeros", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.ActiveControl = txtBuscar;
                        return;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        private void activarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivarDesactivarRol();
        }

        private void dgvListar_Click(object sender, EventArgs e)
        {
            #region DESACTIVAR O ACTIVAR SEGUN VALOR TOOL STRIP
            try
            {
                int indice = dgvListar.CurrentRow.Index;
                DataRow fila = table.Rows[indice];
                this.table = (DataTable)this.dgvListar.DataSource;
                if (bool.Parse(fila["Activo"].ToString()) == true)
                {
                    activarToolStripMenuItem.Text = "Desactivar";
                }
                else if (bool.Parse(fila["Activo"].ToString()) == false)
                {
                    activarToolStripMenuItem.Text = "Activar";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        private void txtRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
                e.Handled = (e.KeyChar == (char)Keys.Space);
            else
                e.Handled = false;
        }
    }
}
