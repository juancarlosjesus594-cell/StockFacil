using System;

namespace StockFacil.Views
{
    public class ProductoView
    {
        public void MostrarResultado(bool resultado)
        {
            if (resultado)
            {
                Console.WriteLine("Producto válido.");
            }
            else
            {
                Console.WriteLine("Producto inválido.");
            }
        }
    }
}