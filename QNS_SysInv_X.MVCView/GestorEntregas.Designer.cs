﻿namespace QNS_SysInv_X.MVCView
{
    partial class GestorEntregas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorEntregas));
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.gpFecha = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.NºParte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nº_de_Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gpContacto = new System.Windows.Forms.GroupBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.gpMarca = new System.Windows.Forms.GroupBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtNumParte = new System.Windows.Forms.TextBox();
            this.gpSN = new System.Windows.Forms.GroupBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.lblNS = new System.Windows.Forms.Label();
            this.gbDireccion = new System.Windows.Forms.GroupBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.gpCantidad = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.gpDescripcion = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.gpEntregado = new System.Windows.Forms.GroupBox();
            this.txtEntregadoPor = new System.Windows.Forms.TextBox();
            this.lblEntregado = new System.Windows.Forms.Label();
            this.stsUsuario = new System.Windows.Forms.StatusStrip();
            this.stsUsua = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gpNumFactura = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbTelefono = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.gpFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gpContacto.SuspendLayout();
            this.gpMarca.SuspendLayout();
            this.gpSN.SuspendLayout();
            this.gbDireccion.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gpCantidad.SuspendLayout();
            this.gpDescripcion.SuspendLayout();
            this.gpEntregado.SuspendLayout();
            this.stsUsuario.SuspendLayout();
            this.gpNumFactura.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbTelefono.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(9, 389);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(293, 74);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel1.Text = "Salir";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // gpFecha
            // 
            this.gpFecha.BackColor = System.Drawing.Color.White;
            this.gpFecha.Controls.Add(this.dtpFecha);
            this.gpFecha.Controls.Add(this.lblFecha);
            this.gpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpFecha.Location = new System.Drawing.Point(7, 119);
            this.gpFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpFecha.Name = "gpFecha";
            this.gpFecha.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpFecha.Size = new System.Drawing.Size(363, 44);
            this.gpFecha.TabIndex = 48;
            this.gpFecha.TabStop = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(160, 16);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(193, 20);
            this.dtpFecha.TabIndex = 14;
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
            this.lblFecha.Size = new System.Drawing.Size(65, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "FECHA:      ";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvListar
            // 
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NºParte,
            this.Cantidad,
            this.Descripción,
            this.Nº_de_Serie});
            this.dgvListar.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvListar.Location = new System.Drawing.Point(9, 469);
            this.dgvListar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.Size = new System.Drawing.Size(734, 82);
            this.dgvListar.TabIndex = 45;
            this.dgvListar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListar_CellContentClick);
            this.dgvListar.DoubleClick += new System.EventHandler(this.dgvListar_DoubleClick);
            // 
            // NºParte
            // 
            this.NºParte.HeaderText = "NºParte";
            this.NºParte.Name = "NºParte";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            // 
            // Nº_de_Serie
            // 
            this.Nº_de_Serie.HeaderText = "Nº_de_Serie";
            this.Nº_de_Serie.Name = "Nº_de_Serie";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // gpContacto
            // 
            this.gpContacto.BackColor = System.Drawing.Color.White;
            this.gpContacto.Controls.Add(this.txtContacto);
            this.gpContacto.Controls.Add(this.lblContacto);
            this.gpContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpContacto.Location = new System.Drawing.Point(380, 16);
            this.gpContacto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpContacto.Name = "gpContacto";
            this.gpContacto.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpContacto.Size = new System.Drawing.Size(363, 44);
            this.gpContacto.TabIndex = 51;
            this.gpContacto.TabStop = false;
            // 
            // txtContacto
            // 
            this.txtContacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContacto.Location = new System.Drawing.Point(159, 16);
            this.txtContacto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(197, 13);
            this.txtContacto.TabIndex = 11;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.BackColor = System.Drawing.Color.Transparent;
            this.lblContacto.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Image = ((System.Drawing.Image)(resources.GetObject("lblContacto.Image")));
            this.lblContacto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblContacto.Location = new System.Drawing.Point(7, 16);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(89, 16);
            this.lblContacto.TabIndex = 3;
            this.lblContacto.Text = "CONTACTO:     ";
            this.lblContacto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpMarca
            // 
            this.gpMarca.BackColor = System.Drawing.Color.White;
            this.gpMarca.Controls.Add(this.lblMarca);
            this.gpMarca.Controls.Add(this.txtNumParte);
            this.gpMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpMarca.Location = new System.Drawing.Point(375, 76);
            this.gpMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpMarca.Name = "gpMarca";
            this.gpMarca.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpMarca.Size = new System.Drawing.Size(363, 44);
            this.gpMarca.TabIndex = 52;
            this.gpMarca.TabStop = false;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Image = ((System.Drawing.Image)(resources.GetObject("lblMarca.Image")));
            this.lblMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMarca.Location = new System.Drawing.Point(8, 18);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(135, 16);
            this.lblMarca.TabIndex = 33;
            this.lblMarca.Text = "NUMERO DE PARTE:     ";
            // 
            // txtNumParte
            // 
            this.txtNumParte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumParte.Location = new System.Drawing.Point(159, 18);
            this.txtNumParte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumParte.Name = "txtNumParte";
            this.txtNumParte.Size = new System.Drawing.Size(197, 13);
            this.txtNumParte.TabIndex = 21;
            // 
            // gpSN
            // 
            this.gpSN.BackColor = System.Drawing.Color.White;
            this.gpSN.Controls.Add(this.txtSN);
            this.gpSN.Controls.Add(this.lblNS);
            this.gpSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSN.Location = new System.Drawing.Point(3, 20);
            this.gpSN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpSN.Name = "gpSN";
            this.gpSN.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpSN.Size = new System.Drawing.Size(363, 44);
            this.gpSN.TabIndex = 50;
            this.gpSN.TabStop = false;
            // 
            // txtSN
            // 
            this.txtSN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSN.Location = new System.Drawing.Point(160, 16);
            this.txtSN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(197, 13);
            this.txtSN.TabIndex = 18;
            // 
            // lblNS
            // 
            this.lblNS.AutoSize = true;
            this.lblNS.BackColor = System.Drawing.Color.Transparent;
            this.lblNS.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNS.Image = ((System.Drawing.Image)(resources.GetObject("lblNS.Image")));
            this.lblNS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNS.Location = new System.Drawing.Point(7, 16);
            this.lblNS.Name = "lblNS";
            this.lblNS.Size = new System.Drawing.Size(133, 16);
            this.lblNS.TabIndex = 3;
            this.lblNS.Text = "NUMERO DE SERIE:      ";
            this.lblNS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbDireccion
            // 
            this.gbDireccion.BackColor = System.Drawing.Color.White;
            this.gbDireccion.Controls.Add(this.lblDireccion);
            this.gbDireccion.Controls.Add(this.txtDireccion);
            this.gbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDireccion.Location = new System.Drawing.Point(7, 68);
            this.gbDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDireccion.Name = "gbDireccion";
            this.gbDireccion.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDireccion.Size = new System.Drawing.Size(363, 44);
            this.gbDireccion.TabIndex = 47;
            this.gbDireccion.TabStop = false;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Image = ((System.Drawing.Image)(resources.GetObject("lblDireccion.Image")));
            this.lblDireccion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDireccion.Location = new System.Drawing.Point(7, 16);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(92, 16);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "DIRECCION:      ";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Location = new System.Drawing.Point(159, 18);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(193, 13);
            this.txtDireccion.TabIndex = 12;
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.Color.White;
            this.gbCliente.Controls.Add(this.lblCliente);
            this.gbCliente.Controls.Add(this.txtCliente);
            this.gbCliente.Location = new System.Drawing.Point(6, 16);
            this.gbCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCliente.Size = new System.Drawing.Size(363, 44);
            this.gbCliente.TabIndex = 46;
            this.gbCliente.TabStop = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Image = ((System.Drawing.Image)(resources.GetObject("lblCliente.Image")));
            this.lblCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCliente.Location = new System.Drawing.Point(8, 17);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(74, 16);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "CLIENTE:      ";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(156, 20);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(197, 13);
            this.txtCliente.TabIndex = 10;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(761, 25);
            this.toolStrip1.TabIndex = 67;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel2.Text = "SALIR";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // gpCantidad
            // 
            this.gpCantidad.BackColor = System.Drawing.Color.White;
            this.gpCantidad.Controls.Add(this.txtCantidad);
            this.gpCantidad.Controls.Add(this.lblCantidad);
            this.gpCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCantidad.Location = new System.Drawing.Point(373, 20);
            this.gpCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpCantidad.Name = "gpCantidad";
            this.gpCantidad.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpCantidad.Size = new System.Drawing.Size(363, 44);
            this.gpCantidad.TabIndex = 51;
            this.gpCantidad.TabStop = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Location = new System.Drawing.Point(160, 16);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(197, 13);
            this.txtCantidad.TabIndex = 19;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Image = ((System.Drawing.Image)(resources.GetObject("lblCantidad.Image")));
            this.lblCantidad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCantidad.Location = new System.Drawing.Point(9, 16);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(90, 16);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "CANTIDAD:      ";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpDescripcion
            // 
            this.gpDescripcion.BackColor = System.Drawing.Color.White;
            this.gpDescripcion.Controls.Add(this.txtDescripcion);
            this.gpDescripcion.Controls.Add(this.lblDescripcion);
            this.gpDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDescripcion.Location = new System.Drawing.Point(2, 76);
            this.gpDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpDescripcion.Name = "gpDescripcion";
            this.gpDescripcion.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpDescripcion.Size = new System.Drawing.Size(363, 44);
            this.gpDescripcion.TabIndex = 51;
            this.gpDescripcion.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Location = new System.Drawing.Point(160, 16);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(197, 13);
            this.txtDescripcion.TabIndex = 20;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Image = ((System.Drawing.Image)(resources.GetObject("lblDescripcion.Image")));
            this.lblDescripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDescripcion.Location = new System.Drawing.Point(7, 16);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(106, 16);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "DESCRIPCION:      ";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpEntregado
            // 
            this.gpEntregado.BackColor = System.Drawing.Color.White;
            this.gpEntregado.Controls.Add(this.txtEntregadoPor);
            this.gpEntregado.Controls.Add(this.lblEntregado);
            this.gpEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpEntregado.Location = new System.Drawing.Point(380, 68);
            this.gpEntregado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpEntregado.Name = "gpEntregado";
            this.gpEntregado.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpEntregado.Size = new System.Drawing.Size(363, 44);
            this.gpEntregado.TabIndex = 51;
            this.gpEntregado.TabStop = false;
            // 
            // txtEntregadoPor
            // 
            this.txtEntregadoPor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEntregadoPor.Location = new System.Drawing.Point(160, 16);
            this.txtEntregadoPor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEntregadoPor.Name = "txtEntregadoPor";
            this.txtEntregadoPor.Size = new System.Drawing.Size(197, 13);
            this.txtEntregadoPor.TabIndex = 13;
            // 
            // lblEntregado
            // 
            this.lblEntregado.AutoSize = true;
            this.lblEntregado.BackColor = System.Drawing.Color.Transparent;
            this.lblEntregado.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntregado.Image = ((System.Drawing.Image)(resources.GetObject("lblEntregado.Image")));
            this.lblEntregado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEntregado.Location = new System.Drawing.Point(7, 16);
            this.lblEntregado.Name = "lblEntregado";
            this.lblEntregado.Size = new System.Drawing.Size(126, 16);
            this.lblEntregado.TabIndex = 3;
            this.lblEntregado.Text = "ENTREGADO POR:      ";
            this.lblEntregado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stsUsuario
            // 
            this.stsUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stsUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsUsua});
            this.stsUsuario.Location = new System.Drawing.Point(0, 555);
            this.stsUsuario.Name = "stsUsuario";
            this.stsUsuario.Size = new System.Drawing.Size(761, 22);
            this.stsUsuario.TabIndex = 68;
            this.stsUsuario.Text = "statusStrip1";
            // 
            // stsUsua
            // 
            this.stsUsua.Name = "stsUsua";
            this.stsUsua.Size = new System.Drawing.Size(118, 17);
            this.stsUsua.Text = "toolStripStatusLabel1";
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(548, 429);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(148, 33);
            this.btnReport.TabIndex = 24;
            this.btnReport.Text = "IMPRIMIR REPORTE";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(383, 429);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 33);
            this.btnCancel.TabIndex = 23;
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
            this.btnAdd.Location = new System.Drawing.Point(375, 128);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 32);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "AGREGAR ARTICULO";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gpNumFactura
            // 
            this.gpNumFactura.BackColor = System.Drawing.Color.White;
            this.gpNumFactura.Controls.Add(this.label1);
            this.gpNumFactura.Controls.Add(this.txtNumFactura);
            this.gpNumFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpNumFactura.Location = new System.Drawing.Point(382, 120);
            this.gpNumFactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpNumFactura.Name = "gpNumFactura";
            this.gpNumFactura.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpNumFactura.Size = new System.Drawing.Size(363, 44);
            this.gpNumFactura.TabIndex = 53;
            this.gpNumFactura.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "NUMERO DE FACTURA:     ";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumFactura.Location = new System.Drawing.Point(181, 18);
            this.txtNumFactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(169, 13);
            this.txtNumFactura.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbTelefono);
            this.groupBox2.Controls.Add(this.gpNumFactura);
            this.groupBox2.Controls.Add(this.gpEntregado);
            this.groupBox2.Controls.Add(this.gpFecha);
            this.groupBox2.Controls.Add(this.gpContacto);
            this.groupBox2.Controls.Add(this.gbDireccion);
            this.groupBox2.Controls.Add(this.gbCliente);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 221);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DE ENTREGA";
            // 
            // gbTelefono
            // 
            this.gbTelefono.BackColor = System.Drawing.Color.White;
            this.gbTelefono.Controls.Add(this.label2);
            this.gbTelefono.Controls.Add(this.txtTelefono);
            this.gbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTelefono.Location = new System.Drawing.Point(7, 169);
            this.gbTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTelefono.Name = "gbTelefono";
            this.gbTelefono.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTelefono.Size = new System.Drawing.Size(363, 44);
            this.gbTelefono.TabIndex = 54;
            this.gbTelefono.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(8, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "TELEFONO:           ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Location = new System.Drawing.Point(159, 18);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(191, 13);
            this.txtTelefono.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gpMarca);
            this.groupBox3.Controls.Add(this.gpDescripcion);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.gpCantidad);
            this.groupBox3.Controls.Add(this.gpSN);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(752, 167);
            this.groupBox3.TabIndex = 70;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ARTICULOS A ENTREGAR";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // GestorEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(761, 577);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.stsUsuario);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dgvListar);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(777, 616);
            this.MinimumSize = new System.Drawing.Size(777, 616);
            this.Name = "GestorEntregas";
            this.Text = "GESTOR DE ENTREGAS  | QNS_SysInv_X";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Entregas_FormClosing);
            this.Load += new System.EventHandler(this.Entregas_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.gpFecha.ResumeLayout(false);
            this.gpFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gpContacto.ResumeLayout(false);
            this.gpContacto.PerformLayout();
            this.gpMarca.ResumeLayout(false);
            this.gpMarca.PerformLayout();
            this.gpSN.ResumeLayout(false);
            this.gpSN.PerformLayout();
            this.gbDireccion.ResumeLayout(false);
            this.gbDireccion.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gpCantidad.ResumeLayout(false);
            this.gpCantidad.PerformLayout();
            this.gpDescripcion.ResumeLayout(false);
            this.gpDescripcion.PerformLayout();
            this.gpEntregado.ResumeLayout(false);
            this.gpEntregado.PerformLayout();
            this.stsUsuario.ResumeLayout(false);
            this.stsUsuario.PerformLayout();
            this.gpNumFactura.ResumeLayout(false);
            this.gpNumFactura.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbTelefono.ResumeLayout(false);
            this.gbTelefono.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox gpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gpContacto;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.GroupBox gpMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtNumParte;
        private System.Windows.Forms.GroupBox gpSN;
        private System.Windows.Forms.Label lblNS;
        private System.Windows.Forms.GroupBox gbDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.GroupBox gpCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.GroupBox gpDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.GroupBox gpEntregado;
        private System.Windows.Forms.TextBox txtEntregadoPor;
        private System.Windows.Forms.Label lblEntregado;
        private System.Windows.Forms.StatusStrip stsUsuario;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsUsua;
        private System.Windows.Forms.GroupBox gpNumFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn NºParte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nº_de_Serie;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}