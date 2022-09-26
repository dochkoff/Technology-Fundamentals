using System;

namespace P10_PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int originalValueN = N;
            int pokedTargets = 0;

            while (N >= M)
            {
                N -= M;
                pokedTargets++;

                if (N==originalValueN/2)
                {
                    N /= Y;
                }
            }

            Console.WriteLine(N);
            Console.WriteLine(pokedTargets);
        }
    }
}
