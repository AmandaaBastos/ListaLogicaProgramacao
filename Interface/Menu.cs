using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLogicaProgramacao.Interface
{
    internal class Menu<T>
    {
        private readonly T[] opcoes;
        private int selectedIndex;


        public Menu(T[] menuItems)
        {
            opcoes = menuItems;
            selectedIndex = 0;

        }

        public int ShowMenu()
        {
            ConsoleKeyInfo teclaUsuario;
            do
            {
                Console.Clear();
                Console.WriteLine("Cabeçalho aqui");
                DisplayMenu();

                teclaUsuario = Console.ReadKey();

                switch (teclaUsuario.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex = Math.Max(0, selectedIndex - 1);
                        break;

                    case ConsoleKey.DownArrow:
                        selectedIndex = Math.Min(opcoes.Length - 1, selectedIndex + 1);
                        break;
                }
            } while (teclaUsuario.Key != ConsoleKey.Enter);

            Console.WriteLine($"\nOpção selecionada: {opcoes[selectedIndex]}\n\n");
            return selectedIndex;
        }

        private void DisplayMenu()
        {

            Console.WriteLine("Selecione uma opção:");

            for (int i = 0; i < opcoes.Length; i++)
            {
                Console.ForegroundColor = i == selectedIndex ? ConsoleColor.Black : ConsoleColor.Gray;
                Console.BackgroundColor = i == selectedIndex ? ConsoleColor.Gray : ConsoleColor.Black;

                Console.WriteLine($"{opcoes[i]}");

                Console.ResetColor();
            }
        }
    }
    
}
