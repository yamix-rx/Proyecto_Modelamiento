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

        // Descontar Stock
        public bool DescontarStock(int idInsumo, decimal cantidadDescontar)
        {
            return datInsumo.Instancia.DescontarStock(idInsumo, cantidadDescontar);
        }

        // Marcar Pedido Listo
        public bool MarcarPedidoListo(int idVenta)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
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
