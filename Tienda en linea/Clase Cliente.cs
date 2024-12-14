using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_en_linea
{
    using System;
    using System.Collections.Generic;

    public class Cliente
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public List<Producto> HistorialDeCompras { get; set; } = new List<Producto>();

        // Método para realizar compra
        public void RealizarCompra(Producto producto, int cantidad)
        {
            producto.AgregarAlCarrito(cantidad);
            HistorialDeCompras.Add(producto);
            Console.WriteLine($"{Nombre} ha comprado {cantidad} {producto.Nombre}(s).");
        }

        // Método para ver el carrito (Historial de compras)
        public void VerCarrito()
        {
            Console.WriteLine($"{Nombre}'s Carrito:");
            foreach (var producto in HistorialDeCompras)
            {
                Console.WriteLine($"- {producto.Nombre} x{HistorialDeCompras.Count}");
            }
        }
    }
    internal class Clase_Cliente
    {
    }
}
