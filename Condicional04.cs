﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional04
{
    class Program
    {
        static void Main(string[] args)
        {
            double smmlv = 828116.0;
            double vcm = 0;
            Console.WriteLine("Ingrese su salario");
            double s = double.Parse(Console.ReadLine());

            if (s <= (2.0 * smmlv))
            {
                vcm = 3200;
                Console.WriteLine("A usted le corresponde la Tarifa A");
            }
            else if (s <= (5.0 * smmlv))
            {
                vcm = 12700;
                Console.WriteLine("A usted le corresponde la Tarifa B");
            }
            else
            {
                vcm = 33500;
                Console.WriteLine("A usted le corresponde la Tarifa C");
            }

            Console.WriteLine("Y su Valor de Cuota Moderada es " + vcm);
        }
    }
}
