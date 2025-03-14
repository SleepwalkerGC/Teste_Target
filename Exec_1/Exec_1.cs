using System;

namespace Exec_1
{
    internal class Exec_1
    {
        static void Main(string[] args)
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine("O valor final de SOMA é: " + SOMA);
            Console.ReadKey();
        }
    }
}
