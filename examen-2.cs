using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace examen_1
{
    public static class program
    {
        public static void Main()
        {
            // entrada
            double a, b, c, x, x1=0, x2=0;

            Console.WriteLine("ingrese el valor de A");
            a =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese el valo de B");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese el valor de C");
            c = Convert.ToDouble(Console.ReadLine());
           
            x = (b * b) - 4 * a * c;
            if (x < 0)
            {
                Console.WriteLine("no hay raices negativas");
            }
            else
            {
                x1 = (-b + Math.Sqrt(x)) / (2 * a);
                x2 = (-b - Math.Sqrt(x)) / (2 * a);
            }

            Console.WriteLine("el resultado de x1" + x1);
            Console.WriteLine("el resultado de x2" + x2);

            Console.ReadKey();
        }
    }
}

