using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLogicaProgramacao
{
    internal class ContadorPalavras
    {
        public static void ContarPalavras()
        {
            Console.WriteLine("Digite um texto para ser analisado:");
            string texto = Console.ReadLine();

            Dictionary<string, int> contagem = ContarFrequenciaPalavras(texto);

            Console.WriteLine("\nFrequência das palavras no texto:");
            foreach (var entrada in contagem)
            {
                Console.WriteLine($"{entrada.Key}: {entrada.Value} vezes");
            }

            Console.WriteLine($"\nTotal de palavras no texto: {contagem.Count}");
        }
        static Dictionary<string, int> ContarFrequenciaPalavras(string texto)
        {           
            string[] palavras = texto.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
           
            Dictionary<string, int> frequenciaPalavras = new Dictionary<string, int>();

            foreach (string palavra in palavras)
            {
                string palavraFormatada = RemoverPontuacoes(palavra.ToLower());

                if (frequenciaPalavras.ContainsKey(palavraFormatada))
                {
                    frequenciaPalavras[palavraFormatada]++;
                }
                else
                {
                    frequenciaPalavras[palavraFormatada] = 1;
                }
            }

            return frequenciaPalavras;
        }

        static string RemoverPontuacoes(string palavra)
        {
            return new string(palavra.Where(c => char.IsLetter(c)).ToArray());
        }
    }

}