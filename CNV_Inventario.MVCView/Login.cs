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
    public partial class Login : Form
    {
        private Usuarios user;
        private UsuariosHelper userHelper;
        private DataTable table;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtUsuarioLogin.Text != "" && this.txtClaveLogin.Text != "")
                {
                    this.user = new Usuarios();
                    this.user.Usuario = this.txtUsuarioLogin.Text;
                    this.user.Clave = this.txtClaveLogin.Text;
                    this.user.opc = 5;

                    this.userHelper = new UsuariosHelper(user);
                    this.table = new DataTable();
                    this.table = this.userHelper.ValidarLogin();


                    if (table.Rows.Count > 0)
                    {
                        DataRow fila = table.Rows[0];
                        this.user.Nombre = fila["nombre"].ToString();
                        //this.user.Rol = fila["rol"].ToString();
                        Principal inicio = new Principal(user);
 
                        inicio.Show();
                        this.Hide();
                        
                    }
                    else MessageBox.Show("Datos de inicio de sesión incorrectos");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
