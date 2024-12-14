using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProyecto
{
    public interface IOperaciones
    {
        double Sumar(double a, double b);
        double Restar(double a, double b);
        double Multiplicar(double a, double b);
        double Dividir(double a, double b);
        double CalcularAreaCirculo(double radio);
        double CalcularVolumenEsfera(double radio);
        double CalcularDistancia(double x1, double y1, double x2, double y2);
    }
    
    }

