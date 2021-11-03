using System;

namespace BEOPM4_02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double aDoubl = 0.43D;
            float aSingl = 0.43F;
            long aLong = 43;
            int anInt = 43;
            short aShort = 43;
            char aChar = '*';
            bool aBool = true;

            Console.WriteLine($"{"argument", 25}{"byte array",30}");
            Console.WriteLine($"{"--------", 25}{"----------",30}");

            // Convert values to Byte arrays and display them.
            Console.WriteLine($"{aDoubl, 25}{BitConverter.ToString(BitConverter.GetBytes(aDoubl)),30}");
            Console.WriteLine($"{aSingl,25}{BitConverter.ToString(BitConverter.GetBytes(aSingl)),30}");
            Console.WriteLine($"{aLong,25}{BitConverter.ToString(BitConverter.GetBytes(aLong)),30}");
            Console.WriteLine($"{anInt,25}{BitConverter.ToString(BitConverter.GetBytes(anInt)),30}");
            Console.WriteLine($"{aShort,25}{BitConverter.ToString(BitConverter.GetBytes(aShort)),30}");
            Console.WriteLine($"{aChar,25}{BitConverter.ToString(BitConverter.GetBytes(aChar)),30}");
            Console.WriteLine($"{aBool,25}{BitConverter.ToString(BitConverter.GetBytes(aBool)),30}");

            //Decimal you can get to int[] to get binary representation
            int[] decimalBits = decimal.GetBits(0.43M);

            //DateTime you can get to long to get binary representation
            long DateTimeBits = DateTime.Now.ToBinary();

        }
    }
}
