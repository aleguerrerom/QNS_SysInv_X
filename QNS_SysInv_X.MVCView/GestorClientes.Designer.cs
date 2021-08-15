namespace QNS_SysInv_X.MVCView
{
    partial class GestorClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorClientes));
            this.btnReport = new System.Windows.Forms.Button();
            this.gpCorreo = new System.Windows.Forms.GroupBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.activarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gpDireccion = new System.Windows.Forms.GroupBox();
            this.rtbDireccion = new System.Windows.Forms.RichTextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.gpTelefono = new System.Windows.Forms.GroupBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.gbCedula = new System.Windows.Forms.GroupBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.gpVendedor = new System.Windows.Forms.GroupBox();
            this.cmbVende = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.gpContacto = new System.Windows.Forms.GroupBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.gpCedula = new System.Windows.Forms.GroupBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.gpNombre = new System.Windows.Forms.GroupBox();
            this.txtNomb = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmbCed = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chckbxActivo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.gpCorreo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gpDireccion.SuspendLayout();
            this.gpTelefono.SuspendLayout();
            this.gbCedula.SuspendLayout();
            this.gpVendedor.SuspendLayout();
            this.gpContacto.SuspendLayout();
            this.gpCedula.SuspendLayout();
            this.gpNombre.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(25, 294);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(305, 72);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(595, 328);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(96, 33);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "REPORTES";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // gpCorreo
            // 
            this.gpCorreo.BackColor = System.Drawing.Color.White;
            this.gpCorreo.Controls.Add(this.lblCorreo);
            this.gpCorreo.Controls.Add(this.txtMail);
            this.gpCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCorreo.Location = new System.Drawing.Point(14, 132);
            this.gpCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpCorreo.Name = "gpCorreo";
            this.gpCorreo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpCorreo.Size = new System.Drawing.Size(363, 44);
            this.gpCorreo.TabIndex = 60;
            this.gpCorreo.TabStop = false;
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
            // txtMail
            // 
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Location = new System.Drawing.Point(159, 18);
            this.txtMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(197, 13);
            this.txtMail.TabIndex = 2;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            // 
            // dgvListar
            // 
            this.dgvListar.AllowUserToResizeColumns = false;
            this.dgvListar.AllowUserToResizeRows = false;
            this.dgvListar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvListar.Location = new System.Drawing.Point(12, 370);
            this.dgvListar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListar.MultiSelect = false;
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.ReadOnly = true;
            this.dgvListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListar.ShowEditingIcon = false;
            this.dgvListar.Size = new System.Drawing.Size(806, 172);
            this.dgvListar.TabIndex = 57;
            this.dgvListar.Click += new System.EventHandler(this.dgvListar_Click);
            this.dgvListar.DoubleClick += new System.EventHandler(this.dgvListar_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 26);
            // 
            // activarToolStripMenuItem
            // 
            this.activarToolStripMenuItem.Name = "activarToolStripMenuItem";
            this.activarToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.activarToolStripMenuItem.Text = "Activar";
            this.activarToolStripMenuItem.Click += new System.EventHandler(this.activarToolStripMenuItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(474, 328);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 33);
            this.btnCancel.TabIndex = 9;
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
            this.btnAdd.Location = new System.Drawing.Point(350, 329);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 33);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "AGREGAR";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gpDireccion
            // 
            this.gpDireccion.BackColor = System.Drawing.Color.White;
            this.gpDireccion.Controls.Add(this.rtbDireccion);
            this.gpDireccion.Controls.Add(this.lblDireccion);
            this.gpDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDireccion.Location = new System.Drawing.Point(454, 184);
            this.gpDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpDireccion.Name = "gpDireccion";
            this.gpDireccion.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpDireccion.Size = new System.Drawing.Size(363, 119);
            this.gpDireccion.TabIndex = 63;
            this.gpDireccion.TabStop = false;
            // 
            // rtbDireccion
            // 
            this.rtbDireccion.Location = new System.Drawing.Point(118, 14);
            this.rtbDireccion.Name = "rtbDireccion";
            this.rtbDireccion.Size = new System.Drawing.Size(222, 94);
            this.rtbDireccion.TabIndex = 7;
            this.rtbDireccion.Text = "";
            this.rtbDireccion.TextChanged += new System.EventHandler(this.rtbDireccion_TextChanged);
            this.rtbDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbDireccion_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Image = ((System.Drawing.Image)(resources.GetObject("lblDireccion.Image")));
            this.lblDireccion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDireccion.Location = new System.Drawing.Point(9, 58);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(92, 16);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "DIRECCION:      ";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpTelefono
            // 
            this.gpTelefono.BackColor = System.Drawing.Color.White;
            this.gpTelefono.Controls.Add(this.lblTelefono);
            this.gpTelefono.Controls.Add(this.txtTel);
            this.gpTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTelefono.Location = new System.Drawing.Point(455, 132);
            this.gpTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpTelefono.Name = "gpTelefono";
            this.gpTelefono.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpTelefono.Size = new System.Drawing.Size(363, 44);
            this.gpTelefono.TabIndex = 64;
            this.gpTelefono.TabStop = false;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Image = ((System.Drawing.Image)(resources.GetObject("lblTelefono.Image")));
            this.lblTelefono.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTelefono.Location = new System.Drawing.Point(8, 18);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(87, 16);
            this.lblTelefono.TabIndex = 33;
            this.lblTelefono.Text = "TELEFONO:      ";
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel.Location = new System.Drawing.Point(153, 16);
            this.txtTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(197, 13);
            this.txtTel.TabIndex = 6;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // gbCedula
            // 
            this.gbCedula.BackColor = System.Drawing.Color.White;
            this.gbCedula.Controls.Add(this.cmbTipo);
            this.gbCedula.Controls.Add(this.lblTipo);
            this.gbCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCedula.Location = new System.Drawing.Point(455, 29);
            this.gbCedula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCedula.Name = "gbCedula";
            this.gbCedula.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbCedula.Size = new System.Drawing.Size(363, 44);
            this.gbCedula.TabIndex = 61;
            this.gbCedula.TabStop = false;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.ItemHeight = 13;
            this.cmbTipo.Items.AddRange(new object[] {
            "Juridica",
            "Fisica"});
            this.cmbTipo.Location = new System.Drawing.Point(140, 16);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(210, 21);
            this.cmbTipo.TabIndex = 4;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
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
            this.lblTipo.Size = new System.Drawing.Size(104, 16);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "TIPO CEDULA:      ";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpVendedor
            // 
            this.gpVendedor.BackColor = System.Drawing.Color.White;
            this.gpVendedor.Controls.Add(this.cmbVende);
            this.gpVendedor.Controls.Add(this.lblVendedor);
            this.gpVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpVendedor.Location = new System.Drawing.Point(15, 184);
            this.gpVendedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpVendedor.Name = "gpVendedor";
            this.gpVendedor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpVendedor.Size = new System.Drawing.Size(363, 50);
            this.gpVendedor.TabIndex = 62;
            this.gpVendedor.TabStop = false;
            // 
            // cmbVende
            // 
            this.cmbVende.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVende.FormattingEnabled = true;
            this.cmbVende.ItemHeight = 13;
            this.cmbVende.Location = new System.Drawing.Point(162, 16);
            this.cmbVende.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbVende.Name = "cmbVende";
            this.cmbVende.Size = new System.Drawing.Size(194, 21);
            this.cmbVende.TabIndex = 3;
            this.cmbVende.SelectedValueChanged += new System.EventHandler(this.cmbVende_SelectedValueChanged);
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
            // gpContacto
            // 
            this.gpContacto.BackColor = System.Drawing.Color.White;
            this.gpContacto.Controls.Add(this.txtContacto);
            this.gpContacto.Controls.Add(this.lblContacto);
            this.gpContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpContacto.Location = new System.Drawing.Point(455, 81);
            this.gpContacto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpContacto.Name = "gpContacto";
            this.gpContacto.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpContacto.Size = new System.Drawing.Size(363, 44);
            this.gpContacto.TabIndex = 59;
            this.gpContacto.TabStop = false;
            // 
            // txtContacto
            // 
            this.txtContacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContacto.Location = new System.Drawing.Point(155, 17);
            this.txtContacto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(197, 13);
            this.txtContacto.TabIndex = 5;
            this.txtContacto.TextChanged += new System.EventHandler(this.txtContacto_TextChanged);
            this.txtContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContacto_KeyPress);
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
            this.lblContacto.Size = new System.Drawing.Size(92, 16);
            this.lblContacto.TabIndex = 3;
            this.lblContacto.Text = "CONTACTO:      ";
            this.lblContacto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpCedula
            // 
            this.gpCedula.BackColor = System.Drawing.Color.White;
            this.gpCedula.Controls.Add(this.lblCedula);
            this.gpCedula.Controls.Add(this.txtCedula);
            this.gpCedula.Location = new System.Drawing.Point(14, 29);
            this.gpCedula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpCedula.Name = "gpCedula";
            this.gpCedula.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpCedula.Size = new System.Drawing.Size(363, 44);
            this.gpCedula.TabIndex = 58;
            this.gpCedula.TabStop = false;
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
            this.txtCedula.Location = new System.Drawing.Point(156, 18);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(197, 13);
            this.txtCedula.TabIndex = 0;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // gpNombre
            // 
            this.gpNombre.BackColor = System.Drawing.Color.White;
            this.gpNombre.Controls.Add(this.txtNomb);
            this.gpNombre.Controls.Add(this.lblNombre);
            this.gpNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpNombre.Location = new System.Drawing.Point(12, 81);
            this.gpNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpNombre.Name = "gpNombre";
            this.gpNombre.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpNombre.Size = new System.Drawing.Size(363, 44);
            this.gpNombre.TabIndex = 60;
            this.gpNombre.TabStop = false;
            // 
            // txtNomb
            // 
            this.txtNomb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomb.Location = new System.Drawing.Point(159, 19);
            this.txtNomb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomb.Name = "txtNomb";
            this.txtNomb.Size = new System.Drawing.Size(198, 13);
            this.txtNomb.TabIndex = 1;
            this.txtNomb.TextChanged += new System.EventHandler(this.txtNomb_TextChanged);
            this.txtNomb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomb_KeyPress);
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
            this.lblNombre.Size = new System.Drawing.Size(146, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "NOMBRE DE CLIENTE:      ";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(830, 25);
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
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(830, 22);
            this.statusStrip1.TabIndex = 67;
            this.statusStrip1.Text = "stsUsuario";
            // 
            // stsUsuario
            // 
            this.stsUsuario.Name = "stsUsuario";
            this.stsUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // cmbCed
            // 
            this.cmbCed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCed.FormattingEnabled = true;
            this.cmbCed.ItemHeight = 13;
            this.cmbCed.Location = new System.Drawing.Point(421, 300);
            this.cmbCed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCed.Name = "cmbCed";
            this.cmbCed.Size = new System.Drawing.Size(27, 21);
            this.cmbCed.TabIndex = 4;
            this.cmbCed.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(694, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 16);
            this.label9.TabIndex = 73;
            this.label9.Text = "BUSCAR POR CÉDULA:";
            this.label9.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(697, 339);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(121, 20);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.chckbxActivo);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(12, 242);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(363, 44);
            this.groupBox6.TabIndex = 74;
            this.groupBox6.TabStop = false;
            // 
            // chckbxActivo
            // 
            this.chckbxActivo.AutoSize = true;
            this.chckbxActivo.Location = new System.Drawing.Point(247, 18);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 334);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 20);
            this.textBox1.TabIndex = 75;
            this.textBox1.Visible = false;
            // 
            // GestorClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(830, 582);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gpContacto);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbCed);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gpNombre);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.gpCorreo);
            this.Controls.Add(this.dgvListar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gpDireccion);
            this.Controls.Add(this.gpTelefono);
            this.Controls.Add(this.gbCedula);
            this.Controls.Add(this.gpVendedor);
            this.Controls.Add(this.gpCedula);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(846, 621);
            this.MinimumSize = new System.Drawing.Size(846, 621);
            this.Name = "GestorClientes";
            this.Text = "GESTOR CLIENTES  | QNS_SysInv_X";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestorClientes_FormClosing);
            this.Load += new System.EventHandler(this.GestorClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.gpCorreo.ResumeLayout(false);
            this.gpCorreo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gpDireccion.ResumeLayout(false);
            this.gpDireccion.PerformLayout();
            this.gpTelefono.ResumeLayout(false);
            this.gpTelefono.PerformLayout();
            this.gbCedula.ResumeLayout(false);
            this.gbCedula.PerformLayout();
            this.gpVendedor.ResumeLayout(false);
            this.gpVendedor.PerformLayout();
            this.gpContacto.ResumeLayout(false);
            this.gpContacto.PerformLayout();
            this.gpCedula.ResumeLayout(false);
            this.gpCedula.PerformLayout();
            this.gpNombre.ResumeLayout(false);
            this.gpNombre.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox gpCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gpDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.GroupBox gpTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.GroupBox gbCedula;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox gpVendedor;
        private System.Windows.Forms.ComboBox cmbVende;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.GroupBox gpContacto;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.GroupBox gpCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox rtbDireccion;
        private System.Windows.Forms.GroupBox gpNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.TextBox txtNomb;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsUsuario;
        private System.Windows.Forms.ComboBox cmbCed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chckbxActivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem activarToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}