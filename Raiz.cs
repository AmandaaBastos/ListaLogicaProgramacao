using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ListaLogicaProgramacao
{
    internal class Raiz
    {
        internal static void CalcularRaiz()
        {
            double num1;
            Console.WriteLine("Por favor insira um número para ser calculada a raiz quadrada:");
            try
            {
                double.TryParse(Console.ReadLine(), out num1);
            }
            catch
            {
                Console.WriteLine("Por favor insira um número válido!\n(Apenas números)");
                throw;
            }
            //Meétodo iteração 
            if (num1 < 0)
            {
                throw new ArgumentException("Não é possível calcular a raiz quadrada de um número negativo.");
            }
            else 
            {
                double resultadoEstimado = num1 / 2.0;
                for (int i = 0; i < 100; i++)
                {
                    resultadoEstimado = (resultadoEstimado + num1 / resultadoEstimado) / 2.0;
                }
                Console.WriteLine($"A raiz quadrada de {num1} é {Math.Round(resultadoEstimado, 2)}\nObs:Aproximação de duas casas decimais!");
            }
            
        }   
    }
}
