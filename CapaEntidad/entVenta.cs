using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entVenta
    {
        public int IdVenta { get; set; }
        public int IdCliente { get; set; } 
        public int IdUsuario { get; set; } 
        public DateTime FechaVenta { get; set; }
        public string TipoComprobante { get; set; } 
        public string TipoVenta { get; set; }
        public decimal TotalPagar { get; set; }
        public string Estado { get; set; } 

        public List<entItemPedido> DetalleVenta { get; set; }
    }
}
