namespace ProductosApp
{
    partial class Form1
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
            this.lstNombre = new System.Windows.Forms.ListBox();
            this.lstPrecio = new System.Windows.Forms.ListBox();
            this.lstCantidad = new System.Windows.Forms.ListBox();
            this.lstImporte = new System.Windows.Forms.ListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSucursal = new System.Windows.Forms.Button();
            this.btnDIa = new System.Windows.Forms.Button();
            this.lstSucursal = new System.Windows.Forms.ListBox();
            this.lstDia = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPorSucursal = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtPromSucu = new System.Windows.Forms.TextBox();
            this.txtPromDia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblPromGeneral = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstNombre
            // 
            this.lstNombre.FormattingEnabled = true;
            this.lstNombre.ItemHeight = 16;
            this.lstNombre.Location = new System.Drawing.Point(31, 57);
            this.lstNombre.Margin = new System.Windows.Forms.Padding(4);
            this.lstNombre.Name = "lstNombre";
            this.lstNombre.Size = new System.Drawing.Size(178, 276);
            this.lstNombre.TabIndex = 0;
            // 
            // lstPrecio
            // 
            this.lstPrecio.FormattingEnabled = true;
            this.lstPrecio.ItemHeight = 16;
            this.lstPrecio.Location = new System.Drawing.Point(258, 57);
            this.lstPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.lstPrecio.Name = "lstPrecio";
            this.lstPrecio.Size = new System.Drawing.Size(178, 276);
            this.lstPrecio.TabIndex = 1;
            // 
            // lstCantidad
            // 
            this.lstCantidad.FormattingEnabled = true;
            this.lstCantidad.ItemHeight = 16;
            this.lstCantidad.Location = new System.Drawing.Point(476, 57);
            this.lstCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.lstCantidad.Name = "lstCantidad";
            this.lstCantidad.Size = new System.Drawing.Size(178, 276);
            this.lstCantidad.TabIndex = 2;
            // 
            // lstImporte
            // 
            this.lstImporte.FormattingEnabled = true;
            this.lstImporte.ItemHeight = 16;
            this.lstImporte.Location = new System.Drawing.Point(840, 57);
            this.lstImporte.Margin = new System.Windows.Forms.Padding(4);
            this.lstImporte.Name = "lstImporte";
            this.lstImporte.Size = new System.Drawing.Size(178, 276);
            this.lstImporte.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(31, 386);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(258, 386);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(178, 22);
            this.txtPrecio.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(476, 386);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(178, 22);
            this.txtCantidad.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(671, 107);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(141, 30);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(840, 386);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(178, 22);
            this.txtTotal.TabIndex = 8;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(246, 466);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(162, 38);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.TabStop = false;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Precio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cantidad";
            // 
            // btnSucursal
            // 
            this.btnSucursal.Location = new System.Drawing.Point(671, 158);
            this.btnSucursal.Margin = new System.Windows.Forms.Padding(4);
            this.btnSucursal.Name = "btnSucursal";
            this.btnSucursal.Size = new System.Drawing.Size(141, 30);
            this.btnSucursal.TabIndex = 15;
            this.btnSucursal.Text = "Sucursal";
            this.btnSucursal.UseVisualStyleBackColor = true;
            this.btnSucursal.Click += new System.EventHandler(this.btnSucursal_Click);
            // 
            // btnDIa
            // 
            this.btnDIa.Location = new System.Drawing.Point(671, 211);
            this.btnDIa.Margin = new System.Windows.Forms.Padding(4);
            this.btnDIa.Name = "btnDIa";
            this.btnDIa.Size = new System.Drawing.Size(141, 30);
            this.btnDIa.TabIndex = 16;
            this.btnDIa.Text = "DIa";
            this.btnDIa.UseVisualStyleBackColor = true;
            this.btnDIa.Click += new System.EventHandler(this.btnDIa_Click);
            // 
            // lstSucursal
            // 
            this.lstSucursal.FormattingEnabled = true;
            this.lstSucursal.ItemHeight = 16;
            this.lstSucursal.Location = new System.Drawing.Point(1048, 57);
            this.lstSucursal.Margin = new System.Windows.Forms.Padding(4);
            this.lstSucursal.Name = "lstSucursal";
            this.lstSucursal.Size = new System.Drawing.Size(178, 276);
            this.lstSucursal.TabIndex = 17;
            // 
            // lstDia
            // 
            this.lstDia.FormattingEnabled = true;
            this.lstDia.ItemHeight = 16;
            this.lstDia.Location = new System.Drawing.Point(1270, 57);
            this.lstDia.Margin = new System.Windows.Forms.Padding(4);
            this.lstDia.Name = "lstDia";
            this.lstDia.Size = new System.Drawing.Size(178, 276);
            this.lstDia.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1306, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Por Dia";
            // 
            // lblPorSucursal
            // 
            this.lblPorSucursal.AutoSize = true;
            this.lblPorSucursal.Location = new System.Drawing.Point(1083, 25);
            this.lblPorSucursal.Name = "lblPorSucursal";
            this.lblPorSucursal.Size = new System.Drawing.Size(96, 16);
            this.lblPorSucursal.TabIndex = 20;
            this.lblPorSucursal.Text = "Por Sucursal";
            this.lblPorSucursal.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(852, 25);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(60, 16);
            this.lblImporte.TabIndex = 21;
            this.lblImporte.Text = "Importe";
            // 
            // txtPromSucu
            // 
            this.txtPromSucu.Location = new System.Drawing.Point(1048, 386);
            this.txtPromSucu.Margin = new System.Windows.Forms.Padding(4);
            this.txtPromSucu.Name = "txtPromSucu";
            this.txtPromSucu.Size = new System.Drawing.Size(178, 22);
            this.txtPromSucu.TabIndex = 22;
            // 
            // txtPromDia
            // 
            this.txtPromDia.Location = new System.Drawing.Point(1270, 386);
            this.txtPromDia.Margin = new System.Windows.Forms.Padding(4);
            this.txtPromDia.Name = "txtPromDia";
            this.txtPromDia.Size = new System.Drawing.Size(178, 22);
            this.txtPromDia.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(837, 348);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Importe Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1053, 348);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Promedio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1267, 348);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Promedio";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(511, 466);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(162, 38);
            this.btnMostrar.TabIndex = 27;
            this.btnMostrar.TabStop = false;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1256, 482);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(162, 38);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblPromGeneral
            // 
            this.lblPromGeneral.AutoSize = true;
            this.lblPromGeneral.Location = new System.Drawing.Point(799, 466);
            this.lblPromGeneral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromGeneral.Name = "lblPromGeneral";
            this.lblPromGeneral.Size = new System.Drawing.Size(154, 16);
            this.lblPromGeneral.TabIndex = 29;
            this.lblPromGeneral.Text = "Promedio General :$ ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 554);
            this.Controls.Add(this.lblPromGeneral);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPromDia);
            this.Controls.Add(this.txtPromSucu);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblPorSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDia);
            this.Controls.Add(this.lstSucursal);
            this.Controls.Add(this.btnDIa);
            this.Controls.Add(this.btnSucursal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lstImporte);
            this.Controls.Add(this.lstCantidad);
            this.Controls.Add(this.lstPrecio);
            this.Controls.Add(this.lstNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNombre;
        private System.Windows.Forms.ListBox lstPrecio;
        private System.Windows.Forms.ListBox lstCantidad;
        private System.Windows.Forms.ListBox lstImporte;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSucursal;
        private System.Windows.Forms.Button btnDIa;
        private System.Windows.Forms.ListBox lstSucursal;
        private System.Windows.Forms.ListBox lstDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPorSucursal;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtPromSucu;
        private System.Windows.Forms.TextBox txtPromDia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblPromGeneral;
    }
}

