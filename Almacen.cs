using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Modelamiento
{
    public partial class Almacen : Form
    {
        private int idInsumoSeleccionado = 0;
        public Almacen()
        {
            InitializeComponent();
        }

        // --- Método de Carga de ComboBox (NUEVO) ---
        private void CargarCategoriasEnComboBox()
        {
            // Asegúrate de que tu proyecto tenga referencia a CapaLogica y CapaEntidad
            List<entCategoria> listaCategoria = new logCategoria().ListarCategorias();

            // Opción inicial: "Seleccione..." (IdCategoria = 0)
            listaCategoria.Insert(0, new entCategoria() { IdCategoria = 0, Nombre = "--- Seleccione Categoría ---" });

            // Asignación al ComboBox (Asumiendo que se llama cboCategoria)
            cboCategoria.DataSource = listaCategoria;
            cboCategoria.DisplayMember = "Nombre";
            cboCategoria.ValueMember = "IdCategoria";
            cboCategoria.SelectedIndex = 0;
        }
        public void listarInsumo()
        {
            dgvInsumos.DataSource = logInsumo.Instancia.ListarInsumo();
            dgvInsumos.ClearSelection();
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtUnidad.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            chkActivo.Checked = false;
            dtpFecha.Value = DateTime.Now;
            idInsumoSeleccionado = 0;
        }

        private void dgvInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el clic sea en una fila válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaActual = dgvInsumos.Rows[e.RowIndex];

                // 1. Carga de los campos de texto y el ID
                idInsumoSeleccionado = Convert.ToInt32(filaActual.Cells["idInsumo"].Value);
                txtNombre.Text = filaActual.Cells["nombreInsumo"].Value.ToString();
                txtUnidad.Text = filaActual.Cells["unidadMedida"].Value.ToString();
                txtCantidad.Text = filaActual.Cells["cantidad"].Value.ToString();
                txtPrecio.Text = filaActual.Cells["precioUnitario"].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(filaActual.Cells["fecRegistro"].Value);
                chkActivo.Checked = Convert.ToBoolean(filaActual.Cells["estInsumo"].Value);

                // 2. Carga de las Claves Foráneas (ComboBoxes)

                // --- CATEGORÍA ---
                // Verificar si la celda no es DBNull antes de intentar la conversión
                if (filaActual.Cells["IdCategoria"].Value != null && filaActual.Cells["IdCategoria"].Value != DBNull.Value)
                {
                    int idCat = Convert.ToInt32(filaActual.Cells["IdCategoria"].Value);
                    cboCategoria.SelectedValue = idCat;
                }
                else
                {
                    cboCategoria.SelectedValue = 0; // Seleccionar la opción de "Seleccione Categoría" (Id=0)
                }

                // --- PROVEEDOR ---
                // 🚨 Es crucial cargar también el proveedor si lo necesitas para la edición.
                // Asumo que el DGV está devolviendo la columna "IdProveedor"
                if (filaActual.Cells["IdProveedor"].Value != null && filaActual.Cells["IdProveedor"].Value != DBNull.Value)
                {
                    int idProv = Convert.ToInt32(filaActual.Cells["IdProveedor"].Value);
                    cboProveedor.SelectedValue = idProv; // Asume que tienes un cboProveedor
                }
                else
                {
                    // Si el campo es nulo, selecciona la opción inicial (Id=0)
                    cboProveedor.SelectedValue = 0;
                }


                groupBoxDatos.Enabled = true;
                // Deshabilitamos el botón de Registrar, habilitamos Modificar y Deshabilitar
                btnRegistrar.Enabled = false;
                btnModificar.Enabled = true;
                btnDeshabilitar.Enabled = true; // Asegúrate de tener este botón
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener y validar Categoría
                int idCategoriaSeleccionada = Convert.ToInt32(cboCategoria.SelectedValue);

                // 🚨 Obtener y validar Proveedor
                int idProveedorSeleccionado = Convert.ToInt32(cboProveedor.SelectedValue);

                if (idCategoriaSeleccionada == 0 || idProveedorSeleccionado == 0)
                {
                    MessageBox.Show("Debe seleccionar una Categoría y un Proveedor.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Crear la entidad Insumo
                entInsumo ins = new entInsumo
                {
                    nombreInsumo = txtNombre.Text.Trim(),
                    unidadMedida = txtUnidad.Text.Trim(),
                    cantidad = Convert.ToDecimal(txtCantidad.Text.Trim()),
                    precioUnitario = Convert.ToDecimal(txtPrecio.Text.Trim()),
                    fecRegistro = dtpFecha.Value,
                    estInsumo = chkActivo.Checked,

                    // --- CLAVES FORÁNEAS ---
                    IdCategoria = idCategoriaSeleccionada,
                    IdProveedor = idProveedorSeleccionado // 🚨 CAPTURA DEL PROVEEDOR
                };

                logInsumo.Instancia.InsertarInsumo(ins);
                MessageBox.Show("Insumo registrado correctamente.", "Sistema Cocina", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar insumo: " + ex.Message);
            }

            LimpiarCampos();
            groupBoxDatos.Enabled = false;
            listarInsumo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idInsumoSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un insumo para modificar.");
                    return;
                }

                // 1. Obtener IdCategoria y IdProveedor seleccionados y validar
                int idCategoriaSeleccionada = Convert.ToInt32(cboCategoria.SelectedValue);
                // 🚨 CAPTURAR IdProveedor del ComboBox
                int idProveedorSeleccionado = Convert.ToInt32(cboProveedor.SelectedValue);

                if (idCategoriaSeleccionada == 0 || idProveedorSeleccionado == 0) // Validar ambos
                {
                    MessageBox.Show("Debe seleccionar una Categoría y un Proveedor.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Crear la entidad Insumo
                entInsumo ins = new entInsumo
                {
                    idInsumo = idInsumoSeleccionado,
                    nombreInsumo = txtNombre.Text.Trim(),
                    unidadMedida = txtUnidad.Text.Trim(),
                    cantidad = Convert.ToDecimal(txtCantidad.Text.Trim()),
                    precioUnitario = Convert.ToDecimal(txtPrecio.Text.Trim()),
                    fecRegistro = dtpFecha.Value,
                    estInsumo = chkActivo.Checked,

                    // --- CLAVES FORÁNEAS ---
                    IdCategoria = idCategoriaSeleccionada,
                    IdProveedor = idProveedorSeleccionado // 🚨 CRÍTICO: ASIGNAR EL VALOR
                };

                // 3. Llamada a la Capa Lógica (logInsumo.cs)
                logInsumo.Instancia.EditarInsumo(ins);
                MessageBox.Show("✏️ Insumo modificado correctamente.", "Sistema Cocina", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar insumo: " + ex.Message);
            }

            LimpiarCampos();
            groupBoxDatos.Enabled = false;
            listarInsumo();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idInsumoSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un insumo para deshabilitar.");
                    return;
                }

                logInsumo.Instancia.DeshabilitarInsumo(idInsumoSeleccionado);
                MessageBox.Show("Insumo deshabilitado correctamente.", "Sistema Cocina", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar insumo: " + ex.Message);
            }

            LimpiarCampos();
            groupBoxDatos.Enabled = false;
            listarInsumo();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            groupBoxDatos.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            LimpiarCampos();
        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            // Si lo quitaste del constructor, actívalo aquí
            listarInsumo();
            groupBoxDatos.Enabled = false;

            // CARGAR CATEGORÍAS
            CargarCategoriasEnComboBox();
            CargarProveedoresEnComboBox(); // 🚨 NUEVO
        }
        private void CargarProveedoresEnComboBox()
        {
            // Asume que logProveedor.Instancia.ListarProveedor() devuelve List<entProveedor>
            List<entProveedor> listaProveedor = logProveedor.Instancia.ListarProveedor();

            // Opción inicial: "Seleccione..." (IdProveedor = 0)
            listaProveedor.Insert(0, new entProveedor() { IdProveedor = 0, Nombre = "--- Seleccione Proveedor ---" });

            // Asignación al ComboBox (Asumiendo que se llama cboProveedor)
            cboProveedor.DataSource = listaProveedor;
            cboProveedor.DisplayMember = "Nombre"; // Asume la propiedad 'Nombre' en entProveedor
            cboProveedor.ValueMember = "IdProveedor";
            cboProveedor.SelectedIndex = 0;
        }
    }
}
