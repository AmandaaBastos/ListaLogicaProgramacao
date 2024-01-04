using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLogicaProgramacao
{
    internal class Fatorial
    {
        internal static void CalculoFatorial()
        {
            uint num1;
            Console.WriteLine("Por favor insira um número para ser calculado o fatorial:");
            try
            {
                uint.TryParse(Console.ReadLine(), out num1);
            }
            catch
            {
                Console.WriteLine("Por favor insira um número válido!\n(Apenas números inteiros positivos)");
                throw;
            }
            uint fatorial = 1;
            for (int i = 1; i <= num1; i++)
            {
                fatorial *= (uint)i;
            }
            Console.WriteLine($"O fatorial de {num1} é {fatorial}");
        }
    }
}
