using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLogicaProgramacao
{
    internal class Ordem
    {
        internal static void OrdemCrescente()
        {        
            Console.WriteLine("Por favor insira os números para serem ordenados, separando-os por espaços:\nEx:(2,5 3 5 4 7)");
            string[] Snumeros = Console.ReadLine().Split(' ');
            CultureInfo cultura = new CultureInfo("pt-BR");
            double[] numeros = new double[Snumeros.Length];
            for (int i = 0; i < Snumeros.Length; i++)
            {
                if (double.TryParse(Snumeros[i], NumberStyles.Any, cultura, out double numero))
        
                {
                    numeros[i] = numero;
                }
                else
                {
                    throw new Exception("Parece que não foi possivel fazer a ordenação, por favor insira novamente os números desejados!");
                    return;
                }
            }
            Array.Sort(numeros);
            Console.WriteLine("A sequencia ordenadenada de números é:");
            foreach (double numero in numeros)
            {
                Console.Write($"{numero}, ");
            }
            Console.WriteLine();
        }
    }
}
