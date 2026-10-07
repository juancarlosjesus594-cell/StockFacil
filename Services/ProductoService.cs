using StockFacil.Models;

namespace StockFacil.Services
{
    public class ProductoService
    {
        public bool ValidarProducto(Producto producto)
        {
            if (producto == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(producto.Nombre))
            {
                return false;
            }

            if (producto.Precio <= 0)
            {
                return false;
            }

            return true;
        }
    }
}