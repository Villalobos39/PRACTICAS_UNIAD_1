using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMAR
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0 ,  numero = 1000000;  // SUMATORIA DEL 1 AL 1 000 000
            for (int contar=0; contar<=numero; contar++) 
            {
                 suma = suma + contar;
            }
            Console.Write("\n LA SUMA TOTAL ES : {0} ", suma);
            Console.ReadKey();
        }
    }
}
