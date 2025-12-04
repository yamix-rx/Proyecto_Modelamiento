using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datInsumo
    {
        #region Singleton
        private static readonly datInsumo _instancia = new datInsumo();
        public static datInsumo Instancia
        {
            get { return _instancia; }
        }
        #endregion

        #region Métodos

       
        // LISTAR INSUMOS
      
        public List<entInsumo> ListarInsumo()
        {
            List<entInsumo> lista = new List<entInsumo>();

            try
            {
                // Usamos 'using' para asegurar el cierre de la conexión
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("spListarInsumo", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cn.Open();

                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            entInsumo ins = new entInsumo();
                            ins.idInsumo = Convert.ToInt32(dr["idInsumo"]);
                            ins.nombreInsumo = dr["nombreInsumo"].ToString();
                            ins.unidadMedida = dr["unidadMedida"].ToString();
                            ins.cantidad = Convert.ToDecimal(dr["cantidad"]);
                            ins.precioUnitario = Convert.ToDecimal(dr["precioUnitario"]);
                            ins.estInsumo = Convert.ToBoolean(dr["estInsumo"]);
                            ins.fecRegistro = Convert.ToDateTime(dr["fecRegistro"]);

                            // Manejo de nulos (Asumiendo que IdCategoria y NombreCategoria existen)
                            ins.IdCategoria = dr["IdCategoria"] is DBNull ? 0 : Convert.ToInt32(dr["IdCategoria"]);
                            ins.NombreCategoria = dr["NombreCategoria"] is DBNull ? "" : dr["NombreCategoria"].ToString();

                            lista.Add(ins);
                        }
                    } // cmd.Dispose() y cn.Close() se llaman automáticamente
                }
            }
            catch (Exception e)
            {
                // Solo propagamos la excepción
                throw e;
            }
            return lista;
        }

        // INSERTAR INSUMO
        
        public bool InsertarInsumo(entInsumo ins)
        {
            SqlCommand cmd = null;
            bool insertado = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();

                // Incluir @IdProveedor en el comando, ya que el SP lo requiere
                cmd = new SqlCommand("spInsertarInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombreInsumo", ins.nombreInsumo);
                cmd.Parameters.AddWithValue("@unidadMedida", ins.unidadMedida);
                cmd.Parameters.AddWithValue("@cantidad", ins.cantidad);
                cmd.Parameters.AddWithValue("@precioUnitario", ins.precioUnitario);
                cmd.Parameters.AddWithValue("@estInsumo", ins.estInsumo);
                cmd.Parameters.AddWithValue("@fecRegistro", ins.fecRegistro);

                // CAMBIO CRÍTICO APLICADO 
                cmd.Parameters.AddWithValue("@IdCategoria", ins.IdCategoria);
                cmd.Parameters.AddWithValue("@IdProveedor", ins.IdProveedor); // PARÁMETRO FALTANTE AÑADIDO

                cn.Open();
                int filas = cmd.ExecuteNonQuery();
                if (filas > 0)
                    insertado = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null) cmd.Connection.Close();
            }

            return insertado;
        }

       
        // EDITAR INSUMO
      
        public bool EditarInsumo(entInsumo ins)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("spEditarInsumo", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@idInsumo", ins.idInsumo);
                        cmd.Parameters.AddWithValue("@nombreInsumo", ins.nombreInsumo);
                        cmd.Parameters.AddWithValue("@unidadMedida", ins.unidadMedida);
                        cmd.Parameters.AddWithValue("@cantidad", ins.cantidad);
                        cmd.Parameters.AddWithValue("@precioUnitario", ins.precioUnitario);
                        cmd.Parameters.AddWithValue("@estInsumo", ins.estInsumo);
                        cmd.Parameters.AddWithValue("@fecRegistro", ins.fecRegistro);
                        cmd.Parameters.AddWithValue("@IdCategoria", ins.IdCategoria);

                        // CORRECCIÓN CRÍTICA: Añadir el parámetro @IdProveedor
                        cmd.Parameters.AddWithValue("@IdProveedor", ins.IdProveedor);

                        cn.Open();
                        int filas = cmd.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
            }
            catch (Exception e)
            {
                // Si la excepción es de tipo SQL, el error de C# no debe ocultarla.
                throw e;
            }
        }

       
        // DESCONTAR STOCK (COCINA)
       
        public bool DescontarStock(int idInsumo, decimal cantidadDescontar)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("spDescontarStock", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idInsumo", idInsumo);
                        cmd.Parameters.AddWithValue("@cantidadRestar", cantidadDescontar);

                        cn.Open();

                        // Asumimos que spDescontarStock devuelve el número de filas afectadas
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        
        // DESHABILITAR INSUMO--Corregido
        
        public bool DeshabilitarInsumo(int idInsumo)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("spDeshabilitarInsumo", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idInsumo", idInsumo);

                        cn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion
    }
}
