using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//ara terar o valor de um elemento específico, consulte o número do índice:



namespace VetorCsharp
{
    internal class Exemplo2
    {
        public static void Main(string[] args)
        {
            string[] Carro = { "Volvo", "BMW", "Ford Ka", "Mercedes" };

            Carro[0] = "Opel";

            Console.WriteLine(Carro[0]);
        }
    }
}
