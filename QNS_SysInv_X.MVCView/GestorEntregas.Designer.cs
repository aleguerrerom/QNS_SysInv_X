namespace QNS_SysInv_X.MVCView
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gpContacto = new System.Windows.Forms.GroupBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.gpMarca = new System.Windows.Forms.GroupBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.gpTipo = new System.Windows.Forms.GroupBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
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
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.gpFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.gpContacto.SuspendLayout();
            this.gpMarca.SuspendLayout();
            this.gpTipo.SuspendLayout();
            this.gpSN.SuspendLayout();
            this.gbDireccion.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gpCantidad.SuspendLayout();
            this.gpDescripcion.SuspendLayout();
            this.gpEntregado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(13, 285);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(293, 97);
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
            this.gpFecha.Location = new System.Drawing.Point(12, 132);
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
            this.dtpFecha.TabIndex = 2;
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
            this.dgvListar.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvListar.Location = new System.Drawing.Point(9, 391);
            this.dgvListar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.Size = new System.Drawing.Size(734, 155);
            this.dgvListar.TabIndex = 45;
            this.dgvListar.DoubleClick += new System.EventHandler(this.dgvListar_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gpContacto
            // 
            this.gpContacto.BackColor = System.Drawing.Color.White;
            this.gpContacto.Controls.Add(this.txtContacto);
            this.gpContacto.Controls.Add(this.lblContacto);
            this.gpContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpContacto.Location = new System.Drawing.Point(383, 132);
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
            this.txtContacto.TabIndex = 7;
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
            this.gpMarca.Controls.Add(this.txtMarca);
            this.gpMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpMarca.Location = new System.Drawing.Point(383, 81);
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
            this.lblMarca.Image = ((System.Drawing.Image)(resources.GetObject("lblMarca.Image")));
            this.lblMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMarca.Location = new System.Drawing.Point(8, 18);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(74, 13);
            this.lblMarca.TabIndex = 33;
            this.lblMarca.Text = "MARCA:     ";
            // 
            // txtMarca
            // 
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarca.Location = new System.Drawing.Point(159, 18);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(197, 13);
            this.txtMarca.TabIndex = 6;
            // 
            // gpTipo
            // 
            this.gpTipo.BackColor = System.Drawing.Color.White;
            this.gpTipo.Controls.Add(this.lblTipo);
            this.gpTipo.Controls.Add(this.txtTipo);
            this.gpTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTipo.Location = new System.Drawing.Point(383, 29);
            this.gpTipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpTipo.Name = "gpTipo";
            this.gpTipo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpTipo.Size = new System.Drawing.Size(363, 44);
            this.gpTipo.TabIndex = 49;
            this.gpTipo.TabStop = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Image = ((System.Drawing.Image)(resources.GetObject("lblTipo.Image")));
            this.lblTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTipo.Location = new System.Drawing.Point(7, 16);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(56, 16);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "TIPO:      ";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTipo
            // 
            this.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipo.Location = new System.Drawing.Point(159, 18);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(197, 13);
            this.txtTipo.TabIndex = 5;
            // 
            // gpSN
            // 
            this.gpSN.BackColor = System.Drawing.Color.White;
            this.gpSN.Controls.Add(this.txtSN);
            this.gpSN.Controls.Add(this.lblNS);
            this.gpSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSN.Location = new System.Drawing.Point(12, 184);
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
            this.txtSN.TabIndex = 3;
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
            this.gbDireccion.Location = new System.Drawing.Point(13, 81);
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
            this.txtDireccion.TabIndex = 1;
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.Color.White;
            this.gbCliente.Controls.Add(this.lblCliente);
            this.gbCliente.Controls.Add(this.txtCliente);
            this.gbCliente.Location = new System.Drawing.Point(12, 29);
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
            this.txtCliente.Location = new System.Drawing.Point(156, 20);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(197, 13);
            this.txtCliente.TabIndex = 0;
            // 
            // toolStrip1
            // 
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
            this.gpCantidad.Location = new System.Drawing.Point(383, 184);
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
            this.txtCantidad.TabIndex = 8;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Image = ((System.Drawing.Image)(resources.GetObject("lblCantidad.Image")));
            this.lblCantidad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCantidad.Location = new System.Drawing.Point(7, 16);
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
            this.gpDescripcion.Location = new System.Drawing.Point(12, 236);
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
            this.txtDescripcion.TabIndex = 4;
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
            this.gpEntregado.Location = new System.Drawing.Point(386, 236);
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
            this.txtEntregadoPor.TabIndex = 9;
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
            this.stsUsuario.Location = new System.Drawing.Point(0, 542);
            this.stsUsuario.Name = "stsUsuario";
            this.stsUsuario.Size = new System.Drawing.Size(761, 22);
            this.stsUsuario.TabIndex = 68;
            this.stsUsuario.Text = "statusStrip1";
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(546, 348);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(96, 33);
            this.btnReport.TabIndex = 12;
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
            this.btnCancel.Location = new System.Drawing.Point(424, 349);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 33);
            this.btnCancel.TabIndex = 11;
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
            this.btnAdd.Location = new System.Drawing.Point(312, 349);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 33);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "PROCESAR";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(413, 305);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(105, 20);
            this.txtID.TabIndex = 69;
            this.txtID.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(647, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 75;
            this.label9.Text = "BUSCAR POR ID:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(650, 361);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(99, 20);
            this.txtBuscar.TabIndex = 74;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // GestorEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(761, 564);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.stsUsuario);
            this.Controls.Add(this.gpEntregado);
            this.Controls.Add(this.gpDescripcion);
            this.Controls.Add(this.gpCantidad);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.gpFecha);
            this.Controls.Add(this.dgvListar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gpContacto);
            this.Controls.Add(this.gpMarca);
            this.Controls.Add(this.gpTipo);
            this.Controls.Add(this.gpSN);
            this.Controls.Add(this.gbDireccion);
            this.Controls.Add(this.gbCliente);
            this.Name = "GestorEntregas";
            this.Text = "ENTREGA  | QNS_SysInv_X";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Entregas_FormClosing);
            this.Load += new System.EventHandler(this.Entregas_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.gpFecha.ResumeLayout(false);
            this.gpFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.gpContacto.ResumeLayout(false);
            this.gpContacto.PerformLayout();
            this.gpMarca.ResumeLayout(false);
            this.gpMarca.PerformLayout();
            this.gpTipo.ResumeLayout(false);
            this.gpTipo.PerformLayout();
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
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.GroupBox gpTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipo;
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
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}