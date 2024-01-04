using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLogicaProgramacao
{
    internal class Primo
    {   
        static uint num1;
        internal static void E_Primo()
        {
            num1 = 0;
            Console.WriteLine("Por favor insira um número para ser verificado:");
            
            try
            {
                uint.TryParse(Console.ReadLine(), out num1);
            }
            catch
            {
                Console.WriteLine("Por favor insira um número válido!\n(Apenas números inteiros positivos)");
                throw;
            }
            
            bool primo = true;
            
            for (int i = 2; i <= num1; i++)
            {
                if (num1 % i == 0)
                {
                    primo = false;
                    break;
                }
            }
            if (primo)
            {
                Console.WriteLine("O número é primo!");
            }
            else
            {
                Console.WriteLine("O número não é primo!");
            }
        }        
    }
}
