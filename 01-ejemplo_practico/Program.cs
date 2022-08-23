using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ejemplo_practico
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string> { "david", "marcos", "katherin", "julio" };
            List<string> nombres1 = new List<string> { "santiago", "david", "blanca", "marcos" };
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            
            var query = from n in nombres
                        join n1 in nombres1
                        on n equals n1
                        select n;

            var query1 = numeros.Where(n => n == 2).Select(n => n);

            foreach (var item in query)
            {
                Console.WriteLine("Nombre:" + item);

            }
            Console.WriteLine("-------------------");
            foreach(var item in query1)
            {
                Console.WriteLine("Numero: " + item);
            }
            Console.ReadLine();
        }
    }
}
