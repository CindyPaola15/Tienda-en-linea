using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_en_linea
{
    using System;
    using System.Collections.Generic;

    public class Tienda
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public List<Empleado> Empleados { get; set; } = new List<Empleado>();
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();

        public void RegistrarEmpleado(Empleado empleado)
        {
            Empleados.Add(empleado);
            Console.WriteLine($"Empleado {empleado.Nombre} registrado.");
        }

        public void RegistrarPedido(Pedido pedido)
        {
            Pedidos.Add(pedido);
            Console.WriteLine($"Pedido #{pedido.NumeroPedido} registrado.");
        }
    }
    internal class Clase_Tienda
    {
    }
}
