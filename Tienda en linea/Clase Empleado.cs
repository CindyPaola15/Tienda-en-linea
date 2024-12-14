using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_en_linea
{
    using System;
    using System.Collections.Generic;

    public class Empleado
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public List<Pedido> HistorialDeVentas { get; set; } = new List<Pedido>();

        public void ConsultarVentas()
        {
            Console.WriteLine($"Ventas realizadas por {Nombre}:");
            foreach (var pedido in HistorialDeVentas)
            {
                Console.WriteLine($"- Pedido #{pedido.NumeroPedido}, Estado: {pedido.Estado}");
            }
        }
    }
    internal class Clase_Empleado
    {
    }
}
