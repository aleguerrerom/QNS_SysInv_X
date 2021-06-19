namespace QNS_SysInv_X.MVCView
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            System.Windows.Forms.PictureBox pictureBox1;
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsArchivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.ingresarConOtroUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMantenimiento = new System.Windows.Forms.ToolStripSplitButton();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oportunidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripLabel();
            this.tsrTramite = new System.Windows.Forms.ToolStripSplitButton();
            this.entregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tslBitacora = new System.Windows.Forms.ToolStripLabel();
            this.tsAboutUs = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsAyuda = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsArchivo,
            this.tsMantenimiento,
            this.aboutUsToolStripMenuItem,
            this.tsrTramite,
            this.tslBitacora,
            this.tsAboutUs,
            this.toolStripLabel1,
            this.tsAyuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(699, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsArchivo
            // 
            this.tsArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarConOtroUsuarioToolStripMenuItem,
            this.cambiarClaveToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.tsArchivo.Name = "tsArchivo";
            this.tsArchivo.Size = new System.Drawing.Size(61, 22);
            this.tsArchivo.Text = "Archivo";
            this.tsArchivo.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // ingresarConOtroUsuarioToolStripMenuItem
            // 
            this.ingresarConOtroUsuarioToolStripMenuItem.Name = "ingresarConOtroUsuarioToolStripMenuItem";
            this.ingresarConOtroUsuarioToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.ingresarConOtroUsuarioToolStripMenuItem.Text = "Ingresar con otro Usuario";
            this.ingresarConOtroUsuarioToolStripMenuItem.Click += new System.EventHandler(this.ingresarConOtroUsuarioToolStripMenuItem_Click);
            // 
            // cambiarClaveToolStripMenuItem
            // 
            this.cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            this.cambiarClaveToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cambiarClaveToolStripMenuItem.Text = "Cambiar Clave";
            this.cambiarClaveToolStripMenuItem.Click += new System.EventHandler(this.cambiarClaveToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tsMantenimiento
            // 
            this.tsMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.oportunidadesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.vendedoresToolStripMenuItem});
            this.tsMantenimiento.Name = "tsMantenimiento";
            this.tsMantenimiento.Size = new System.Drawing.Size(105, 22);
            this.tsMantenimiento.Text = "Mantenimiento";
            this.tsMantenimiento.ButtonClick += new System.EventHandler(this.tsPrestamo_ButtonClick);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Visible = false;
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Visible = false;
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click_1);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Visible = false;
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // oportunidadesToolStripMenuItem
            // 
            this.oportunidadesToolStripMenuItem.Name = "oportunidadesToolStripMenuItem";
            this.oportunidadesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.oportunidadesToolStripMenuItem.Text = "Oportunidades";
            this.oportunidadesToolStripMenuItem.Click += new System.EventHandler(this.oportunidadesToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            this.vendedoresToolStripMenuItem.Click += new System.EventHandler(this.vendedoresToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutUsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(0, 22);
            this.aboutUsToolStripMenuItem.Text = "Acerca De";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.toolStripLabel4_Click);
            // 
            // tsrTramite
            // 
            this.tsrTramite.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entregaToolStripMenuItem,
            this.prestamoToolStripMenuItem});
            this.tsrTramite.Name = "tsrTramite";
            this.tsrTramite.Size = new System.Drawing.Size(67, 22);
            this.tsrTramite.Text = "Tramites";
            // 
            // entregaToolStripMenuItem
            // 
            this.entregaToolStripMenuItem.Name = "entregaToolStripMenuItem";
            this.entregaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.entregaToolStripMenuItem.Text = "Entrega";
            this.entregaToolStripMenuItem.Visible = false;
            this.entregaToolStripMenuItem.Click += new System.EventHandler(this.entregaToolStripMenuItem_Click);
            // 
            // prestamoToolStripMenuItem
            // 
            this.prestamoToolStripMenuItem.Name = "prestamoToolStripMenuItem";
            this.prestamoToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.prestamoToolStripMenuItem.Text = "Prestamo";
            this.prestamoToolStripMenuItem.Visible = false;
            this.prestamoToolStripMenuItem.Click += new System.EventHandler(this.prestamoToolStripMenuItem_Click);
            // 
            // tslBitacora
            // 
            this.tslBitacora.Name = "tslBitacora";
            this.tslBitacora.Size = new System.Drawing.Size(50, 22);
            this.tslBitacora.Text = "Bitacora";
            this.tslBitacora.Visible = false;
            this.tslBitacora.Click += new System.EventHandler(this.tslBitacora_Click);
            // 
            // tsAboutUs
            // 
            this.tsAboutUs.Name = "tsAboutUs";
            this.tsAboutUs.Size = new System.Drawing.Size(57, 22);
            this.tsAboutUs.Text = "AcercaDe";
            this.tsAboutUs.Click += new System.EventHandler(this.tsAboutUs_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 22);
            this.toolStripLabel1.Text = "Respaldos";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // tsAyuda
            // 
            this.tsAyuda.Name = "tsAyuda";
            this.tsAyuda.Size = new System.Drawing.Size(41, 22);
            this.tsAyuda.Text = "Ayuda";
            this.tsAyuda.Click += new System.EventHandler(this.tsAyuda_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 375);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(699, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusUsuario
            // 
            this.statusUsuario.Name = "statusUsuario";
            this.statusUsuario.Size = new System.Drawing.Size(78, 17);
            this.statusUsuario.Text = "statusUsuario";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            pictureBox2.Location = new System.Drawing.Point(524, 175);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(175, 201);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(0, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(251, 97);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(699, 397);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Leave += new System.EventHandler(this.Principal_Leave);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusUsuario;
        private System.Windows.Forms.ToolStripDropDownButton tsArchivo;
        private System.Windows.Forms.ToolStripMenuItem ingresarConOtroUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel tsAboutUs;
        private System.Windows.Forms.ToolStripLabel tsAyuda;
        private System.Windows.Forms.ToolStripMenuItem cambiarClaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel tslBitacora;
        private System.Windows.Forms.ToolStripSplitButton tsMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton tsrTramite;
        private System.Windows.Forms.ToolStripMenuItem entregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem oportunidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
    }
}