using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace test.sobrecarga.operadores
{
    class Program
    {
        static void Main(string[] args)
        {

            Numero n1 = new Numero(5);

            Numero n2 = new Numero(4);

            if (n1 == n2)
            {
                Console.WriteLine("son iguales");
            }

            if (n1 != n2)
            {
                Console.WriteLine("son distintos");
            }

            if (n1 == 5)
            {
                Console.WriteLine("son iguales");
            }

            if (n1 != 8)
            {
                Console.WriteLine("son distintos");
            }

            Numero res = n1 + n2;

            Console.WriteLine("suma = {0}", res.valor);

            res = n1 - n2;

            Console.WriteLine("resta = {0}", res.valor);

            Console.ReadLine();
        }
    }
}
