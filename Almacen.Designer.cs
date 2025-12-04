namespace Proyecto_Modelamiento
{
    partial class Almacen
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.lblTituloInsumos = new System.Windows.Forms.Label();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(789, 90);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(147, 45);
            this.btnNuevo.TabIndex = 26;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.Location = new System.Drawing.Point(789, 317);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(147, 45);
            this.btnDeshabilitar.TabIndex = 23;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(789, 164);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(147, 45);
            this.btnRegistrar.TabIndex = 22;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cboProveedor
            // 
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(190, 279);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(383, 33);
            this.cboProveedor.TabIndex = 20;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(190, 239);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(383, 33);
            this.cboCategoria.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Categoria:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(510, 405);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 45);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(154, 359);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(139, 29);
            this.chkActivo.TabIndex = 11;
            this.chkActivo.Text = "Disponible";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(232, 320);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(378, 31);
            this.dtpFecha.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(56, 405);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(133, 45);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(217, 195);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(378, 31);
            this.txtPrecio.TabIndex = 9;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(154, 145);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(329, 31);
            this.txtCantidad.TabIndex = 8;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(789, 245);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(147, 45);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(217, 90);
            this.txtUnidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(378, 31);
            this.txtUnidad.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Activo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Registro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio Unitario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unidad Medida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(828, 900);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(147, 34);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.cboProveedor);
            this.groupBoxDatos.Controls.Add(this.cboCategoria);
            this.groupBoxDatos.Controls.Add(this.label7);
            this.groupBoxDatos.Controls.Add(this.btnCancelar);
            this.groupBoxDatos.Controls.Add(this.chkActivo);
            this.groupBoxDatos.Controls.Add(this.dtpFecha);
            this.groupBoxDatos.Controls.Add(this.btnLimpiar);
            this.groupBoxDatos.Controls.Add(this.txtPrecio);
            this.groupBoxDatos.Controls.Add(this.txtCantidad);
            this.groupBoxDatos.Controls.Add(this.txtUnidad);
            this.groupBoxDatos.Controls.Add(this.txtNombre);
            this.groupBoxDatos.Controls.Add(this.label6);
            this.groupBoxDatos.Controls.Add(this.label5);
            this.groupBoxDatos.Controls.Add(this.label4);
            this.groupBoxDatos.Controls.Add(this.label3);
            this.groupBoxDatos.Controls.Add(this.label2);
            this.groupBoxDatos.Controls.Add(this.label1);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatos.Location = new System.Drawing.Point(18, 53);
            this.groupBoxDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDatos.Size = new System.Drawing.Size(712, 471);
            this.groupBoxDatos.TabIndex = 21;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos del Insumo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 44);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(329, 31);
            this.txtNombre.TabIndex = 6;
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumos.Location = new System.Drawing.Point(18, 532);
            this.dgvInsumos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.RowHeadersWidth = 51;
            this.dgvInsumos.RowTemplate.Height = 24;
            this.dgvInsumos.Size = new System.Drawing.Size(957, 360);
            this.dgvInsumos.TabIndex = 20;
            this.dgvInsumos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInsumos_CellContentClick);
            // 
            // lblTituloInsumos
            // 
            this.lblTituloInsumos.AutoSize = true;
            this.lblTituloInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInsumos.Location = new System.Drawing.Point(427, 9);
            this.lblTituloInsumos.Name = "lblTituloInsumos";
            this.lblTituloInsumos.Size = new System.Drawing.Size(164, 40);
            this.lblTituloInsumos.TabIndex = 19;
            this.lblTituloInsumos.Text = "Almacen";
            // 
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 955);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.dgvInsumos);
            this.Controls.Add(this.lblTituloInsumos);
            this.Name = "Almacen";
            this.Text = "Almacen";
            this.Load += new System.EventHandler(this.Almacen_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.Label lblTituloInsumos;
    }
}