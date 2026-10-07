using System.Collections.Generic;
using StockFacil.Models;

namespace StockFacil.Data
{
    public class ProductoRepository
    {
        private readonly List<Producto> productos;

        public ProductoRepository()
        {
            productos = new List<Producto>();
        }

        public void Agregar(Producto producto)
        {
            productos.Add(producto);
        }

        public List<Producto> ObtenerTodos()
        {
            return productos;
        }
    }
}