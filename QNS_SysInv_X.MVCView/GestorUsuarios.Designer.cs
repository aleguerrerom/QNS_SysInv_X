namespace QNS_SysInv_X.MVCView.Resources
{
    public partial class GestorUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorUsuarios));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rolBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.rolBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsUsu = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chckbxActivo = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.deshabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(14, 241);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(293, 137);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // rolBindingSource3
            // 
            this.rolBindingSource3.DataMember = "Rol";
            // 
            // rolBindingSource2
            // 
            this.rolBindingSource2.DataMember = "Rol";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "Salir";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // dgvListar
            // 
            this.dgvListar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.ContextMenuStrip = this.contextMenuStrip2;
            this.dgvListar.Location = new System.Drawing.Point(14, 388);
            this.dgvListar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.ReadOnly = true;
            this.dgvListar.Size = new System.Drawing.Size(769, 211);
            this.dgvListar.TabIndex = 12;
            this.dgvListar.DoubleClick += new System.EventHandler(this.dgvListar_DoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshabilitarToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(153, 48);
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            // 
            // rolBindingSource1
            // 
            this.rolBindingSource1.DataMember = "Rol";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stsUsu});
            this.statusStrip1.Location = new System.Drawing.Point(0, 618);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(795, 22);
            this.statusStrip1.TabIndex = 43;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // stsUsu
            // 
            this.stsUsu.Name = "stsUsu";
            this.stsUsu.Size = new System.Drawing.Size(118, 17);
            this.stsUsu.Text = "toolStripStatusLabel2";
            // 
            // stsUsuario
            // 
            this.stsUsuario.Name = "stsUsuario";
            this.stsUsuario.Size = new System.Drawing.Size(118, 17);
            this.stsUsuario.Text = "toolStripStatusLabel1";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Location = new System.Drawing.Point(156, 20);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(197, 15);
            this.txtUsuario.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Image = ((System.Drawing.Image)(resources.GetObject("lblUsuario.Image")));
            this.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUsuario.Location = new System.Drawing.Point(8, 17);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(83, 16);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "USUARIO:      ";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Location = new System.Drawing.Point(27, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(363, 44);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // txtClave
            // 
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Location = new System.Drawing.Point(159, 18);
            this.txtClave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(174, 13);
            this.txtClave.TabIndex = 1;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Image = ((System.Drawing.Image)(resources.GetObject("lblClave.Image")));
            this.lblClave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblClave.Location = new System.Drawing.Point(7, 16);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(107, 16);
            this.lblClave.TabIndex = 3;
            this.lblClave.Text = "CONTRASEÑA:      ";
            this.lblClave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblClave);
            this.groupBox2.Controls.Add(this.txtClave);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 87);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(363, 44);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(332, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "    ";
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.Color.Transparent;
            this.lblRol.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Image = ((System.Drawing.Image)(resources.GetObject("lblRol.Image")));
            this.lblRol.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRol.Location = new System.Drawing.Point(7, 16);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(52, 16);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "ROL:      ";
            this.lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(159, 12);
            this.cmbRol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(194, 21);
            this.cmbRol.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.cmbRol);
            this.groupBox3.Controls.Add(this.lblRol);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 190);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(363, 44);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(159, 18);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 13);
            this.txtNombre.TabIndex = 4;
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
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.lblNombre);
            this.groupBox4.Controls.Add(this.txtNombre);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(398, 35);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(363, 44);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Location = new System.Drawing.Point(159, 18);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(197, 13);
            this.txtApellido.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Image = ((System.Drawing.Image)(resources.GetObject("lblApellido.Image")));
            this.lblApellido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblApellido.Location = new System.Drawing.Point(8, 18);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(91, 13);
            this.lblApellido.TabIndex = 33;
            this.lblApellido.Text = "APELLIDO:     ";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.lblApellido);
            this.groupBox5.Controls.Add(this.txtApellido);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(398, 87);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(363, 44);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
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
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.chckbxActivo);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(398, 138);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(363, 44);
            this.groupBox6.TabIndex = 38;
            this.groupBox6.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(323, 342);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 33);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "AGREGAR";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(447, 342);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 33);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmar.Location = new System.Drawing.Point(159, 18);
            this.txtConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(175, 13);
            this.txtConfirmar.TabIndex = 2;
            this.txtConfirmar.UseSystemPasswordChar = true;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("lblConfirmar.Image")));
            this.lblConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblConfirmar.Location = new System.Drawing.Point(7, 16);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(99, 16);
            this.lblConfirmar.TabIndex = 3;
            this.lblConfirmar.Text = "CONFIRMAR:      ";
            this.lblConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.White;
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.lblConfirmar);
            this.groupBox7.Controls.Add(this.txtConfirmar);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(27, 138);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(363, 44);
            this.groupBox7.TabIndex = 37;
            this.groupBox7.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(334, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "    ";
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
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
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Location = new System.Drawing.Point(157, 17);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(197, 13);
            this.txtCorreo.TabIndex = 7;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.White;
            this.groupBox8.Controls.Add(this.txtCorreo);
            this.groupBox8.Controls.Add(this.lblCorreo);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(400, 190);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Size = new System.Drawing.Size(363, 44);
            this.groupBox8.TabIndex = 39;
            this.groupBox8.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(569, 342);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(96, 33);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "REPORTES";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(795, 25);
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
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(684, 347);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(99, 22);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(671, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 16);
            this.label9.TabIndex = 69;
            this.label9.Text = "Buscar por Usuario";
            // 
            // deshabilitarToolStripMenuItem
            // 
            this.deshabilitarToolStripMenuItem.Name = "deshabilitarToolStripMenuItem";
            this.deshabilitarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deshabilitarToolStripMenuItem.Text = "Deshabilitar";
            this.deshabilitarToolStripMenuItem.Click += new System.EventHandler(this.deshabilitarToolStripMenuItem_Click);
            // 
            // GestorUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(795, 640);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.dgvListar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(811, 679);
            this.MinimumSize = new System.Drawing.Size(811, 679);
            this.Name = "GestorUsuarios";
            this.Text = "GESTOR DE USUARIOS  | QNS_SysInv_X";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestorUsuarios_FormClosing);
            this.Load += new System.EventHandler(this.GestorUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        
        private System.Windows.Forms.BindingSource rolBindingSource;
       
        private System.Windows.Forms.BindingSource rolBindingSource1;
        private System.Windows.Forms.BindingSource rolBindingSource2;
   
        private System.Windows.Forms.BindingSource rolBindingSource3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chckbxActivo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel stsUsu;
        private System.Windows.Forms.ToolStripMenuItem deshabilitarToolStripMenuItem;
    }
}