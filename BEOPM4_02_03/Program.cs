using System;
using System.Numerics;

namespace BEOPM4_02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a few BigIntegers
            BigInteger normalint = long.MaxValue;     
            BigInteger googol1 = BigInteger.Pow(10, 100); // 10E100
            BigInteger googol2 = BigInteger.Parse("1".PadRight(101, '0'));

            Console.WriteLine(normalint);
            Console.WriteLine(googol1);
            Console.WriteLine(googol2);

            //use some of BigIntegers members
            Console.WriteLine();
            Console.WriteLine(googol1 + googol2);
            Console.WriteLine(googol1 * googol2);
            Console.WriteLine();
            Console.WriteLine(googol1 - googol2);
            Console.WriteLine(googol1 / googol2);

            Console.WriteLine();
            Console.WriteLine(googol2.GetBitLength());
            Console.WriteLine(googol2.GetByteCount());
            Console.WriteLine(googol2.IsPowerOfTwo);
            Console.WriteLine(googol2.IsEven);


            //Generate a huge random integer in a BigInteger
            Console.WriteLine();
            var rnd = new Random();
            byte[] bytes = new byte[googol2.GetByteCount()];    // similar size a googol
            rnd.NextBytes(bytes);
            var bigRandomNumber = new BigInteger(bytes);  
            Console.WriteLine(bigRandomNumber);

            //Demonstrate division and reminder
            Console.WriteLine(bigRandomNumber / 2);
            Console.WriteLine(bigRandomNumber % 2);

        }
    }
}
