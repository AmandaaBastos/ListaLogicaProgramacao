using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLogicaProgramacao
{
    internal class ConversorTemperatura
    {   
       static double num1,num2;
        internal static void MenuSelecao()
        {
            bool sair = false;

            do
            {
                num1=0;num2= 0;
                Console.Clear();               
                string[] opcoesUsuario = {"1. Converter de Celcius para Fahrenheit", "2. Converter de Fahrenheit para Celcius", "3. Sair"};

                var conversorTemp = new Interface.Menu<string>(opcoesUsuario);
                int selecaoUsuario = conversorTemp.ShowMenu();               
                switch (selecaoUsuario)
                {
                    case 0:
                        PedirInput();
                        ConverterCelcius_Fahrenheit();
                        break;
                    case 1:
                        PedirInput();
                        ConverterFahrenheit_Celcius();
                        break;
                    case 2:
                        sair = true;
                        break;
                }               
            } while (!sair);
        }

        internal static void PedirInput()
        {
            Console.WriteLine("Por favor insira a temperatura para ser convertida:");
            try
            {
                double.TryParse(Console.ReadLine(), out num1);

            }
            catch
            {
                Console.WriteLine("Por favor insira uma temperatura válida!\n(Apenas números)");
                throw;
            }
        }
        
        internal static void ConverterCelcius_Fahrenheit()
        {
            num2 = num1 * (9.0 / 5.0) + 32;
            Console.WriteLine($"A temperatura de {num1}°C equivale a {Math.Round(num2, 2)};°F\nObs:Aproximação de duas casas decimais!");
        }
        internal static void ConverterFahrenheit_Celcius()
        {
            num2 = (num1 - 32) * (5.0 / 9.0);
            Console.WriteLine($"A temperatura de {num1}°F equivale a {Math.Round(num2, 2)}°C\nObs:Aproximação de duas casas decimais!");
        }
    }
}
