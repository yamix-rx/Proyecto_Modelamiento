using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProducto
    {
        // IMPLEMENTACION DEL SINGLETON
        private static readonly logProducto _instancia = new logProducto();

        // Propiedad estática para acceder a la instancia unica
        public static logProducto Instancia
        {
            get { return _instancia; }
        }

        private datProducto Datos = new datProducto(); 

        // Método para Listar Productos
        public List<entProducto> ListarProductos()
        {
            try
            {
                return Datos.ListarProductos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar productos en la capa lógica: " + ex.Message);
            }
        }

        // Método para Registrar Producto
        public int Registrar(entProducto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(obj.Nombre))
            {
                Mensaje = "El nombre del plato/bebida no puede ser vacío.";
            }
            else if (obj.Costo <= 0)
            {
                Mensaje = "El costo debe ser un valor positivo.";
            }
            else if (string.IsNullOrWhiteSpace(obj.Tipo))
            {
                Mensaje = "Debe seleccionar un tipo (Plato o Bebida).";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return Datos.Registrar(obj, out Mensaje);
            }
        }

        // Metodo para Editar Producto
        public bool Editar(entProducto obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.IdProducto == 0)
            {
                Mensaje = "Debe seleccionar un producto para editar.";
            }
            else if (string.IsNullOrWhiteSpace(obj.Nombre))
            {
                Mensaje = "El nombre del plato/bebida no puede ser vacío.";
            }
            else if (obj.Costo <= 0)
            {
                Mensaje = "El costo debe ser un valor positivo.";
            }
            else if (string.IsNullOrWhiteSpace(obj.Tipo))
            {
                Mensaje = "Debe seleccionar un tipo (Plato o Bebida).";
            }

            if (Mensaje != string.Empty)
            {
                return false; 
            }
            else
            {
                return Datos.Editar(obj, out Mensaje);
            }
        }

        // Metodo para Eliminar Producto
        public bool Eliminar(int idproducto, out string Mensaje)
        {
            return Datos.Eliminar(idproducto, out Mensaje);
        }
    }
}
