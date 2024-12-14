using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProyecto
{
    internal class Program

    {
        static void Main(string[] args)
        {
            // Crear una instancia de la calculadora científica
            CalculadoraCientifica calculadora = new CalculadoraCientifica();

            // Probar operaciones
            Console.WriteLine("Suma: " + calculadora.Sumar(5, 3));
            Console.WriteLine("Resta: " + calculadora.Restar(5, 3));
            Console.WriteLine("Multiplicación: " + calculadora.Multiplicar(5, 3));
            Console.WriteLine("División: " + calculadora.Dividir(5, 3));
            Console.WriteLine("Área del círculo: " + calculadora.CalcularAreaCirculo(5));
            Console.WriteLine("Volumen de la esfera: " + calculadora.CalcularVolumenEsfera(5));
            Console.WriteLine("Distancia entre puntos: " + calculadora.CalcularDistancia(1, 1, 4, 5));
            Console.WriteLine("Seno de 45 grados: " + calculadora.CalcularSeno(45 * Math.PI / 180));
        }
}
        
        }
    

