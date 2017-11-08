using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float mivariable = 20;
            string mensaje = "edad=";
            Console.WriteLine(mensaje + mivariable);
            Console.WriteLine("Hola mundo");
            int[] m = { 1, 2, 3, 4, 5 };
            int [] n = { 4, 6, 7, 3, 1 };
            m.CopyTo(n, 0);
            Console.WriteLine("n",n);
            Console.WriteLine("m=",m);
            Console.WriteLine("Hola mundo");
            int edad;
            int x;
            edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("edad:");
            switch (edad)
            {
                case 20:
                    Console.WriteLine("tienes 20");
                        break;
                default:
                    break;
            }
            for (x=1;x<=5;x++)
            {
                Console.WriteLine("que edad tengo ", x);
            }
            int contador = 0;
            while (contador < 9) {
                contador = contador + 1;
                x = x + contador;
                Console.WriteLine("que edad tengo ", x);
            }
       
        }
    }
}
