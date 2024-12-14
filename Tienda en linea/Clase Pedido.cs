using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_en_linea
{
    using System;
    using System.Collections.Generic;

    public class Pedido
    {
        public int NumeroPedido { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public List<Producto> Productos { get; set; }

        public void ConfirmarPedido()
        {
            Estado = "Confirmado";
            Console.WriteLine($"Pedido {NumeroPedido} confirmado.");
        }

        public void CancelarPedido()
        {
            Estado = "Cancelado";
            Console.WriteLine($"Pedido {NumeroPedido} cancelado.");
        }
    }
    internal class Clase_Pedido
    {
    }
}
