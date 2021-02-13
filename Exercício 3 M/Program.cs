using System;

namespace Exercício_3_M
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a;

            int n = int.Parse(Console.ReadLine());

            a = new int[n, n];

            int maior = 0;

            for(int l=0;l<n;l++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                for(int c= 0;c<n;c++ )
                {
                    a[l, c] = int.Parse(vetor[c]);
                }
            }

            Console.WriteLine();
            for (int l = 0; l < n; l++)
            {
                
                for (int c = 0; c < n; c++)
                {
                    if (maior == 0)
                    {
                        maior = a[l, c];
                    }
                    else if (maior < a[l,c])
                    {
                        maior = a[l, c];
                    }
                }

                Console.WriteLine(maior);
                maior = 0;

            }
        }
    }
}
