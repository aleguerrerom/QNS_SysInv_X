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
using Microsoft.Reporting.WinForms;

namespace CNV_Inventario.MVCView
{
    public partial class UsuariosReport : Form
    {
        private Usuarios user;
        private UsuariosHelper userHelper;
        private DataTable table;

        public UsuariosReport()
        {
            InitializeComponent();
        }

        private void UsuariosReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        
        
    }
}
