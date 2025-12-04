using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logPedido
    {
        #region Singleton
        private static readonly logPedido _instancia = new logPedido();
        public static logPedido Instancia
        {
            get { return _instancia; }
        }
        #endregion
        //metodo para llamar al metodo listar pedido de la capa de acceso a datos
        public List<entPedido> ListarPedidosPendientes()
        {
            return datPedido.Instancia.ListarPedidosPendientes();
        }
    }
}
