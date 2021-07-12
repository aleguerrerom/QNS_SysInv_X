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
    public partial class VerBitacora : Form
    {
        private Bitacora bitacora;
        private BitacoraHelper bitH;
        private DataTable table;
       

        public VerBitacora()
        {
            InitializeComponent();
        }
        
        private void listadoLogsUsuarios()
        {

            try
            {

                this.bitacora = new Bitacora();
                this.bitacora.opc = 1;

                //rolhelper
                this.bitH = new BitacoraHelper(bitacora);

                //datatable
                this.table = new DataTable();

                this.table = bitH.Listar();
                if (table.Rows.Count > 0)
                    this.dgvListar.DataSource = table;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Bitacora_Load(object sender, EventArgs e)
        {
            listadoLogsUsuarios();
            LabelDescription.Text = "Logs de Usuarios Logeados";
            btnChange.Text = "VER LOGS DE MOVIMIENTOS";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnChange.Text == "VER LOGS DE LOG IN")
            {
                listadoLogsUsuarios();
                LabelDescription.Text = "Logs de Usuarios Logeados";
                btnChange.Text = "VER LOGS DE MOVIMIENTOS";
            }
            else
            {
                listadoLogsMovimientos();
                LabelDescription.Text = "Detalle de Logs de Movimientos en la Aplicacion";
                btnChange.Text = "VER LOGS DE LOG IN";
            }
        }

        private void listadoLogsMovimientos()
        {

            try
            {

                this.bitacora = new Bitacora();
                this.bitacora.opc = 4;

                //rolhelper
                this.bitH = new BitacoraHelper(bitacora);

                //datatable
                this.table = new DataTable();

                this.table = bitH.Listar();
                if (table.Rows.Count > 0)
                    this.dgvListar.DataSource = table;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
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
                    ReporteLogsInicio reporte = new ReporteLogsInicio();
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
                    ReporteMovimientos reportem = new ReporteMovimientos();
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
