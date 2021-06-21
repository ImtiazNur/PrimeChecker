using System;

class PrimeChecker
{
    static bool isPrime(int n)
    {
        if (n == 2 || n == 3) {
            return true;
        }

        // if (n <= 1 || n % 2 == 0) {
        //     return false;
        // }


        if (n <= 1 || n % 2 == 0 || n % 3 == 0) {
            return false;
        }
        
        int limit = (int)Math.Floor(Math.Sqrt(n));
        
        // for (int i = 3; i < limit; i+=2) {
        //     if (n % i == 0)
        //         return false;
        // }

        for (int i = 5; i <= limit; i += 6) {
            if (n % i == 0 || n % (i + 2) == 0)
                return false;
        }
 
        return true;
    }
    
    static void Main()
    {
        int number = 113;

        Console.WriteLine(((isPrime(number)) ? "True" : "False"));
    }
}

// Resources:
// 1. https://en.wikipedia.org/wiki/Primality_test