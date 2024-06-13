using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// você estiver familiarizado com C#, poderá ter visto arrays criados com a newpalavra-chave e talvez também tenha visto arrays com um tamanho especificado.
// Em C#, existem diferentes maneiras de criar um array:

namespace VetorCsharp
{
    internal class Exemplo04
    {
        public static void Main(string[] args) 
        {

            // Cria um array de quatro elementos e adiciona valores posteriormente
            string[] cars = new string[4];


            // Cria um array de quatro elementos e adiciona valores imediatamente
            string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };


            // Cria um array de quatro elementos sem especificar o tamanho
            string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };


            // Cria um array de quatro elementos sem especificar o tamanho
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

        }
    }
}
