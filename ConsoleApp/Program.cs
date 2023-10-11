using System;

class Program
{
    static void Main()
    {
        int n = 100;
        bool[] primes = SieveOfEratosthenes(n);

        Console.WriteLine($"Liczby pierwsze w przedziale od 2 do {n}:");

        for (int i = 2; i <= n; i++)
        {
            if (primes[i])
            {
                Console.Write($"{i}, ");
            }
        }

        Console.WriteLine("\nWszystkie liczby pierwsze zostały podane, naciśnij przycisk by zakończyć program.");
        Console.ReadKey();
    }

    static bool[] SieveOfEratosthenes(int n)
    {
        bool[] primes = new bool[n + 1];
        for (int i = 2; i <= n; i++)
        {
            primes[i] = true;
        }

        for (int i = 2; i * i <= n; i++)
        {
            if (primes[i])
            {
                for (int j = i * i; j <= n; j += i)
                {
                    primes[j] = false;
                }
            }
        }

        return primes;
    }
}
