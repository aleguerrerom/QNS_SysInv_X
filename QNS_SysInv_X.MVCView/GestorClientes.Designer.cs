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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorClientes));
            this.btnReport = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDireccion = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.cmbVendedor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(42, 226);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(293, 119);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(639, 312);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(96, 33);
            this.btnReport.TabIndex = 66;
            this.btnReport.Text = "REPORTES";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.White;
            this.groupBox7.Controls.Add(this.txtCorreo);
            this.groupBox7.Controls.Add(this.txtSerialNumber);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(30, 116);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(363, 44);
            this.groupBox7.TabIndex = 60;
            this.groupBox7.TabStop = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.BackColor = System.Drawing.Color.Transparent;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Image = ((System.Drawing.Image)(resources.GetObject("txtCorreo.Image")));
            this.txtCorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtCorreo.Location = new System.Drawing.Point(7, 16);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(76, 16);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.Text = "CORREO:      ";
            this.txtCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.dgvListar.Location = new System.Drawing.Point(30, 358);
            this.dgvListar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.ReadOnly = true;
            this.dgvListar.Size = new System.Drawing.Size(734, 307);
            this.dgvListar.TabIndex = 57;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(502, 312);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 33);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(374, 312);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 33);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "AGREGAR";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.dtpFecha);
            this.groupBox6.Controls.Add(this.txtDireccion);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(401, 116);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(363, 44);
            this.groupBox6.TabIndex = 63;
            this.groupBox6.TabStop = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(198, 17);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.AutoSize = true;
            this.txtDireccion.BackColor = System.Drawing.Color.Transparent;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Image = ((System.Drawing.Image)(resources.GetObject("txtDireccion.Image")));
            this.txtDireccion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtDireccion.Location = new System.Drawing.Point(7, 16);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(92, 16);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.Text = "DIRECCION:      ";
            this.txtDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.txtTelefono);
            this.groupBox5.Controls.Add(this.txtEstado);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(401, 65);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(363, 44);
            this.groupBox5.TabIndex = 64;
            this.groupBox5.TabStop = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AutoSize = true;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Image = ((System.Drawing.Image)(resources.GetObject("txtTelefono.Image")));
            this.txtTelefono.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtTelefono.Location = new System.Drawing.Point(8, 18);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(84, 16);
            this.txtTelefono.TabIndex = 33;
            this.txtTelefono.Text = "TELEFONO:     ";
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Location = new System.Drawing.Point(159, 18);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(197, 13);
            this.txtEstado.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.cmbModelo);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(401, 13);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(363, 44);
            this.groupBox4.TabIndex = 61;
            this.groupBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(7, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "TIPO CEDULA:      ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.cmbRol);
            this.groupBox3.Controls.Add(this.cmbVendedor);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(31, 168);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(363, 50);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Cisco"});
            this.cmbRol.Location = new System.Drawing.Point(162, 16);
            this.cmbRol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(194, 21);
            this.cmbRol.TabIndex = 3;
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.AutoSize = true;
            this.cmbVendedor.BackColor = System.Drawing.Color.Transparent;
            this.cmbVendedor.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVendedor.Image = ((System.Drawing.Image)(resources.GetObject("cmbVendedor.Image")));
            this.cmbVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmbVendedor.Location = new System.Drawing.Point(7, 16);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(93, 16);
            this.cmbVendedor.TabIndex = 3;
            this.cmbVendedor.Text = "VENDEDOR:      ";
            this.cmbVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 65);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(363, 44);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "CONTACTO:      ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Location = new System.Drawing.Point(30, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(363, 44);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(8, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "CEDULA:      ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCedula
            // 
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Location = new System.Drawing.Point(156, 20);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(197, 13);
            this.txtCedula.TabIndex = 0;
            // 
            // cmbModelo
            // 
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(198, 16);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(121, 21);
            this.cmbModelo.TabIndex = 34;
            // 
            // GestorClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 691);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(pictureBox1);
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
            this.Name = "GestorClientes";
            this.Text = "GestorClientes";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label txtDireccion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label txtTelefono;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label cmbVendedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.ComboBox cmbModelo;
    }
}