namespace Proyecto_Modelamiento
{
    partial class Venta
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
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.txtMontoRecibido = new System.Windows.Forms.TextBox();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservacionPlato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCantidadBebida = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbBebidas = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbTipoVenta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadPlato = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPlatos = new System.Windows.Forms.ComboBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPedidosRealizados = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPedidoCliente = new System.Windows.Forms.DataGridView();
            this.btnQuitarPedido = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBuscarCliente = new System.Windows.Forms.Button();
            this.txtDniBuscar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtApellidosCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosRealizados)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoCliente)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Location = new System.Drawing.Point(293, 543);
            this.btnAgregarPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(276, 32);
            this.btnAgregarPedido.TabIndex = 21;
            this.btnAgregarPedido.Text = "Agregar a Pedido de cliente ";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // txtMontoRecibido
            // 
            this.txtMontoRecibido.Location = new System.Drawing.Point(25, 133);
            this.txtMontoRecibido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontoRecibido.Name = "txtMontoRecibido";
            this.txtMontoRecibido.Size = new System.Drawing.Size(147, 26);
            this.txtMontoRecibido.TabIndex = 6;
            this.txtMontoRecibido.TextChanged += new System.EventHandler(this.txtMontoRecibido_TextChanged);
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.Location = new System.Drawing.Point(60, 183);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(62, 20);
            this.lblVuelto.TabIndex = 5;
            this.lblVuelto.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Vuelto:";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(23, 63);
            this.txtTotalPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalPagar.Multiline = true;
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(149, 27);
            this.txtTotalPagar.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Monto Recibido:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMontoRecibido);
            this.groupBox1.Controls.Add(this.lblVuelto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTotalPagar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(19, 325);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(191, 223);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen Pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total a pagar:";
            // 
            // txtObservacionPlato
            // 
            this.txtObservacionPlato.Location = new System.Drawing.Point(233, 347);
            this.txtObservacionPlato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservacionPlato.Multiline = true;
            this.txtObservacionPlato.Name = "txtObservacionPlato";
            this.txtObservacionPlato.Size = new System.Drawing.Size(376, 192);
            this.txtObservacionPlato.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Observacion:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCantidadBebida);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cmbBebidas);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmbTipoVenta);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCantidadPlato);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbPlatos);
            this.groupBox2.Location = new System.Drawing.Point(636, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(469, 303);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Pedidos";
            // 
            // txtCantidadBebida
            // 
            this.txtCantidadBebida.Location = new System.Drawing.Point(275, 212);
            this.txtCantidadBebida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadBebida.Name = "txtCantidadBebida";
            this.txtCantidadBebida.Size = new System.Drawing.Size(101, 26);
            this.txtCantidadBebida.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(289, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "Cantidad:";
            // 
            // cmbBebidas
            // 
            this.cmbBebidas.FormattingEnabled = true;
            this.cmbBebidas.Location = new System.Drawing.Point(208, 161);
            this.cmbBebidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(231, 28);
            this.cmbBebidas.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(289, 138);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Bebida:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 260);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(309, 26);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Fecha:";
            // 
            // cmbTipoVenta
            // 
            this.cmbTipoVenta.FormattingEnabled = true;
            this.cmbTipoVenta.Items.AddRange(new object[] {
            "Presencial",
            "Llevar "});
            this.cmbTipoVenta.Location = new System.Drawing.Point(129, 43);
            this.cmbTipoVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoVenta.Name = "cmbTipoVenta";
            this.cmbTipoVenta.Size = new System.Drawing.Size(213, 28);
            this.cmbTipoVenta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Platos:";
            // 
            // txtCantidadPlato
            // 
            this.txtCantidadPlato.Location = new System.Drawing.Point(31, 164);
            this.txtCantidadPlato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadPlato.Name = "txtCantidadPlato";
            this.txtCantidadPlato.Size = new System.Drawing.Size(101, 26);
            this.txtCantidadPlato.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Cantidad:";
            // 
            // cmbPlatos
            // 
            this.cmbPlatos.FormattingEnabled = true;
            this.cmbPlatos.Location = new System.Drawing.Point(31, 95);
            this.cmbPlatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPlatos.Name = "cmbPlatos";
            this.cmbPlatos.Size = new System.Drawing.Size(363, 28);
            this.cmbPlatos.TabIndex = 20;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(31, 62);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(295, 26);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(287, 538);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Anular Venta ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.dgvPedidosRealizados);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(1159, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 593);
            this.panel1.TabIndex = 22;
            // 
            // dgvPedidosRealizados
            // 
            this.dgvPedidosRealizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosRealizados.Location = new System.Drawing.Point(19, 17);
            this.dgvPedidosRealizados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPedidosRealizados.Name = "dgvPedidosRealizados";
            this.dgvPedidosRealizados.RowHeadersWidth = 62;
            this.dgvPedidosRealizados.RowTemplate.Height = 28;
            this.dgvPedidosRealizados.Size = new System.Drawing.Size(623, 511);
            this.dgvPedidosRealizados.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.dgvPedidoCliente);
            this.panel2.Controls.Add(this.btnQuitarPedido);
            this.panel2.Controls.Add(this.btnRegistrar);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.txtObservacionPlato);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnAgregarPedido);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(11, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 625);
            this.panel2.TabIndex = 23;
            // 
            // dgvPedidoCliente
            // 
            this.dgvPedidoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoCliente.Location = new System.Drawing.Point(19, 17);
            this.dgvPedidoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPedidoCliente.Name = "dgvPedidoCliente";
            this.dgvPedidoCliente.RowHeadersWidth = 62;
            this.dgvPedidoCliente.RowTemplate.Height = 28;
            this.dgvPedidoCliente.Size = new System.Drawing.Size(589, 258);
            this.dgvPedidoCliente.TabIndex = 35;
            // 
            // btnQuitarPedido
            // 
            this.btnQuitarPedido.Location = new System.Drawing.Point(216, 279);
            this.btnQuitarPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarPedido.Name = "btnQuitarPedido";
            this.btnQuitarPedido.Size = new System.Drawing.Size(188, 32);
            this.btnQuitarPedido.TabIndex = 34;
            this.btnQuitarPedido.Text = "Anular Pedido";
            this.btnQuitarPedido.UseVisualStyleBackColor = true;
            this.btnQuitarPedido.Click += new System.EventHandler(this.btnQuitarPedido_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(500, 583);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(135, 32);
            this.btnRegistrar.TabIndex = 33;
            this.btnRegistrar.Text = "Registrar Venta ";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Aquamarine;
            this.label12.Location = new System.Drawing.Point(1024, 596);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Regresar";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBuscarCliente);
            this.groupBox3.Controls.Add(this.txtDniBuscar);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtApellidosCliente);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtNombreCliente);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(636, 356);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(469, 225);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Cliente";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(344, 180);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(108, 30);
            this.txtBuscarCliente.TabIndex = 6;
            this.txtBuscarCliente.Text = "Buscar";
            this.txtBuscarCliente.UseVisualStyleBackColor = true;
            this.txtBuscarCliente.Click += new System.EventHandler(this.txtBuscarCliente_Click);
            // 
            // txtDniBuscar
            // 
            this.txtDniBuscar.Location = new System.Drawing.Point(31, 182);
            this.txtDniBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDniBuscar.Name = "txtDniBuscar";
            this.txtDniBuscar.Size = new System.Drawing.Size(295, 26);
            this.txtDniBuscar.TabIndex = 5;
            this.txtDniBuscar.TextChanged += new System.EventHandler(this.txtDniBuscar_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "DNI:";
            // 
            // txtApellidosCliente
            // 
            this.txtApellidosCliente.Location = new System.Drawing.Point(31, 123);
            this.txtApellidosCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidosCliente.Name = "txtApellidosCliente";
            this.txtApellidosCliente.ReadOnly = true;
            this.txtApellidosCliente.Size = new System.Drawing.Size(295, 26);
            this.txtApellidosCliente.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Apellidos:";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1836, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosRealizados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoCliente)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.TextBox txtMontoRecibido;
        private System.Windows.Forms.Label lblVuelto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObservacionPlato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCantidadBebida;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbBebidas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbTipoVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadPlato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPlatos;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPedidosRealizados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPedidoCliente;
        private System.Windows.Forms.Button btnQuitarPedido;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button txtBuscarCliente;
        private System.Windows.Forms.TextBox txtDniBuscar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtApellidosCliente;
        private System.Windows.Forms.Label label7;
    }
}