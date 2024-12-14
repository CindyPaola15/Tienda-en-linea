using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_en_linea
{
    using System;

    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int CantidadEnStock { get; set; }

        // Método para agregar al carrito
        public void AgregarAlCarrito(int cantidad)
        {
            if (CantidadEnStock >= cantidad)
            {
                CantidadEnStock -= cantidad;
                Console.WriteLine($"{cantidad} {Nombre}(s) agregados al carrito.");
            }
            else
            {
                Console.WriteLine("No hay suficiente stock.");
            }
        }
    }
    internal class Clase_Producto
    {
    }
}
