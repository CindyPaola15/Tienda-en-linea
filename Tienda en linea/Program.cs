using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_en_linea
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Crear productos
            Producto producto1 = new Producto { Nombre = "Camiseta", Descripcion = "Camiseta de algodón", Precio = 15.5m, CantidadEnStock = 10 };
            Producto producto2 = new Producto { Nombre = "Pantalón", Descripcion = "Pantalón de mezclilla", Precio = 25.0m, CantidadEnStock = 5 };

            // Crear cliente
            Cliente cliente1 = new Cliente { Nombre = "Juan Pérez", Direccion = "Calle Falsa 123", CorreoElectronico = "juan@email.com" };

            // Crear pedido
            Pedido pedido1 = new Pedido { NumeroPedido = 1, Fecha = DateTime.Now, Estado = "Pendiente", Productos = new System.Collections.Generic.List<Producto> { producto1 } };

            // Registrar cliente y realizar compra
            cliente1.RealizarCompra(producto1, 2);

            // Confirmar el pedido
            pedido1.ConfirmarPedido();

            // Crear tienda
            Tienda tienda = new Tienda { Nombre = "La Mejor Tienda", Direccion = "Av. Comercio 456", Telefono = "123456789" };
            tienda.RegistrarPedido(pedido1);

            // Ver ventas realizadas
            Empleado empleado = new Empleado { Nombre = "Ana García", Direccion = "Calle 456", CorreoElectronico = "ana@email.com" };
            tienda.RegistrarEmpleado(empleado);
            empleado.ConsultarVentas();
        }
    }

        
        }
    

