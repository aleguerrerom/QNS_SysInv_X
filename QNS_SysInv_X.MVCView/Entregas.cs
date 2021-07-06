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
    public partial class Entregas : Form
    {
        public Entregas()
        {
            InitializeComponent();
        }

        public Entregas(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsuario.Text = this.user.Usuario;
        }
        private DataTable table;
        private Bitacora bitacora;
        private BitacoraHelper bitH;
        private Entrega entrega;
        private EntregaHelper entregaH;
        private Usuarios user;
        private RegexExpression regexEx;

        static Regex validate_emailaddress = RegexExpression.email_validation();
        
        static Regex validate_Spaces = RegexExpression.AvoidSpaces_validation();

        static Regex validate_letter = RegexExpression.letter_validation();

        static Regex validate_number = RegexExpression.number_validation();

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (this.txtCliente.Text != "" || this.txtTipo.Text != "" || this.txtSN.Text != "" || this.txtMarca.Text != "" || this.txtDireccion.Text != ""
                 || this.txtCantidad.Text != "" || this.txtDescripcion.Text != "" || this.txtEntregadoPor.Text != "" || this.txtContacto.Text != "")
            {
                

                DialogResult dialogResult = MessageBox.Show("Desea salir? Si sale se eliminaaran lo datos ingresados", "SALIR", MessageBoxButtons.YesNo);
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

        #region LISTAR entrega
        private void listar()
        {
            try
            {

                this.entrega = new Entrega();
                this.entrega.Opc = 1;

                this.entregaH = new EntregaHelper(entrega);

                this.table = new DataTable();
                this.table = this.entregaH.Listar();

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

        #region GUARDAR entrega
        //FUNCION AGREGAR NUEVO USUARIO
        private void guardar()
        {
            try
            {
                //AGREGAR NUEVO USUARIO int.Parse(
                this.entrega = new Entrega();
                this.entrega.Cliente = this.txtCliente.Text;
                this.entrega.Tipo = this.txtTipo.Text;
                this.entrega.NumeroDeSerie = this.txtSN.Text;
                this.entrega.Marca = this.txtMarca.Text;
                this.entrega.Fecha = this.dtpFecha.Value;
                this.entrega.Contacto = this.txtContacto.Text;
                this.entrega.Dirrecion = this.txtDireccion.Text;
                this.entrega.Cantidad = int.Parse(this.txtCantidad.Text);
                this.entrega.Descripcion = this.txtDescripcion.Text;
                this.entrega.EntregadoPor = this.txtEntregadoPor.Text;
                
                this.entrega.Opc = 2;
                this.entregaH = new EntregaHelper(entrega);
                ///LOG PARA USUARIOS
                ///
                this.bitacora = new Bitacora();
               // this.bitacora.Usuario = this.stsUsuario.Text;
                this.bitacora.Movimiento = "Ingreso entrega";
                this.bitacora.Detalle = "Se proceso la entrega correctamente";
                this.bitacora.opc = 5;
                this.bitH = new BitacoraHelper(bitacora);
                this.bitH.LogMovimientos();

                this.entregaH.Entrega();
                MessageBox.Show("entrega Almacenado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void limpiar()
        {
            this.txtCliente.Text = "";
            this.txtTipo.Text = "";
            this.txtSN.Text = "";
            this.txtMarca.Text = "";
            this.dtpFecha.Value = DateTime.Today;
            this.txtDireccion.Text = "";
            this.txtCantidad.Text = "";
            this.txtDescripcion.Text = "";
            this.txtEntregadoPor.Text = "";
            this.txtContacto.Text = "";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReporteEntrega repoPrestamo = new ReporteEntrega();
            repoPrestamo.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES ESPACIO VACIOS Y SI ES AGREGA O ACTUALIZA
            if (this.txtCliente.Text == "" || this.txtTipo.Text == "" || this.txtSN.Text == "" || this.txtMarca.Text == "" || this.txtDireccion.Text == ""
                || this.txtCantidad.Text == "" || this.txtDescripcion.Text == "" || this.txtEntregadoPor.Text == "" || this.txtContacto.Text == "")
            {
            
            MessageBox.Show("Tienes que completar todos los campos, para procesar la entrega");
            }
                

                else if (validate_letter.IsMatch(txtContacto.Text) != true)
                {
                    MessageBox.Show("El campo CONTACTO solo permite letras", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContacto.Text.Remove(txtCliente.Text.Length - 1);
                txtContacto.Focus();
                }

                else if (validate_letter.IsMatch(txtTipo.Text) != true)
                {
                    MessageBox.Show("El campo TIPO solo permite letras", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTipo.Text.Remove(txtTipo.Text.Length - 1);
                txtTipo.Focus();
                }
                else if (validate_letter.IsMatch(txtEntregadoPor.Text) != true)
                {
                    MessageBox.Show("El campo ENTREGADO POR solo permite letras", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEntregadoPor.Text.Remove(txtEntregadoPor.Text.Length - 1);
                txtEntregadoPor.Focus();
                }
                else if (validate_number.IsMatch(txtCantidad.Text) != true)
                {
                    MessageBox.Show("El campo CEDULA solo permite numeros", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Text.Remove(txtCantidad.Text.Length - 1);
                txtCantidad.Focus();
                }
                  else if (validate_Spaces.IsMatch(txtCantidad.Text) != true)
                {
                MessageBox.Show("No se permiten espacios en el campo cantidad", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                return;
                }
            else
                {
                    guardar();
                    // procesarPrestamo();
                    // AlmacenarPrestamo();
                    limpiar();
                    listar();
                }

            



            #endregion
        }

        private void Entregas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.txtCliente.Text != "" || this.txtTipo.Text != "" || this.txtSN.Text != "" || this.txtMarca.Text != "" || this.txtDireccion.Text != ""
                || this.txtCantidad.Text != "" || this.txtDescripcion.Text != "" || this.txtEntregadoPor.Text != "" || this.txtContacto.Text != "")
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
    }
}
