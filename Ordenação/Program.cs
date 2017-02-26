using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenação
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = { 5, 6, 4, 7, 3, 8, 1, 9, 0, 2 };

            Ordenações.Seleção(ref valores);

            foreach (var item in valores)
            {
                Console.Write(item);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }

    public static class Ordenações
    {
        public static void Bolha(ref int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[i] > vetor[j])
                    {
                        vetor[i] = vetor[i] ^ vetor[j];
                        vetor[j] = vetor[j] ^ vetor[i];
                        vetor[i] = vetor[i] ^ vetor[j];
                    }
                }
            }
        }

        public static void Inserção(ref int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                int atual = vetor[i];
                int j = i - 1;
                while ((j >= 0) && (atual < vetor[j]))
                {
                    vetor[j + 1] = vetor[j];
                    j--;
                }

                vetor[j + 1] = atual;
            }
        }

        public static void Seleção(ref int[] vetor)
        {
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                int menor = i;

                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[menor])
                    {
                        menor = j;
                    }
                }

                if (menor != i)
                {
                    vetor[i] = vetor[i] ^ vetor[menor];
                    vetor[menor] = vetor[menor] ^ vetor[i];
                    vetor[i] = vetor[i] ^ vetor[menor];
                }
            }
        }
    }
}
