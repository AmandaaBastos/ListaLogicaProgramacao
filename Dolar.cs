using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLogicaProgramacao
{
    internal class Dolar
    {
        internal static void CalcularValorDolar()
        {
            double valorDolar;
            double valorReal;
            Console.WriteLine("Por favor insira a cotação do dólar:");
            try
            {
                double.TryParse(Console.ReadLine(), out valorDolar);
            }
            catch
            {
                Console.WriteLine("Por favor insira um número válido!\n(Apenas números)");
                throw;
            }
            Console.WriteLine("Por favor insira o valor,em real, que deseja que seja convertido:");
            try
            {
                double.TryParse(Console.ReadLine(), out valorReal);
            }
            catch
            {
                Console.WriteLine("Por favor insira um número válido!\n(Apenas números)");
                throw;
            }
            double resultado = valorReal / valorDolar;
            Console.WriteLine($"O valor de {valorReal} em dólares é: {Math.Round(resultado, 2)}\nObs:Aproximação de duas casas decimais!") ;
        }
    }
}
