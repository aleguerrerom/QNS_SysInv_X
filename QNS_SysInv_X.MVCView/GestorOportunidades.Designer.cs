namespace QNS_SysInv_X.MVCView
{
    partial class GestorOportunidades
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorOportunidades));
            this.gbPresupuesto = new System.Windows.Forms.GroupBox();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.txtPresupuesto = new System.Windows.Forms.TextBox();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbVendedor = new System.Windows.Forms.GroupBox();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.idl = new System.Windows.Forms.Label();
            this.cmbCedVendedor = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.gbDetalles = new System.Windows.Forms.GroupBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.gpFecha = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gbMarca = new System.Windows.Forms.GroupBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.gbClienteN = new System.Windows.Forms.GroupBox();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.stsUsuario = new System.Windows.Forms.StatusStrip();
            this.stsUsu = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.gbPresupuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.gbVendedor.SuspendLayout();
            this.gbDetalles.SuspendLayout();
            this.gpFecha.SuspendLayout();
            this.gbMarca.SuspendLayout();
            this.gbClienteN.SuspendLayout();
            this.stsUsuario.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(23, 178);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(293, 119);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // gbPresupuesto
            // 
            this.gbPresupuesto.BackColor = System.Drawing.Color.White;
            this.gbPresupuesto.Controls.Add(this.lblPresupuesto);
            this.gbPresupuesto.Controls.Add(this.txtPresupuesto);
            this.gbPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPresupuesto.Location = new System.Drawing.Point(22, 126);
            this.gbPresupuesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPresupuesto.Name = "gbPresupuesto";
            this.gbPresupuesto.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPresupuesto.Size = new System.Drawing.Size(363, 44);
            this.gbPresupuesto.TabIndex = 60;
            this.gbPresupuesto.TabStop = false;
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblPresupuesto.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.Image = ((System.Drawing.Image)(resources.GetObject("lblPresupuesto.Image")));
            this.lblPresupuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPresupuesto.Location = new System.Drawing.Point(7, 16);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(111, 16);
            this.lblPresupuesto.TabIndex = 3;
            this.lblPresupuesto.Text = "PRESUPUESTO:      ";
            this.lblPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPresupuesto.Location = new System.Drawing.Point(166, 18);
            this.txtPresupuesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(180, 13);
            this.txtPresupuesto.TabIndex = 2;
            this.txtPresupuesto.TextChanged += new System.EventHandler(this.txtPresupuesto_TextChanged);
            // 
            // dgvListar
            // 
            this.dgvListar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvListar.Location = new System.Drawing.Point(22, 311);
            this.dgvListar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.ReadOnly = true;
            this.dgvListar.Size = new System.Drawing.Size(747, 231);
            this.dgvListar.TabIndex = 57;
            this.dgvListar.DoubleClick += new System.EventHandler(this.dgvListar_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // gbVendedor
            // 
            this.gbVendedor.BackColor = System.Drawing.Color.White;
            this.gbVendedor.Controls.Add(this.cmbVendedor);
            this.gbVendedor.Controls.Add(this.lblVendedor);
            this.gbVendedor.Controls.Add(this.idl);
            this.gbVendedor.Controls.Add(this.cmbCedVendedor);
            this.gbVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVendedor.Location = new System.Drawing.Point(393, 126);
            this.gbVendedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbVendedor.Name = "gbVendedor";
            this.gbVendedor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbVendedor.Size = new System.Drawing.Size(363, 44);
            this.gbVendedor.TabIndex = 63;
            this.gbVendedor.TabStop = false;
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(159, 11);
            this.cmbVendedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(176, 21);
            this.cmbVendedor.TabIndex = 5;
            this.cmbVendedor.SelectedIndexChanged += new System.EventHandler(this.cmbVendedor_SelectedIndexChanged);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.BackColor = System.Drawing.Color.Transparent;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Image = ((System.Drawing.Image)(resources.GetObject("lblVendedor.Image")));
            this.lblVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVendedor.Location = new System.Drawing.Point(7, 16);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(93, 16);
            this.lblVendedor.TabIndex = 3;
            this.lblVendedor.Text = "VENDEDOR:      ";
            this.lblVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idl
            // 
            this.idl.AutoSize = true;
            this.idl.Location = new System.Drawing.Point(156, 16);
            this.idl.Name = "idl";
            this.idl.Size = new System.Drawing.Size(41, 13);
            this.idl.TabIndex = 67;
            this.idl.Text = "label1";
            this.idl.Click += new System.EventHandler(this.idl_Click);
            // 
            // cmbCedVendedor
            // 
            this.cmbCedVendedor.FormattingEnabled = true;
            this.cmbCedVendedor.Location = new System.Drawing.Point(179, 11);
            this.cmbCedVendedor.Name = "cmbCedVendedor";
            this.cmbCedVendedor.Size = new System.Drawing.Size(121, 21);
            this.cmbCedVendedor.TabIndex = 73;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(159, 14);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(177, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // gbDetalles
            // 
            this.gbDetalles.BackColor = System.Drawing.Color.White;
            this.gbDetalles.Controls.Add(this.lblDetalles);
            this.gbDetalles.Controls.Add(this.txtDetalles);
            this.gbDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalles.Location = new System.Drawing.Point(393, 75);
            this.gbDetalles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetalles.Name = "gbDetalles";
            this.gbDetalles.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetalles.Size = new System.Drawing.Size(363, 44);
            this.gbDetalles.TabIndex = 64;
            this.gbDetalles.TabStop = false;
            this.gbDetalles.Enter += new System.EventHandler(this.gbDetalles_Enter);
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Image = ((System.Drawing.Image)(resources.GetObject("lblDetalles.Image")));
            this.lblDetalles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDetalles.Location = new System.Drawing.Point(8, 18);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(81, 16);
            this.lblDetalles.TabIndex = 33;
            this.lblDetalles.Text = "DETALLES:     ";
            // 
            // txtDetalles
            // 
            this.txtDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetalles.Location = new System.Drawing.Point(159, 18);
            this.txtDetalles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(177, 13);
            this.txtDetalles.TabIndex = 4;
            this.txtDetalles.TextChanged += new System.EventHandler(this.txtDetalles_TextChanged);
            // 
            // gpFecha
            // 
            this.gpFecha.BackColor = System.Drawing.Color.White;
            this.gpFecha.Controls.Add(this.dtpFecha);
            this.gpFecha.Controls.Add(this.lblFecha);
            this.gpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpFecha.Location = new System.Drawing.Point(393, 23);
            this.gpFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpFecha.Name = "gpFecha";
            this.gpFecha.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpFecha.Size = new System.Drawing.Size(363, 44);
            this.gpFecha.TabIndex = 61;
            this.gpFecha.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Image = ((System.Drawing.Image)(resources.GetObject("lblFecha.Image")));
            this.lblFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFecha.Location = new System.Drawing.Point(7, 16);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(125, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "FECHA DE CIERRE:      ";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbMarca
            // 
            this.gbMarca.BackColor = System.Drawing.Color.White;
            this.gbMarca.Controls.Add(this.lblMarca);
            this.gbMarca.Controls.Add(this.txtMarca);
            this.gbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMarca.Location = new System.Drawing.Point(23, 75);
            this.gbMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMarca.Name = "gbMarca";
            this.gbMarca.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMarca.Size = new System.Drawing.Size(363, 44);
            this.gbMarca.TabIndex = 59;
            this.gbMarca.TabStop = false;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Image = ((System.Drawing.Image)(resources.GetObject("lblMarca.Image")));
            this.lblMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMarca.Location = new System.Drawing.Point(7, 16);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(71, 16);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "MARCA:      ";
            this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMarca
            // 
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarca.Location = new System.Drawing.Point(165, 16);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(180, 13);
            this.txtMarca.TabIndex = 1;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // gbClienteN
            // 
            this.gbClienteN.BackColor = System.Drawing.Color.White;
            this.gbClienteN.Controls.Add(this.cmbNombre);
            this.gbClienteN.Controls.Add(this.lblNombreCliente);
            this.gbClienteN.Location = new System.Drawing.Point(22, 23);
            this.gbClienteN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbClienteN.Name = "gbClienteN";
            this.gbClienteN.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbClienteN.Size = new System.Drawing.Size(363, 44);
            this.gbClienteN.TabIndex = 58;
            this.gbClienteN.TabStop = false;
            // 
            // cmbNombre
            // 
            this.cmbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(166, 14);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(180, 21);
            this.cmbNombre.TabIndex = 0;
            this.cmbNombre.SelectedIndexChanged += new System.EventHandler(this.cmbNombre_SelectedIndexChanged);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Image = ((System.Drawing.Image)(resources.GetObject("lblNombreCliente.Image")));
            this.lblNombreCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNombreCliente.Location = new System.Drawing.Point(8, 20);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(146, 16);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "NOMBRE DE CLIENTE:      ";
            this.lblNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(552, 264);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(96, 33);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "REPORTES";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(434, 264);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 33);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(322, 264);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 33);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "AGREGAR";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // stsUsuario
            // 
            this.stsUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stsUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsUsu});
            this.stsUsuario.Location = new System.Drawing.Point(0, 547);
            this.stsUsuario.Name = "stsUsuario";
            this.stsUsuario.Size = new System.Drawing.Size(792, 22);
            this.stsUsuario.TabIndex = 68;
            this.stsUsuario.Text = "statusStrip1";
            // 
            // stsUsu
            // 
            this.stsUsu.Name = "stsUsu";
            this.stsUsu.Size = new System.Drawing.Size(118, 17);
            this.stsUsu.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 25);
            this.toolStrip1.TabIndex = 69;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "SALIR";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(654, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "Buscar por ID:";
            this.label9.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(657, 270);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(99, 20);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // GestorOportunidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(792, 569);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.stsUsuario);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.gbPresupuesto);
            this.Controls.Add(this.dgvListar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbVendedor);
            this.Controls.Add(this.gbDetalles);
            this.Controls.Add(this.gpFecha);
            this.Controls.Add(this.gbMarca);
            this.Controls.Add(this.gbClienteN);
            this.MaximumSize = new System.Drawing.Size(808, 608);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(808, 608);
            this.Name = "GestorOportunidades";
            this.Text = "GESTOR OPORTUNIDADES  | QNS_SysInv_X";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestorOportunidades_FormClosing);
            this.Load += new System.EventHandler(this.GestorOportunidades_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.gbPresupuesto.ResumeLayout(false);
            this.gbPresupuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.gbVendedor.ResumeLayout(false);
            this.gbVendedor.PerformLayout();
            this.gbDetalles.ResumeLayout(false);
            this.gbDetalles.PerformLayout();
            this.gpFecha.ResumeLayout(false);
            this.gpFecha.PerformLayout();
            this.gbMarca.ResumeLayout(false);
            this.gbMarca.PerformLayout();
            this.gbClienteN.ResumeLayout(false);
            this.gbClienteN.PerformLayout();
            this.stsUsuario.ResumeLayout(false);
            this.stsUsuario.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox gbPresupuesto;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.TextBox txtPresupuesto;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbVendedor;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.GroupBox gbDetalles;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.GroupBox gpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.GroupBox gbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.GroupBox gbClienteN;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label idl;
        private System.Windows.Forms.StatusStrip stsUsuario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbCedVendedor;
        private System.Windows.Forms.ToolStripStatusLabel stsUsu;
    }
}