namespace QNS_SysInv_X.MVCView
{
    partial class GestorInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorInventario));
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnReport = new System.Windows.Forms.Button();
            this.gbSN = new System.Windows.Forms.GroupBox();
            this.lblSN = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.cmsInventario = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gpFecha = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.gbModelo = new System.Windows.Forms.GroupBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.gbMarca = new System.Windows.Forms.GroupBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.gbNombre = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreActivo = new System.Windows.Forms.TextBox();
            this.idl = new System.Windows.Forms.Label();
            this.stsUsu = new System.Windows.Forms.StatusStrip();
            this.stsUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.stsUsua = new System.Windows.Forms.ToolStripStatusLabel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.gbSN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.gpFecha.SuspendLayout();
            this.gbEstado.SuspendLayout();
            this.gbModelo.SuspendLayout();
            this.gbMarca.SuspendLayout();
            this.gbTipo.SuspendLayout();
            this.gbNombre.SuspendLayout();
            this.stsUsu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(24, 242);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(293, 119);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "SALIR";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(558, 329);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(96, 33);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "REPORTES";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // gbSN
            // 
            this.gbSN.BackColor = System.Drawing.Color.White;
            this.gbSN.Controls.Add(this.lblSN);
            this.gbSN.Controls.Add(this.txtSerialNumber);
            this.gbSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSN.Location = new System.Drawing.Point(12, 132);
            this.gbSN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSN.Name = "gbSN";
            this.gbSN.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSN.Size = new System.Drawing.Size(363, 44);
            this.gbSN.TabIndex = 48;
            this.gbSN.TabStop = false;
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.BackColor = System.Drawing.Color.Transparent;
            this.lblSN.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSN.Image = ((System.Drawing.Image)(resources.GetObject("lblSN.Image")));
            this.lblSN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSN.Location = new System.Drawing.Point(7, 16);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(122, 16);
            this.lblSN.TabIndex = 3;
            this.lblSN.Text = "SERIAL NUMBER:      ";
            this.lblSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSerialNumber.Location = new System.Drawing.Point(159, 18);
            this.txtSerialNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(197, 13);
            this.txtSerialNumber.TabIndex = 2;
            // 
            // dgvListar
            // 
            this.dgvListar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.ContextMenuStrip = this.cmsInventario;
            this.dgvListar.Location = new System.Drawing.Point(13, 369);
            this.dgvListar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.ReadOnly = true;
            this.dgvListar.Size = new System.Drawing.Size(765, 195);
            this.dgvListar.TabIndex = 45;
            this.dgvListar.DoubleClick += new System.EventHandler(this.dgvListar_DoubleClick);
            // 
            // cmsInventario
            // 
            this.cmsInventario.Name = "cmsInventario";
            this.cmsInventario.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(437, 328);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 33);
            this.btnCancel.TabIndex = 8;
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
            this.btnAdd.Location = new System.Drawing.Point(325, 328);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 33);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "AGREGAR";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gpFecha
            // 
            this.gpFecha.BackColor = System.Drawing.Color.White;
            this.gpFecha.Controls.Add(this.dtpFecha);
            this.gpFecha.Controls.Add(this.lblFecha);
            this.gpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpFecha.Location = new System.Drawing.Point(383, 132);
            this.gpFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpFecha.Name = "gpFecha";
            this.gpFecha.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpFecha.Size = new System.Drawing.Size(363, 44);
            this.gpFecha.TabIndex = 51;
            this.gpFecha.TabStop = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(198, 17);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 6;
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
            this.lblFecha.Size = new System.Drawing.Size(173, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "FECHA DE MODIFICACION:      ";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbEstado
            // 
            this.gbEstado.BackColor = System.Drawing.Color.White;
            this.gbEstado.Controls.Add(this.cmbEstado);
            this.gbEstado.Controls.Add(this.lblEstado);
            this.gbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstado.Location = new System.Drawing.Point(383, 81);
            this.gbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbEstado.Size = new System.Drawing.Size(363, 44);
            this.gbEstado.TabIndex = 52;
            this.gbEstado.TabStop = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Bodega",
            "Prestado",
            "Produccion"});
            this.cmbEstado.Location = new System.Drawing.Point(198, 14);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(147, 21);
            this.cmbEstado.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Image = ((System.Drawing.Image)(resources.GetObject("lblEstado.Image")));
            this.lblEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEstado.Location = new System.Drawing.Point(8, 18);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(72, 16);
            this.lblEstado.TabIndex = 33;
            this.lblEstado.Text = "ESTADO:     ";
            // 
            // gbModelo
            // 
            this.gbModelo.BackColor = System.Drawing.Color.White;
            this.gbModelo.Controls.Add(this.lblModelo);
            this.gbModelo.Controls.Add(this.txtModelo);
            this.gbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModelo.Location = new System.Drawing.Point(383, 29);
            this.gbModelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbModelo.Name = "gbModelo";
            this.gbModelo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbModelo.Size = new System.Drawing.Size(363, 44);
            this.gbModelo.TabIndex = 49;
            this.gbModelo.TabStop = false;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Image = ((System.Drawing.Image)(resources.GetObject("lblModelo.Image")));
            this.lblModelo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblModelo.Location = new System.Drawing.Point(7, 16);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(79, 16);
            this.lblModelo.TabIndex = 3;
            this.lblModelo.Text = "MODELO:      ";
            this.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModelo
            // 
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModelo.Location = new System.Drawing.Point(159, 18);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(197, 13);
            this.txtModelo.TabIndex = 4;
            // 
            // gbMarca
            // 
            this.gbMarca.BackColor = System.Drawing.Color.White;
            this.gbMarca.Controls.Add(this.cmbBrand);
            this.gbMarca.Controls.Add(this.lblMarca);
            this.gbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMarca.Location = new System.Drawing.Point(13, 184);
            this.gbMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMarca.Name = "gbMarca";
            this.gbMarca.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMarca.Size = new System.Drawing.Size(363, 50);
            this.gbMarca.TabIndex = 50;
            this.gbMarca.TabStop = false;
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Items.AddRange(new object[] {
            "Cisco",
            "Aruba",
            "Fortinet",
            "Sophos",
            "Dell",
            "HPe",
            "Palo Alto",
            "Unify"});
            this.cmbBrand.Location = new System.Drawing.Point(162, 16);
            this.cmbBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(194, 21);
            this.cmbBrand.TabIndex = 3;
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
            // gbTipo
            // 
            this.gbTipo.BackColor = System.Drawing.Color.White;
            this.gbTipo.Controls.Add(this.lblTipo);
            this.gbTipo.Controls.Add(this.txtTipo);
            this.gbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipo.Location = new System.Drawing.Point(13, 81);
            this.gbTipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTipo.Size = new System.Drawing.Size(363, 44);
            this.gbTipo.TabIndex = 47;
            this.gbTipo.TabStop = false;
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
            this.txtTipo.TabIndex = 1;
            // 
            // gbNombre
            // 
            this.gbNombre.BackColor = System.Drawing.Color.White;
            this.gbNombre.Controls.Add(this.lblNombre);
            this.gbNombre.Controls.Add(this.txtNombreActivo);
            this.gbNombre.Location = new System.Drawing.Point(12, 29);
            this.gbNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbNombre.Name = "gbNombre";
            this.gbNombre.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbNombre.Size = new System.Drawing.Size(363, 44);
            this.gbNombre.TabIndex = 46;
            this.gbNombre.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Image = ((System.Drawing.Image)(resources.GetObject("lblNombre.Image")));
            this.lblNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNombre.Location = new System.Drawing.Point(8, 17);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(147, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "NOMBRE  DE ACTIVO:      ";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombreActivo
            // 
            this.txtNombreActivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreActivo.Location = new System.Drawing.Point(156, 20);
            this.txtNombreActivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreActivo.Name = "txtNombreActivo";
            this.txtNombreActivo.Size = new System.Drawing.Size(197, 13);
            this.txtNombreActivo.TabIndex = 0;
            // 
            // idl
            // 
            this.idl.AutoSize = true;
            this.idl.Location = new System.Drawing.Point(431, 231);
            this.idl.Name = "idl";
            this.idl.Size = new System.Drawing.Size(0, 13);
            this.idl.TabIndex = 55;
            this.idl.Visible = false;
            // 
            // stsUsu
            // 
            this.stsUsu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stsUsu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsUsuario,
            this.stsUsua});
            this.stsUsu.Location = new System.Drawing.Point(0, 567);
            this.stsUsu.Name = "stsUsu";
            this.stsUsu.Size = new System.Drawing.Size(796, 22);
            this.stsUsu.TabIndex = 56;
            this.stsUsu.Text = "statusStrip1";
            // 
            // stsUsuario
            // 
            this.stsUsuario.Name = "stsUsuario";
            this.stsUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(796, 25);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(666, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "Buscar por ID:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(669, 341);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(99, 20);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(542, 213);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 72;
            this.txtID.Visible = false;
            // 
            // stsUsua
            // 
            this.stsUsua.Name = "stsUsua";
            this.stsUsua.Size = new System.Drawing.Size(118, 17);
            this.stsUsua.Text = "toolStripStatusLabel1";
            // 
            // GestorInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(796, 589);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.stsUsu);
            this.Controls.Add(this.idl);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.gbSN);
            this.Controls.Add(this.dgvListar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gpFecha);
            this.Controls.Add(this.gbEstado);
            this.Controls.Add(this.gbModelo);
            this.Controls.Add(this.gbMarca);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.gbNombre);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(812, 628);
            this.MinimumSize = new System.Drawing.Size(812, 628);
            this.Name = "GestorInventario";
            this.Text = "GESTOR INVENTARIOS  | QNS_SysInv_X";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestorInventario_FormClosing);
            this.Load += new System.EventHandler(this.GestorInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.gbSN.ResumeLayout(false);
            this.gbSN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.gpFecha.ResumeLayout(false);
            this.gpFecha.PerformLayout();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.gbModelo.ResumeLayout(false);
            this.gbModelo.PerformLayout();
            this.gbMarca.ResumeLayout(false);
            this.gbMarca.PerformLayout();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.gbNombre.ResumeLayout(false);
            this.gbNombre.PerformLayout();
            this.stsUsu.ResumeLayout(false);
            this.stsUsu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox gbSN;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox gbModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.GroupBox gbMarca;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.GroupBox gbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreActivo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ContextMenuStrip cmsInventario;
        private System.Windows.Forms.Label idl;
        private System.Windows.Forms.StatusStrip stsUsu;
        private System.Windows.Forms.ToolStripStatusLabel stsUsuario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ToolStripStatusLabel stsUsua;
    }
}