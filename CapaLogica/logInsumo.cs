using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logInsumo
    {
        #region sigleton
        // Variable estática para la instancia
        private static readonly logInsumo _instancia = new logInsumo();
        public static logInsumo Instancia
        {
            get
            {
                return logInsumo._instancia;
            }
        }
        #endregion singleton

        #region metodos

        // Listar
        public List<entInsumo> ListarInsumo()
        {
            return datInsumo.Instancia.ListarInsumo();
        }

        // Insertar
        public void InsertarInsumo(entInsumo ins)
        {
            datInsumo.Instancia.InsertarInsumo(ins);
        }

        // Editar
        public void EditarInsumo(entInsumo ins)
        {
            datInsumo.Instancia.EditarInsumo(ins);
        }

        // Deshabilitar
        public void DeshabilitarInsumo(int idInsumo)
        {
            datInsumo.Instancia.DeshabilitarInsumo(idInsumo);
        }

        // ====================================================================
        // 🚀 NUEVOS MÉTODOS PARA EL FLUJO DE COCINA
        // ====================================================================

        public bool DescontarStock(int idInsumo, decimal cantidadDescontar)
        {
            // Se asume que datInsumo.Instancia.DescontarStock llama al SP_DescontarStockInsumo
            // y maneja la lógica de stock insuficiente.
            return datInsumo.Instancia.DescontarStock(idInsumo, cantidadDescontar);
        }

        /// <summary>
        /// Cambia el estado de la venta/pedido a 'Listo' (Notificar Mozo).
        /// </summary>
        /// <returns>True si el estado se actualizó con éxito.</returns>
        public bool MarcarPedidoListo(int idVenta)
        {
            // 🚨 NOTA: Este método debería estar en logVenta o logPedido, 
            // pero lo incluimos aquí si logInsumo es tu clase de utilidad general.

            // Asumimos que tienes una clase logPedido con este método, o movemos la lógica SQL aquí.
            // Para mantener la consistencia del dominio (la lógica del pedido), llamaremos a logPedido.
            // Si la Capa Lógica logPedido.Instancia no existe, necesitarás crearla.

            // Si tu lógica está en logPedido.Instancia.MarcarPedidoListo(idVenta)
            // return logPedido.Instancia.MarcarPedidoListo(idVenta); 

            // Si necesitas la lógica SQL aquí:
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                // Si solo marcas el estado a 'Listo' en la tabla Venta
                SqlCommand cmd = new SqlCommand("spMarcarPedidoListo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdVenta", idVenta);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        #endregion metodos
    }
}
