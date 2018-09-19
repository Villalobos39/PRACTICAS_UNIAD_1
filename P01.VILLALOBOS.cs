using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISTANCIAPUNTOS
{
    public class DISTANCIA
    {
        Double a, b, c, d, r; // puntos de la recta 

        public DISTANCIA() { }
        public DISTANCIA(Double a, Double c, Double b, Double d)
        { this.a = a; this.b = b; this.c = c; this.d = d;  }
        public Double CALCULAR()
        {
            return r = Math.Sqrt((Math.Pow(c - a, 2)) + (Math.Pow(d - b, 2)));
        }
        public void IMPRIMIR()
        {
            Console.Write(" \n DISTANCIAS ENTRE DOS PUNTOS \n ");
            Console.Write("P (A,B ) ; ( " + a + " , " + b + " ) \n");
            Console.Write("P (C,D ) ; ( " + c + " , " + d + " ) \n");
            Double r = CALCULAR();
            Console.Write("LA DISTANCIA ENTRE PUNTOS ES :  " + r);
            Console.ReadKey();
        }
        ~DISTANCIA() {    }
    }
}
