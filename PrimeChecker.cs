using System;

class PrimeChecker
{
    static bool isPrime(int n)
    {
        if (n == 2 || n == 3) {
            return true;
        }

        if (n <= 1 || n % 2 == 0) {
            return false;
        }
        
        double limit = Math.Floor(Math.Sqrt(n));
        
        for (int i = 3; i < limit; i+=2) {
            if (n % i == 0)
                return false;
        }
 
        return true;
    }
    
    static void Main()
    {
        int number = 111;

        Console.WriteLine(((isPrime(number)) ? "True" : "False"));
    }
}