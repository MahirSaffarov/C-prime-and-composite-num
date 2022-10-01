using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        int num = 82981;

            if (num == 2 || num == 3 || num == 5 || num == 7)
                Console.WriteLine("This is prime number");
            else if (num == 1)
                Console.WriteLine("1 is neither prime nor composite");
            else if (num % 2 == 0 || num % 3 == 0 || num % 5 == 0 || num % 7 == 0)
                Console.WriteLine("This is composite number");
            else
                Console.WriteLine("This is prime number");

        }

        
    }
}
