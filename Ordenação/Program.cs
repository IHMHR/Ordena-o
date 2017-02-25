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

            Ordenações.Bolha(ref valores);

            foreach (var item in valores)
            {
                Console.Write(item);
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
    }
}
