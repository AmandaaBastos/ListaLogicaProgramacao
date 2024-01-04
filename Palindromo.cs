using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLogicaProgramacao
{
    internal class Palindromo
    {   
        internal static void E_Palindromo()
        {
            Console.WriteLine("Por favor insira uma palavra para ser verificada:");
            string palavra = Console.ReadLine().ToLower();
            string palavraInvertida = "";
            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                palavraInvertida += palavra[i];
            }
            if (palavra == palavraInvertida)
            {
                Console.WriteLine("A palavra é um palíndromo!");
            }
            else
            {
                Console.WriteLine("A palavra não é um palíndromo!");
            }
        }
    }
}
