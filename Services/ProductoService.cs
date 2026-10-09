using StockFacil.Models;
namespace StockFacil.Services
{
    public class ProductoService
    {
        /// <summary>
        /// Valida que el producto cumpla con las reglas del requisito RF-02.
        /// - El nombre no debe estar vacío.
        /// - El precio debe ser estrictamente mayor a 0.
        /// </summary>
        public bool ValidarProducto(string nombre, decimal precio)
        {
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