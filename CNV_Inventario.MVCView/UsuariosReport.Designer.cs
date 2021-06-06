namespace CNV_Inventario.MVCView
{
    partial class UsuariosReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSUsuarios = new CNV_Inventario.MVCView.DS_QNS();
            this.usuariosTableAdapter1 = new CNV_Inventario.MVCView.DS_QNSTableAdapters.UsuariosTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.ErrorImage = global::CNV_Inventario.MVCView.Properties.Resources.logo_convergenets_degradado2;
            pictureBox1.Image = global::CNV_Inventario.MVCView.Properties.Resources.logo_convergenets_degradado;
            pictureBox1.Location = new System.Drawing.Point(278, 190);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(293, 119);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(960, 566);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.UsuariosReport_Load);
            // 
            // DSUsuarios
            // 
            this.DSUsuarios.DataSetName = "DSUsuarios";
            this.DSUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Usuarios";
            this.bindingSource1.DataSource = this.DSUsuarios;
            // 
            // UsuariosReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 566);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "UsuariosReport";
            this.Text = "UsuariosReport";
            this.Load += new System.EventHandler(this.UsuariosReport_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_QNS DSUsuarios;
        private DS_QNSTableAdapters.UsuariosTableAdapter usuariosTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}