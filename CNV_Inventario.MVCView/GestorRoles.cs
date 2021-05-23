using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNV_Inventario.MVCController;
namespace CNV_Inventario.MVCView
{
    public partial class GestorRoles : Form
    {
        private Roles roles;
        private RolesHelper rolH;
        private DataTable table;
        public static string inventario;
        public static string usuarios;
        public static string prestamo;
        public static string entrega;
        public static string roless;

        public GestorRoles()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtRol.Text == "")
            {
                MessageBox.Show("Tienes que llenar el campo de nombre de rol para agregar o actualizar");
            }
            else
            {
                if (this.txtRol.ReadOnly)
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
        }

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
            roles.opc = 4;


            this.rolH = new RolesHelper(roles);
            this.rolH.ActualizarRol();
                limpiar();
                MessageBox.Show("Datos del Rol actualizados");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            limpiar();
        }

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
                roles.opc = 2;
                //roles.id_username_bitacora = Principal.id_username_bitacora;
                if (this.txtRol.Text != "")
                {
                    this.rolH = new RolesHelper(roles);
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

        public void limpiar()
        {
            this.txtRol.Clear();
            this.chckRoles.Checked = false;
            this.chkEntrega.Checked = false;
            this.chckUsuarios.Checked = false;
            this.chkInventario.Checked = false;
            this.chkPrestamo.Checked = false;
            this.btnAdd.Text = "AGREGAR";
            this.txtRol.ReadOnly = false;
        }

        private void listar()
        {
            try
            {
                
                this.roles = new Roles();
                this.roles.opc = 1;

                //rolhelper
                this.rolH = new RolesHelper(roles);

                //datatable
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



        private void GestorRoles_Load(object sender, EventArgs e)
        {
            limpiar();
            listar();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                    this.roles= new Roles();
                    this.roles.Nombre = fila["nombre"].ToString();
                    this.roles.opc = 3;
                    this.rolH = new RolesHelper(roles);
                    this.rolH.Eliminar();
                    MessageBox.Show("Usuario Eliminado Eliminado");
                    listar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvListar_DoubleClick(object sender, EventArgs e)
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
                    this.txtRol.Text = fila["nombre"].ToString();
                    this.chckRoles.Checked = bool.Parse(fila["roles"].ToString());
                    this.chckUsuarios.Checked = bool.Parse(fila["usuarios"].ToString());
                    this.chkEntrega.Checked = bool.Parse(fila["entrega"].ToString());
                    this.chkInventario.Checked = bool.Parse(fila["inventario"].ToString());
                    this.chkPrestamo.Checked = bool.Parse(fila["prestamo"].ToString());
                     this.txtRol.ReadOnly = true;
                    this.btnAdd.Text = "ACTUALIZAR";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
