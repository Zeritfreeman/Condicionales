using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional03
{
    class Program
    {
        static void Main(string[] args)
        {
            double smmlv = 828116.0;
            Console.WriteLine("Ingrese su salario");
            double s = double.Parse(Console.ReadLine());

            if (s < (2.0 * smmlv))
            {
                Console.WriteLine("A usted le corresponde la Tarifa A");
            }
            else if (s < (4.0 * smmlv)) 
            {
                Console.WriteLine("A usted le corresponde la Tarifa B");
            }
            else
            {
                Console.WriteLine("A usted le corresponde la Tarifa C");
            }
        }
    }
}
