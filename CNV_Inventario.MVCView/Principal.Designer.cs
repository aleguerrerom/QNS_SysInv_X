namespace CNV_Inventario.MVCView
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsArchivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.ingresarConOtroUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPrestamo = new System.Windows.Forms.ToolStripLabel();
            this.tsUsuarios = new System.Windows.Forms.ToolStripLabel();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripLabel();
            this.tsAboutUs = new System.Windows.Forms.ToolStripLabel();
            this.tsRoles = new System.Windows.Forms.ToolStripLabel();
            this.tsAyuda = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripInventario = new System.Windows.Forms.ToolStripLabel();
            this.tsrEntrega = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsArchivo,
            this.tsPrestamo,
            this.tsUsuarios,
            this.aboutUsToolStripMenuItem,
            this.tsRoles,
            this.toolStripInventario,
            this.tsrEntrega,
            this.tsAboutUs,
            this.tsAyuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(586, 25);
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
            // tsPrestamo
            // 
            this.tsPrestamo.Name = "tsPrestamo";
            this.tsPrestamo.Size = new System.Drawing.Size(57, 22);
            this.tsPrestamo.Text = "Prestamo";
            this.tsPrestamo.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // tsUsuarios
            // 
            this.tsUsuarios.Name = "tsUsuarios";
            this.tsUsuarios.Size = new System.Drawing.Size(52, 22);
            this.tsUsuarios.Text = "Usuarios";
            this.tsUsuarios.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
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
            // tsAboutUs
            // 
            this.tsAboutUs.Name = "tsAboutUs";
            this.tsAboutUs.Size = new System.Drawing.Size(57, 22);
            this.tsAboutUs.Text = "AcercaDe";
            this.tsAboutUs.Click += new System.EventHandler(this.tsAboutUs_Click);
            // 
            // tsRoles
            // 
            this.tsRoles.Name = "tsRoles";
            this.tsRoles.Size = new System.Drawing.Size(35, 22);
            this.tsRoles.Text = "Roles";
            this.tsRoles.Click += new System.EventHandler(this.toolStripLabel5_Click);
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
            this.statusStrip1.Size = new System.Drawing.Size(586, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusUsuario
            // 
            this.statusUsuario.Name = "statusUsuario";
            this.statusUsuario.Size = new System.Drawing.Size(78, 17);
            this.statusUsuario.Text = "statusUsuario";
            // 
            // toolStripInventario
            // 
            this.toolStripInventario.Name = "toolStripInventario";
            this.toolStripInventario.Size = new System.Drawing.Size(60, 22);
            this.toolStripInventario.Text = "Inventario";
            this.toolStripInventario.Click += new System.EventHandler(this.toolStripInventario_Click);
            // 
            // tsrEntrega
            // 
            this.tsrEntrega.Name = "tsrEntrega";
            this.tsrEntrega.Size = new System.Drawing.Size(47, 22);
            this.tsrEntrega.Text = "Entrega";
            this.tsrEntrega.Click += new System.EventHandler(this.tsrEntrega_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 397);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.Text = "Principal";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripLabel tsPrestamo;
        private System.Windows.Forms.ToolStripLabel tsUsuarios;
        private System.Windows.Forms.ToolStripLabel aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel tsAboutUs;
        private System.Windows.Forms.ToolStripLabel tsRoles;
        private System.Windows.Forms.ToolStripLabel tsAyuda;
        private System.Windows.Forms.ToolStripMenuItem cambiarClaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripInventario;
        private System.Windows.Forms.ToolStripLabel tsrEntrega;
    }
}