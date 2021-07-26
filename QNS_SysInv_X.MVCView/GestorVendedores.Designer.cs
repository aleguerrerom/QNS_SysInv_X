namespace QNS_SysInv_X.MVCView
{
    partial class GestorVendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorVendedores));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.opdBrowse = new System.Windows.Forms.OpenFileDialog();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.dtpFechaAnace = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gbApellido2 = new System.Windows.Forms.GroupBox();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.gbNombre = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gbCorreo = new System.Windows.Forms.GroupBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.gbApellido1 = new System.Windows.Forms.GroupBox();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.gbCedula = new System.Windows.Forms.GroupBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chckbxActivo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.gbGenero.SuspendLayout();
            this.gbFecha.SuspendLayout();
            this.gbApellido2.SuspendLayout();
            this.gbNombre.SuspendLayout();
            this.gbCorreo.SuspendLayout();
            this.gbApellido1.SuspendLayout();
            this.gbCedula.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(12, 235);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(293, 137);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(776, 25);
            this.toolStrip1.TabIndex = 55;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "SALIR";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // dgvListar
            // 
            this.dgvListar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvListar.Location = new System.Drawing.Point(22, 378);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.Size = new System.Drawing.Size(742, 204);
            this.dgvListar.TabIndex = 67;
            this.dgvListar.DoubleClick += new System.EventHandler(this.dgvListar_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gbGenero
            // 
            this.gbGenero.BackColor = System.Drawing.Color.White;
            this.gbGenero.Controls.Add(this.cmbGenero);
            this.gbGenero.Controls.Add(this.lblGenero);
            this.gbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenero.Location = new System.Drawing.Point(21, 132);
            this.gbGenero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbGenero.Size = new System.Drawing.Size(363, 44);
            this.gbGenero.TabIndex = 72;
            this.gbGenero.TabStop = false;
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "masculino",
            "femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(159, 16);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(194, 21);
            this.cmbGenero.TabIndex = 2;
            this.cmbGenero.SelectedIndexChanged += new System.EventHandler(this.cmbGenero_SelectedIndexChanged);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.Transparent;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Image = ((System.Drawing.Image)(resources.GetObject("lblGenero.Image")));
            this.lblGenero.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGenero.Location = new System.Drawing.Point(7, 16);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(75, 16);
            this.lblGenero.TabIndex = 3;
            this.lblGenero.Text = "GENERO:      ";
            this.lblGenero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Location = new System.Drawing.Point(156, 17);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(197, 13);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // gbFecha
            // 
            this.gbFecha.BackColor = System.Drawing.Color.White;
            this.gbFecha.Controls.Add(this.dtpFechaAnace);
            this.gbFecha.Controls.Add(this.lblFecha);
            this.gbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFecha.Location = new System.Drawing.Point(392, 132);
            this.gbFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFecha.Size = new System.Drawing.Size(363, 44);
            this.gbFecha.TabIndex = 75;
            this.gbFecha.TabStop = false;
            // 
            // dtpFechaAnace
            // 
            this.dtpFechaAnace.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAnace.Location = new System.Drawing.Point(173, 16);
            this.dtpFechaAnace.Name = "dtpFechaAnace";
            this.dtpFechaAnace.Size = new System.Drawing.Size(183, 20);
            this.dtpFechaAnace.TabIndex = 6;
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
            this.lblFecha.Size = new System.Drawing.Size(160, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "FECHA DE NACIMIENTO:      ";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbApellido2
            // 
            this.gbApellido2.BackColor = System.Drawing.Color.White;
            this.gbApellido2.Controls.Add(this.lblApellido2);
            this.gbApellido2.Controls.Add(this.txtApellido2);
            this.gbApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbApellido2.Location = new System.Drawing.Point(392, 81);
            this.gbApellido2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbApellido2.Name = "gbApellido2";
            this.gbApellido2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbApellido2.Size = new System.Drawing.Size(363, 44);
            this.gbApellido2.TabIndex = 76;
            this.gbApellido2.TabStop = false;
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido2.Image = ((System.Drawing.Image)(resources.GetObject("lblApellido2.Image")));
            this.lblApellido2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblApellido2.Location = new System.Drawing.Point(8, 18);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(141, 16);
            this.lblApellido2.TabIndex = 33;
            this.lblApellido2.Text = "SEGUNDO APELLIDO:     ";
            // 
            // txtApellido2
            // 
            this.txtApellido2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido2.Location = new System.Drawing.Point(173, 18);
            this.txtApellido2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(183, 13);
            this.txtApellido2.TabIndex = 5;
            this.txtApellido2.TextChanged += new System.EventHandler(this.txtApellido2_TextChanged);
            // 
            // gbNombre
            // 
            this.gbNombre.BackColor = System.Drawing.Color.White;
            this.gbNombre.Controls.Add(this.lblNombre);
            this.gbNombre.Controls.Add(this.txtNombre);
            this.gbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNombre.Location = new System.Drawing.Point(392, 29);
            this.gbNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbNombre.Name = "gbNombre";
            this.gbNombre.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbNombre.Size = new System.Drawing.Size(363, 44);
            this.gbNombre.TabIndex = 1;
            this.gbNombre.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Image = ((System.Drawing.Image)(resources.GetObject("lblNombre.Image")));
            this.lblNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNombre.Location = new System.Drawing.Point(7, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "NOMBRE:      ";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(159, 18);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 13);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // gbCorreo
            // 
            this.gbCorreo.BackColor = System.Drawing.Color.White;
            this.gbCorreo.Controls.Add(this.lblCorreo);
            this.gbCorreo.Controls.Add(this.txtCorreo);
            this.gbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCorreo.Location = new System.Drawing.Point(21, 184);
            this.gbCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCorreo.Name = "gbCorreo";
            this.gbCorreo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCorreo.Size = new System.Drawing.Size(363, 44);
            this.gbCorreo.TabIndex = 74;
            this.gbCorreo.TabStop = false;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Image = ((System.Drawing.Image)(resources.GetObject("lblCorreo.Image")));
            this.lblCorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCorreo.Location = new System.Drawing.Point(7, 16);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(76, 16);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "CORREO:      ";
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbApellido1
            // 
            this.gbApellido1.BackColor = System.Drawing.Color.White;
            this.gbApellido1.Controls.Add(this.lblApellido1);
            this.gbApellido1.Controls.Add(this.txtApellido);
            this.gbApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbApellido1.Location = new System.Drawing.Point(22, 81);
            this.gbApellido1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbApellido1.Name = "gbApellido1";
            this.gbApellido1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbApellido1.Size = new System.Drawing.Size(363, 44);
            this.gbApellido1.TabIndex = 71;
            this.gbApellido1.TabStop = false;
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.Image = ((System.Drawing.Image)(resources.GetObject("lblApellido1.Image")));
            this.lblApellido1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblApellido1.Location = new System.Drawing.Point(7, 16);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(131, 16);
            this.lblApellido1.TabIndex = 3;
            this.lblApellido1.Text = "PRIMER APELLIDO:      ";
            this.lblApellido1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Location = new System.Drawing.Point(159, 18);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(197, 13);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // gbCedula
            // 
            this.gbCedula.BackColor = System.Drawing.Color.White;
            this.gbCedula.Controls.Add(this.lblCedula);
            this.gbCedula.Controls.Add(this.txtCedula);
            this.gbCedula.Location = new System.Drawing.Point(21, 29);
            this.gbCedula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCedula.Name = "gbCedula";
            this.gbCedula.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCedula.Size = new System.Drawing.Size(363, 44);
            this.gbCedula.TabIndex = 70;
            this.gbCedula.TabStop = false;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.BackColor = System.Drawing.Color.Transparent;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Image = ((System.Drawing.Image)(resources.GetObject("lblCedula.Image")));
            this.lblCedula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCedula.Location = new System.Drawing.Point(8, 17);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(74, 16);
            this.lblCedula.TabIndex = 3;
            this.lblCedula.Text = "CEDULA:      ";
            this.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCedula
            // 
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(156, 20);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(197, 13);
            this.txtCedula.TabIndex = 0;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(637, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 16);
            this.label9.TabIndex = 81;
            this.label9.Text = "BUSCAR POR CEDULA:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(649, 341);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(99, 20);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(535, 328);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(96, 33);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "REPORTE";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(423, 328);
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
            this.btnAdd.Location = new System.Drawing.Point(311, 328);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 33);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "AGREGAR";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 585);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(776, 22);
            this.statusStrip1.TabIndex = 82;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.chckbxActivo);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(392, 184);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(363, 44);
            this.groupBox6.TabIndex = 83;
            this.groupBox6.TabStop = false;
            // 
            // chckbxActivo
            // 
            this.chckbxActivo.AutoSize = true;
            this.chckbxActivo.Location = new System.Drawing.Point(204, 16);
            this.chckbxActivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chckbxActivo.Name = "chckbxActivo";
            this.chckbxActivo.Size = new System.Drawing.Size(15, 14);
            this.chckbxActivo.TabIndex = 6;
            this.chckbxActivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(7, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "ACTIVO:      ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GestorVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(776, 607);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbFecha);
            this.Controls.Add(this.gbApellido2);
            this.Controls.Add(this.gbNombre);
            this.Controls.Add(this.gbCorreo);
            this.Controls.Add(this.gbApellido1);
            this.Controls.Add(this.gbCedula);
            this.Controls.Add(this.dgvListar);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(792, 646);
            this.MinimumSize = new System.Drawing.Size(792, 646);
            this.Name = "GestorVendedores";
            this.Text = "GESTOR VENDEDORES  | QNS_SysInv_X";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestorVendedores_FormClosing);
            this.Load += new System.EventHandler(this.GestorRespaldos_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.gbFecha.ResumeLayout(false);
            this.gbFecha.PerformLayout();
            this.gbApellido2.ResumeLayout(false);
            this.gbApellido2.PerformLayout();
            this.gbNombre.ResumeLayout(false);
            this.gbNombre.PerformLayout();
            this.gbCorreo.ResumeLayout(false);
            this.gbCorreo.PerformLayout();
            this.gbApellido1.ResumeLayout(false);
            this.gbApellido1.PerformLayout();
            this.gbCedula.ResumeLayout(false);
            this.gbCedula.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.OpenFileDialog opdBrowse;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox gbApellido2;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.GroupBox gbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gbCorreo;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.GroupBox gbApellido1;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox gbCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.DateTimePicker dtpFechaAnace;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chckbxActivo;
        private System.Windows.Forms.Label label6;
    }
}