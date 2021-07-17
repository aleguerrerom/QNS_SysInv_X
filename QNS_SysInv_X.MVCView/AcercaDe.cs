using QNS_SysInv_X.MVCController;
using System;
using System.Windows.Forms;

namespace QNS_SysInv_X.MVCView
{
    public partial class AcercaDe : Form
    {
        private Usuarios user;

        public AcercaDe()
        {
            InitializeComponent();
        }

        public AcercaDe(Usuarios usuario)
        {
            InitializeComponent();
            this.user = usuario;
            this.stsUsu.Text = this.user.Usuario;
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
        
    }
}
