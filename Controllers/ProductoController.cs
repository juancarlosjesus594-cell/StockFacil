using StockFacil.Models;
using StockFacil.Services;

namespace StockFacil.Controllers
{
    public class ProductoController
    {
        private readonly ProductoService productoService;

        public ProductoController()
        {
            productoService = new ProductoService();
        }

        public bool RegistrarProducto(Producto producto)
        {
            return productoService.ValidarProducto(producto);
        }
    }
}