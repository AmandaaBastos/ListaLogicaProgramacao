using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLogicaProgramacao
{
    internal class CPF
    {

    public static void ValidarCPF()
        {
            Console.WriteLine("Digite o CPF:");
            string cpf = Console.ReadLine();

            int[] cpfDigitos = new int[11];

            for (int i = 0; i < 11; i++)
            {
                cpfDigitos[i] = Convert.ToInt32(Convert.ToString(cpf[i]));
            }

            bool resultado = ValidaDigitoVerificador(cpfDigitos);

            if (ValidarInput(cpf) && resultado)
            {
                Console.WriteLine("CPF válido!");
            }
            else
            {
                Console.WriteLine("CPF inválido!");
            }
        }
        static bool ValidarInput(string cpf)
        {
            if (cpf.Length != 11)
            {
                return false;
            }
            if (!IsNumeric(cpf))
            {
                return false;
            }
            return true;
        }
        static bool IsNumeric(string cpf)
        {
            foreach (char c in cpf)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        static bool ValidaDigitoVerificador(int[] num)
        {
            int i, j, soma, resto, dv1, dv2;

            // Dígito verificador 1
            soma = 0;
            j = 10;

            for (i = 0; i < 9; i++)
            {
                soma += num[i] * j;
                j -= 1;
            }

            resto = soma % 11;

            if (resto < 2)
            {
                dv1 = 0;
            }
            else
            {
                dv1 = 11 - resto;
            }

            // Dígito verificador 2
            soma = 0;
            j = 11;

            for (i = 0; i < 10; i++)
            {
                soma += num[i] * j;
                j -= 1;
            }

            resto = soma % 11;

            if (resto < 2)
            {
                dv2 = 0;
            }
            else
            {
                dv2 = 11 - resto;
            }

            // Verificção final
            if (num[9] == dv1 && num[10] == dv2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }        
    }
}
