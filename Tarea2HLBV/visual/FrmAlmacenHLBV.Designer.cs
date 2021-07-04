
namespace Tarea2HLBV
{
    partial class FrmAlmacenHLBV
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAccion = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.btnMasCaro = new System.Windows.Forms.Button();
            this.btnTiempoCaducidad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaE = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTiempoCaducidad = new System.Windows.Forms.TextBox();
            this.lblCambiar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaV = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Acción a realizar";
            // 
            // cmbAccion
            // 
            this.cmbAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccion.FormattingEnabled = true;
            this.cmbAccion.Items.AddRange(new object[] {
            "Compra",
            "Venta"});
            this.cmbAccion.Location = new System.Drawing.Point(149, 28);
            this.cmbAccion.Name = "cmbAccion";
            this.cmbAccion.Size = new System.Drawing.Size(119, 21);
            this.cmbAccion.TabIndex = 2;
            this.cmbAccion.SelectedIndexChanged += new System.EventHandler(this.cmbAccion_SelectedIndexChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(148, 141);
            this.txtCantidad.MaxLength = 2;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(118, 20);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(27, 332);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 33);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(351, 41);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.ReadOnly = true;
            this.txtContenido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContenido.Size = new System.Drawing.Size(300, 208);
            this.txtContenido.TabIndex = 5;
            // 
            // btnMasCaro
            // 
            this.btnMasCaro.Location = new System.Drawing.Point(180, 332);
            this.btnMasCaro.Name = "btnMasCaro";
            this.btnMasCaro.Size = new System.Drawing.Size(109, 33);
            this.btnMasCaro.TabIndex = 6;
            this.btnMasCaro.Text = "Producto más caro";
            this.btnMasCaro.UseVisualStyleBackColor = true;
            this.btnMasCaro.Click += new System.EventHandler(this.btnMasCaro_Click);
            // 
            // btnTiempoCaducidad
            // 
            this.btnTiempoCaducidad.Location = new System.Drawing.Point(92, 390);
            this.btnTiempoCaducidad.Name = "btnTiempoCaducidad";
            this.btnTiempoCaducidad.Size = new System.Drawing.Size(147, 33);
            this.btnTiempoCaducidad.TabIndex = 7;
            this.btnTiempoCaducidad.Text = "Tiempo de Caducidad";
            this.btnTiempoCaducidad.UseVisualStyleBackColor = true;
            this.btnTiempoCaducidad.Click += new System.EventHandler(this.btnTiempoCaducidad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(148, 67);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(118, 20);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre de Producto";
            // 
            // txtPrecioU
            // 
            this.txtPrecioU.Location = new System.Drawing.Point(148, 103);
            this.txtPrecioU.MaxLength = 10;
            this.txtPrecioU.Name = "txtPrecioU";
            this.txtPrecioU.Size = new System.Drawing.Size(118, 20);
            this.txtPrecioU.TabIndex = 11;
            this.txtPrecioU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioU_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha de emisión";
            // 
            // dtpFechaE
            // 
            this.dtpFechaE.Location = new System.Drawing.Point(148, 216);
            this.dtpFechaE.Name = "dtpFechaE";
            this.dtpFechaE.Size = new System.Drawing.Size(120, 20);
            this.dtpFechaE.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(148, 178);
            this.txtCodigo.MaxLength = 8;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(118, 20);
            this.txtCodigo.TabIndex = 15;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtTiempoCaducidad
            // 
            this.txtTiempoCaducidad.Location = new System.Drawing.Point(351, 295);
            this.txtTiempoCaducidad.Multiline = true;
            this.txtTiempoCaducidad.Name = "txtTiempoCaducidad";
            this.txtTiempoCaducidad.ReadOnly = true;
            this.txtTiempoCaducidad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTiempoCaducidad.Size = new System.Drawing.Size(300, 208);
            this.txtTiempoCaducidad.TabIndex = 16;
            // 
            // lblCambiar
            // 
            this.lblCambiar.AutoSize = true;
            this.lblCambiar.Location = new System.Drawing.Point(358, 270);
            this.lblCambiar.Name = "lblCambiar";
            this.lblCambiar.Size = new System.Drawing.Size(103, 13);
            this.lblCambiar.TabIndex = 17;
            this.lblCambiar.Text = "________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(457, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "INFORMACIÓN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fecha de vencimiento";
            // 
            // dtpFechaV
            // 
            this.dtpFechaV.Location = new System.Drawing.Point(149, 254);
            this.dtpFechaV.Name = "dtpFechaV";
            this.dtpFechaV.Size = new System.Drawing.Size(119, 20);
            this.dtpFechaV.TabIndex = 20;
            // 
            // FrmAlmacenHLBV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 515);
            this.Controls.Add(this.dtpFechaV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCambiar);
            this.Controls.Add(this.txtTiempoCaducidad);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFechaE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecioU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTiempoCaducidad);
            this.Controls.Add(this.btnMasCaro);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cmbAccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAlmacenHLBV";
            this.Text = "Helen Lisbeth Bernal Vera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAccion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Button btnMasCaro;
        private System.Windows.Forms.Button btnTiempoCaducidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTiempoCaducidad;
        private System.Windows.Forms.Label lblCambiar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaV;
    }
}

