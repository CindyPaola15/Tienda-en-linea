using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProyecto
{
    public abstract class CalculadoraBase : IOperaciones
    {
        public double Sumar(double a, double b) => a + b;
        public double Restar(double a, double b) => a - b;
        public double Multiplicar(double a, double b) => a * b;
        public double Dividir(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("No se puede dividir por cero.");
            return a / b;
        }
        public double CalcularAreaCirculo(double radio) => Math.PI * radio * radio;
        public double CalcularVolumenEsfera(double radio) => (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
        public double CalcularDistancia(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
    
    }

