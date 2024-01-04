namespace ListaLogicaProgramacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            
            ConsoleKeyInfo teclaUsuario;
            do
            {
                Console.WriteLine("BEM VINDO A MINHA LISTA DE EXERCICIO!\nAperte ENTER para começarmos!\n");
                teclaUsuario = Console.ReadKey();

            } while (teclaUsuario.Key != ConsoleKey.Enter);

            bool sair = false;
            do
            {                     

                string[] opcoesUsuario = { "1. Convertersor de Temperatura","2. Verificar Primo","3. Calcular o fatorial", "4. Ordenar sequência de números", "5. Descobrir palíndromo", 
                    "6. Calcular raiz quadrada","7. Converter real para dòlar", "8. Validar senha","9. Validar CPF","10. Contador de palavras", "11. Sair" };

                var menuPrincipal = new Interface.Menu<string>(opcoesUsuario);
                int selecaoUsuario = menuPrincipal.ShowMenu();

                switch (selecaoUsuario)
                {
                    case 0:
                        ConversorTemperatura.MenuSelecao();
                        break;
                    case 1:
                        Primo.E_Primo();
                        break;
                    case 2:
                        Fatorial.CalculoFatorial();
                        break;
                    case 3:
                        Ordem.OrdemCrescente();
                        break;
                    case 4:
                        Palindromo.E_Palindromo();
                        break;
                    case 5:
                        Raiz.CalcularRaiz();
                        break;
                    case 6:
                        Dolar.CalcularValorDolar();
                        break;
                    case 7:
                        sair = true;
                        break;
                }
                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();
            } while (!sair);
        }
    }
}
