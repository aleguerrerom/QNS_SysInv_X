namespace QNS_SysInv_X.MVCView
{
    partial class RerporteClientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.PictureBox pictureBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RerporteClientes));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_QNS = new CNV_Inventario.MVCView.DS_QNS();
            this.clientesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new CNV_Inventario.MVCView.DS_QNSTableAdapters.UsuariosTableAdapter();
            this.clientesTableAdapter = new CNV_Inventario.MVCView.DS_QNSTableAdapters.ClientesTableAdapter();
            this.cmbFiltrar = new System.Windows.Forms.ComboBox();
            this.stsStrip = new System.Windows.Forms.StatusStrip();
            this.stsUsu = new System.Windows.Forms.ToolStripStatusLabel();
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_QNS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.stsStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            pictureBox2.Location = new System.Drawing.Point(12, 30);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(248, 84);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // ClientesBindingSource
            // 
            this.ClientesBindingSource.DataMember = "Clientes";
            this.ClientesBindingSource.DataSource = this.dS_QNS;
            // 
            // dS_QNS
            // 
            this.dS_QNS.DataSetName = "DS_QNS";
            this.dS_QNS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource3
            // 
            this.clientesBindingSource3.DataSource = typeof(QNS_SysInv_X.MVCController.Clientes);
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.dS_QNS;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(642, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "FILTRO";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "FILTRAR POR:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(502, 54);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(130, 20);
            this.txtFiltro.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(749, 53);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 24);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource3.Name = "DSClientes";
            reportDataSource3.Value = this.ClientesBindingSource;
            reportDataSource4.Name = "DSClientesLocal";
            reportDataSource4.Value = this.clientesBindingSource4;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CNV_Inventario.MVCView.ReportClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 121);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(832, 421);
            this.reportViewer1.TabIndex = 65;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(855, 25);
            this.toolStrip1.TabIndex = 66;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "SALIR";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.dS_QNS;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // cmbFiltrar
            // 
            this.cmbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrar.FormattingEnabled = true;
            this.cmbFiltrar.Items.AddRange(new object[] {
            "Cedula",
            "Nombre"});
            this.cmbFiltrar.Location = new System.Drawing.Point(370, 53);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltrar.TabIndex = 0;
            // 
            // stsStrip
            // 
            this.stsStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsUsu});
            this.stsStrip.Location = new System.Drawing.Point(0, 545);
            this.stsStrip.Name = "stsStrip";
            this.stsStrip.Size = new System.Drawing.Size(855, 22);
            this.stsStrip.TabIndex = 67;
            this.stsStrip.Text = "statusStrip1";
            // 
            // stsUsu
            // 
            this.stsUsu.Name = "stsUsu";
            this.stsUsu.Size = new System.Drawing.Size(118, 17);
            this.stsUsu.Text = "toolStripStatusLabel1";
            this.stsUsu.Click += new System.EventHandler(this.stsUsu_Click);
            // 
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataSource = typeof(QNS_SysInv_X.MVCController.Clientes);
            // 
            // clientesBindingSource4
            // 
            this.clientesBindingSource4.DataSource = typeof(QNS_SysInv_X.MVCController.Clientes);
            // 
            // RerporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(855, 567);
            this.Controls.Add(this.stsStrip);
            this.Controls.Add(this.cmbFiltrar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(pictureBox2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(871, 606);
            this.MinimumSize = new System.Drawing.Size(871, 606);
            this.Name = "RerporteClientes";
            this.Text = "REPORTE CLIENTES | QNS_SysInv_X";
            this.Load += new System.EventHandler(this.ReporteUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_QNS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.stsStrip.ResumeLayout(false);
            this.stsStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private CNV_Inventario.MVCView.DS_QNS dS_QNS;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private CNV_Inventario.MVCView.DS_QNSTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnLimpiar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClientesBindingSource;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private CNV_Inventario.MVCView.DS_QNSTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ComboBox cmbFiltrar;
        private System.Windows.Forms.StatusStrip stsStrip;
        private System.Windows.Forms.ToolStripStatusLabel stsUsu;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        private System.Windows.Forms.BindingSource clientesBindingSource3;
        private System.Windows.Forms.BindingSource clientesBindingSource4;
    }
}