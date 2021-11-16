using System;

namespace BEOPM4_02_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random numbers
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            Console.WriteLine(rnd1.Next());
            Console.WriteLine(rnd2.Next());

            //Same seed gives same random number sequence
            rnd1 = new Random(1234);
            rnd2 = new Random(1234);
            Console.WriteLine();
            Console.WriteLine(rnd1.Next());
            Console.WriteLine(rnd2.Next());

            //Get random double between 0 and 1
            Console.WriteLine(rnd1.NextDouble());

            //Get a random byte sequence
            Random rnd = new Random();
            Byte[] b = new Byte[10];
            rnd.NextBytes(b);
            Console.WriteLine("\nThe Random bytes are: ");
            for (int i = 0; i < b.Length; i++)
                Console.Write($"{b[i]} ");

            Console.WriteLine();
        }
    }
}
