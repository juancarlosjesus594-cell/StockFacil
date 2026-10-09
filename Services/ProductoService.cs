using StockFacil.Models;

namespace StockFacil.Services
namespace StockFacil.Services
{
    public class ProductoService
    {
        public bool ValidarProducto(string nombre, decimal precio)
        {
            // RF-02: Verificar que el nombre no esté vacío y el precio sea mayor que cero
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return false;
            }

            if (precio <= 0)
            {
                return false;
            }

            return true;
        }
    }
}