namespace QNS_SysInv_X.MVCView
{
    partial class ReporteEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteEntrega));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EntregaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_QNS = new CNV_Inventario.MVCView.DS_QNS();
            this.entregaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new CNV_Inventario.MVCView.DS_QNSTableAdapters.UsuariosTableAdapter();
            this.ClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new CNV_Inventario.MVCView.DS_QNSTableAdapters.ClientesTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.entregaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.entregaTableAdapter = new CNV_Inventario.MVCView.DS_QNSTableAdapters.EntregaTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsUsu = new System.Windows.Forms.ToolStripStatusLabel();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.entregaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.entregaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EntregaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_QNS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entregaBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entregaBindingSource1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entregaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entregaBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // EntregaBindingSource
            // 
            this.EntregaBindingSource.DataMember = "Entrega";
            this.EntregaBindingSource.DataSource = this.dS_QNS;
            // 
            // dS_QNS
            // 
            this.dS_QNS.DataSetName = "DS_QNS";
            this.dS_QNS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entregaBindingSource4
            // 
            this.entregaBindingSource4.DataSource = typeof(QNS_SysInv_X.MVCController.Entrega);
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.dS_QNS;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(767, 57);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(91, 28);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(870, 25);
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
            // ClientesBindingSource
            // 
            this.ClientesBindingSource.DataMember = "Clientes";
            this.ClientesBindingSource.DataSource = this.dS_QNS;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 8;
            reportDataSource1.Name = "DSEntrega";
            reportDataSource1.Value = this.EntregaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CNV_Inventario.MVCView.ReportEntrega.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 128);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(10, 414);
            this.reportViewer1.TabIndex = 68;
            // 
            // entregaBindingSource1
            // 
            this.entregaBindingSource1.DataMember = "Entrega";
            this.entregaBindingSource1.DataSource = this.dS_QNS;
            // 
            // entregaTableAdapter
            // 
            this.entregaTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsUsu});
            this.statusStrip1.Location = new System.Drawing.Point(0, 545);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(870, 22);
            this.statusStrip1.TabIndex = 69;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsUsu
            // 
            this.stsUsu.Name = "stsUsu";
            this.stsUsu.Size = new System.Drawing.Size(118, 17);
            this.stsUsu.Text = "toolStripStatusLabel1";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DSEntrega";
            reportDataSource2.Value = this.entregaBindingSource4;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "CNV_Inventario.MVCView.ReporteEntregas.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 25);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(870, 520);
            this.reportViewer2.TabIndex = 70;
            // 
            // entregaBindingSource2
            // 
            this.entregaBindingSource2.DataSource = typeof(QNS_SysInv_X.MVCController.Entrega);
            // 
            // entregaBindingSource3
            // 
            this.entregaBindingSource3.DataSource = typeof(QNS_SysInv_X.MVCController.Entrega);
            // 
            // ReporteEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(870, 567);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnLimpiar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(886, 606);
            this.MinimumSize = new System.Drawing.Size(886, 606);
            this.Name = "ReporteEntrega";
            this.Text = "REPORTE ENTREGA  | QNS_SysInv_X";
            this.Load += new System.EventHandler(this.ReporteUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EntregaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_QNS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entregaBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entregaBindingSource1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entregaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entregaBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CNV_Inventario.MVCView.DS_QNS dS_QNS;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private CNV_Inventario.MVCView.DS_QNSTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.BindingSource ClientesBindingSource;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private CNV_Inventario.MVCView.DS_QNSTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EntregaBindingSource;
        private System.Windows.Forms.BindingSource entregaBindingSource1;
        private CNV_Inventario.MVCView.DS_QNSTableAdapters.EntregaTableAdapter entregaTableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsUsu;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource entregaBindingSource2;
        private System.Windows.Forms.BindingSource entregaBindingSource3;
        private System.Windows.Forms.BindingSource entregaBindingSource4;
    }
}