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
            guardar();
            listar();
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
    }
}
