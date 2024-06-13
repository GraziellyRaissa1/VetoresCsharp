using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Você acessa um elemento do array referindo-se ao número do índice.
//Esta instrução acessa o valor do primeiro elemento em carro :


namespace VetorCsharp
{
    internal class Exemplo1
    {
        public static void Main(string[] args)
        {

            string[] Carro = { "Volvo", "BMW", "Ford Ka", "Mercedes" };

            Console.WriteLine(Carro[0]);

        }
    }
}
