using System;

namespace Exec_5
{
    internal class Exec_5
    {
        static void Main(string[] args)
        {
            // Entrada da string (pode ser definida no código ou lida do usuário)
            Console.Write("Digite uma string: ");
            string input = Console.ReadLine();

            // Inversão da string
            string reversed = InverterString(input);

            // Exibição do resultado
            Console.WriteLine($"String invertida: {reversed}");
            Console.ReadKey();
        }

        static string InverterString(string str)
        {
            char[] caracteres = new char[str.Length];
            int j = 0;

            // Percorrer a string de trás para frente
            for (int i = str.Length - 1; i >= 0; i--)
            {
                caracteres[j] = str[i];
                j++;
            }

            // Criar uma nova string a partir do array de caracteres
            return new string(caracteres);
        }
    }
}
