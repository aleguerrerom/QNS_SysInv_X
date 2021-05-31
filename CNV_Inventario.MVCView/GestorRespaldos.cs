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
using System.IO;

namespace CNV_Inventario.MVCView
{
    public partial class GestorRespaldos : Form
    {

        private Respaldos res;
        private RespaldosHelper resh;
        private DataTable table;

        public GestorRespaldos()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            opdBrowse.InitialDirectory = "c:\\";
            opdBrowse.Filter = "Todos los archivos (*.*)|*.*";
            opdBrowse.FilterIndex = 1;
            opdBrowse.RestoreDirectory = true;

            if (opdBrowse.ShowDialog() == DialogResult.OK)
            {
                txtDirectorio.Text = opdBrowse.FileName;
            }

        }

        private void guardar()
        {
            try
            {
                //AGREGAR NUEVO USUARIO
                this.res = new Respaldos();

                this.res.Nombre = this.txtNombreArchivo.Text;
                this.res.Directorio = this.txtDirectorio.Text;
                
                this.res.opc = 1;
                this.resh = new RespaldosHelper(res);
                ///LOG PARA USUARIOS
               // LogMovimientos();

                this.resh.Guardar();
                MessageBox.Show("REsplado Almacenado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GestorRespaldos_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void listar() {

            try
            {

                this.res = new Respaldos();
                this.res.opc = 2;

                this.resh = new RespaldosHelper(res);

                this.table = new DataTable();
                this.table = this.resh.Listar();

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

        private void listardoc()
        {

            /*try
            {

                this.res = new Respaldos();
                this.res.opc = 3;

                this.resh = new RespaldosHelper(res);

                this.table = new DataTable();
                this.table = this.resh.Listar();

                if (this.table.Rows.Count > 0)
                {
                    this.dgvListar.DataSource = this.table;
                    this.dgvListar.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNombreArchivo.Text.Trim().Equals("") || txtDirectorio.Text.Trim().Equals(""))
            {

                MessageBox.Show("El nombre es obligatorio.");
                return;
            }

            byte[] file = null;
            Stream myStream = opdBrowse.OpenFile();
            using (MemoryStream ms = new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();
            }


            this.res = new Respaldos();

            this.res.Nombre = this.txtNombreArchivo.Text;
            this.res.Directorio = this.txtDirectorio.Text;
            this.res.Doc = file;


            this.res.opc = 1;
            this.resh = new RespaldosHelper(res);
            ///LOG PARA USUARIOS
            // LogMovimientos();

            this.resh.Guardar();
            listar();
            MessageBox.Show("REsplado Almacenado");
        }

        private void dgvListar_DoubleClick(object sender, EventArgs e)
        {
            listardoc();
        }
    }
}
