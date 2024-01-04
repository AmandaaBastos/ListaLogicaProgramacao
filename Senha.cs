using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLogicaProgramacao
{
    internal class Senha
    {
        public static void ValidarSenha()
        {
            Console.WriteLine("Digite uma senha:\n\nEla deve possuir:\nNo mínimo 8 caracteres\nConter pelo menos uma letra maiúscula e uma letra minúscula\nUm número.");
            string senha = Console.ReadLine();
            bool senhaValida = false;
            do
            {
                if (senha.Length < 8)
                {
                    Console.WriteLine("Sua senha precisa ter, no mínimo, 8 dígitos. Digite novamente: ");
                    senha = Console.ReadLine();
                }
                else if (!senha.Any(char.IsUpper))
                {
                    Console.WriteLine("Sua senha precisa ter, no mínimo, uma letra maiúscula. Digite novamente: ");
                    senha = Console.ReadLine();
                }
                else if (!senha.Any(char.IsLower))
                {
                    Console.WriteLine("Sua senha precisa ter, no mínimo, uma letra minúscula. Digite novamente: ");
                    senha = Console.ReadLine();
                }
                else if (!senha.Any(char.IsDigit))
                {
                    Console.WriteLine("Sua senha precisa ter, no mínimo, um número. Digite novamente: ");
                    senha = Console.ReadLine();
                }
                else
                {
                    senhaValida = true;
                }
            } while (senhaValida == false);
            Console.WriteLine("Senha válida!");
        }
    }
}
