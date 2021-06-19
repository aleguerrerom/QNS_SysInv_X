namespace QNS_SysInv_X.MVCView
{
    partial class GestorRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorRoles));
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkBitacora = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chckRoles = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkEntrega = new System.Windows.Forms.CheckBox();
            this.chkPrestamo = new System.Windows.Forms.CheckBox();
            this.chckUsuarios = new System.Windows.Forms.CheckBox();
            this.chkInventario = new System.Windows.Forms.CheckBox();
            this.cmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chkClientesx = new System.Windows.Forms.CheckBox();
            this.chkVendedores = new System.Windows.Forms.CheckBox();
            this.chkOportunidades = new System.Windows.Forms.CheckBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(21, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(293, 137);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // dgvListar
            // 
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.Location = new System.Drawing.Point(8, 343);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.ReadOnly = true;
            this.dgvListar.Size = new System.Drawing.Size(629, 120);
            this.dgvListar.TabIndex = 49;
            this.dgvListar.DoubleClick += new System.EventHandler(this.dgvListar_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRol);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 36);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE DE ROL:      ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRol
            // 
            this.txtRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRol.Location = new System.Drawing.Point(134, 16);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(153, 13);
            this.txtRol.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(543, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 27);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "CANCELAR:";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(432, 310);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 27);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "ACEPTAR";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(321, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 292);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(168, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "ACTIVO/INACTIVO:      ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(6, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "ENTREGA:      ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "PRESTAMO:      ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "GESTOR DE USUARIOS:      ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "INVENTARIO:      ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "OPCIONES:      ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(134, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 13);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkOportunidades);
            this.groupBox3.Controls.Add(this.chkVendedores);
            this.groupBox3.Controls.Add(this.chkClientesx);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.chkBitacora);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.chckRoles);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.chkEntrega);
            this.groupBox3.Controls.Add(this.chkPrestamo);
            this.groupBox3.Controls.Add(this.chckUsuarios);
            this.groupBox3.Controls.Add(this.chkInventario);
            this.groupBox3.Location = new System.Drawing.Point(4, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 254);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // chkBitacora
            // 
            this.chkBitacora.AutoSize = true;
            this.chkBitacora.Location = new System.Drawing.Point(205, 148);
            this.chkBitacora.Name = "chkBitacora";
            this.chkBitacora.Size = new System.Drawing.Size(15, 14);
            this.chkBitacora.TabIndex = 13;
            this.chkBitacora.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(1, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "BITACORA:      ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chckRoles
            // 
            this.chckRoles.AutoSize = true;
            this.chckRoles.Location = new System.Drawing.Point(204, 123);
            this.chckRoles.Name = "chckRoles";
            this.chckRoles.Size = new System.Drawing.Size(15, 14);
            this.chckRoles.TabIndex = 11;
            this.chckRoles.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(1, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "GESTOR DE ROLES:      ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkEntrega
            // 
            this.chkEntrega.AutoSize = true;
            this.chkEntrega.Location = new System.Drawing.Point(204, 96);
            this.chkEntrega.Name = "chkEntrega";
            this.chkEntrega.Size = new System.Drawing.Size(15, 14);
            this.chkEntrega.TabIndex = 3;
            this.chkEntrega.UseVisualStyleBackColor = true;
            // 
            // chkPrestamo
            // 
            this.chkPrestamo.AutoSize = true;
            this.chkPrestamo.Location = new System.Drawing.Point(204, 67);
            this.chkPrestamo.Name = "chkPrestamo";
            this.chkPrestamo.Size = new System.Drawing.Size(15, 14);
            this.chkPrestamo.TabIndex = 2;
            this.chkPrestamo.UseVisualStyleBackColor = true;
            // 
            // chckUsuarios
            // 
            this.chckUsuarios.AutoSize = true;
            this.chckUsuarios.Location = new System.Drawing.Point(204, 40);
            this.chckUsuarios.Name = "chckUsuarios";
            this.chckUsuarios.Size = new System.Drawing.Size(15, 14);
            this.chckUsuarios.TabIndex = 1;
            this.chckUsuarios.UseVisualStyleBackColor = true;
            // 
            // chkInventario
            // 
            this.chkInventario.AutoSize = true;
            this.chkInventario.Location = new System.Drawing.Point(204, 11);
            this.chkInventario.Name = "chkInventario";
            this.chkInventario.Size = new System.Drawing.Size(15, 14);
            this.chkInventario.TabIndex = 0;
            this.chkInventario.UseVisualStyleBackColor = true;
            // 
            // cmsOpciones
            // 
            this.cmsOpciones.Name = "cmsOpciones";
            this.cmsOpciones.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 48);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(649, 25);
            this.toolStrip1.TabIndex = 50;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "Salir";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(1, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "GESTOR OPORTUNIDADES:      ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(2, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "GESTOR VENDEDORES:      ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(1, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "GESTOR CLIENTES:      ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkClientesx
            // 
            this.chkClientesx.AutoSize = true;
            this.chkClientesx.Location = new System.Drawing.Point(204, 226);
            this.chkClientesx.Name = "chkClientesx";
            this.chkClientesx.Size = new System.Drawing.Size(15, 14);
            this.chkClientesx.TabIndex = 17;
            this.chkClientesx.UseVisualStyleBackColor = true;
            // 
            // chkVendedores
            // 
            this.chkVendedores.AutoSize = true;
            this.chkVendedores.Location = new System.Drawing.Point(204, 201);
            this.chkVendedores.Name = "chkVendedores";
            this.chkVendedores.Size = new System.Drawing.Size(15, 14);
            this.chkVendedores.TabIndex = 18;
            this.chkVendedores.UseVisualStyleBackColor = true;
            // 
            // chkOportunidades
            // 
            this.chkOportunidades.AutoSize = true;
            this.chkOportunidades.Location = new System.Drawing.Point(204, 177);
            this.chkOportunidades.Name = "chkOportunidades";
            this.chkOportunidades.Size = new System.Drawing.Size(15, 14);
            this.chkOportunidades.TabIndex = 19;
            this.chkOportunidades.UseVisualStyleBackColor = true;
            // 
            // GestorRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 477);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.dgvListar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestorRoles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.GestorRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkEntrega;
        private System.Windows.Forms.CheckBox chkPrestamo;
        private System.Windows.Forms.CheckBox chckUsuarios;
        private System.Windows.Forms.CheckBox chkInventario;
        private System.Windows.Forms.CheckBox chckRoles;
        private System.Windows.Forms.ContextMenuStrip cmsOpciones;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkBitacora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.CheckBox chkOportunidades;
        private System.Windows.Forms.CheckBox chkVendedores;
        private System.Windows.Forms.CheckBox chkClientesx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}