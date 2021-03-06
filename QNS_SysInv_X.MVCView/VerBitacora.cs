using System;
using System.Data;
using System.Windows.Forms;
using QNS_SysInv_X.MVCController;

namespace QNS_SysInv_X.MVCView
{
    public partial class VerBitacora : Form
    {
        private Bitacora bitacora;
        private BitacoraHelper bitH;
        private DataTable table;
        private Usuarios user;

        public VerBitacora()
        {
            InitializeComponent();
        }
        
        public VerBitacora(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsuarios.Text = this.user.Usuario;
        }

        #region LISTADO DE LOGS DE USUARIOS
        private void listadoLogsUsuarios()
        {
            try
            {
                this.bitacora = new Bitacora();
                this.bitacora.opc = 1;
                
                this.bitH = new BitacoraHelper(bitacora);
                this.table = new DataTable();

                this.table = bitH.Listar();
                if (table.Rows.Count > 0)
                { this.dgvListar.DataSource = table; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void Bitacora_Load(object sender, EventArgs e)
        {
            listadoLogsUsuarios();
            LabelDescription.Text = "Logs de Usuarios Logeados";
            btnChange.Text = "VER LOGS DE MOVIMIENTOS";
            dgvListar.Height = 260;
            dgvListar.Width = 380;
            dgvListar.Left = 130;
            dgvListar.Top = 215;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnChange.Text == "VER LOGS DE LOG IN")
            {
                listadoLogsUsuarios();
                LabelDescription.Text = "Logs de Usuarios Logeados";
                btnChange.Text = "VER LOGS DE MOVIMIENTOS";
                dgvListar.Height = 260;
                dgvListar.Width = 380;
                dgvListar.Left = 130;
                dgvListar.Top = 215;
            }
            else
            {
                listadoLogsMovimientos();
                LabelDescription.Text = "Detalle de Logs de Movimientos en la Aplicación";
                btnChange.Text = "VER LOGS DE LOG IN";
                dgvListar.Height = 260;
                dgvListar.Width = 643;
                dgvListar.Left = 12;
                dgvListar.Top = 215;
            }
        }
        
        #region BITACORA DE MOVIMIENTOS
        private void listadoLogsMovimientos()
        {
            try
            {
                this.bitacora = new Bitacora();
                this.bitacora.opc = 4;
                this.bitH = new BitacoraHelper(bitacora);
                this.table = new DataTable();

                this.table = bitH.Listar();
                if (table.Rows.Count > 0)
                { this.dgvListar.DataSource = table; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (btnChange.Text == "VER LOGS DE MOVIMIENTOS")
            {
                bool IsOpen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text == "REPORTES DE LOGS  | QNS_SysInv_X")
                    {
                        IsOpen = true;
                        f.BringToFront();
                    }
                }
                if (IsOpen == false)
                {
                    ReporteLogsInicio reporte = new ReporteLogsInicio(user);
                    reporte.Show();
                }
            }
            else
            {
                bool IsOpen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text == "REPORTE MOVIMIENTOS  | QNS_SysInv_X")
                    {
                        IsOpen = true;
                        f.BringToFront();
                    }
                }
                if (IsOpen == false)
                {
                    ReporteMovimientos reportem = new ReporteMovimientos(user);
                    reportem.Show();
                }
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
