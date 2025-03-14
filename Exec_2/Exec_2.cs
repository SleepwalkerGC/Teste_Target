using System;

namespace Exec_2
{
    internal class Exec_2
    {
            static void Main(string[] args)
            {
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                if (PertenceAFibonacci(numero))
                {
                    Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
                    Console.ReadKey();
                }
            }

            static bool PertenceAFibonacci(int numero)
            {
                if (numero < 0) return false;

                int a = 0, b = 1;

                // Verifica os valores da sequência até alcançar ou ultrapassar o número.
                while (a <= numero)
                {
                    if (a == numero) return true;

                    int temp = a;
                    a = b;
                    b = temp + b;
                }

                return false;
            }
        }
    }
