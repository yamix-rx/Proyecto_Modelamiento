using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entItemPedido
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; } 
        public int Cantidad { get; set; }
        public string Observacion { get; set; } 

      
        public decimal Importe { get { return PrecioUnitario * Cantidad; } } 

        
        public string NombreProducto { get; set; } 
    }
}
