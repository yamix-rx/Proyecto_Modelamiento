using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        // Patron de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();

         
            cn.ConnectionString = "Data Source=DESKTOP-PK88VMC\\YENCI_RX;Initial Catalog=dprueba4;Integrated Security=true";

            return cn;
        }
    }
}
