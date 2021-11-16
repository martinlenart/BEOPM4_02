﻿using System;

namespace BEOPM4_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversion converts between all base types, even if it is not obvious.
            int i1 = Convert.ToInt32(4.5M);
            Console.WriteLine(i1);              //4 due to bankers rounding

            int i2 = Convert.ToInt32(5.5F);
            int i = (int)5.5M;
            Console.WriteLine(i);
            Console.WriteLine(i2);              //6 due to bankers rounding
            
            int i3 = Convert.ToInt32(false);
            Console.WriteLine(i3);              //0 numeric representation of false

            Console.WriteLine(Convert.ToInt32("1E", 16));    //30 Parsed in hexadecimal
            Console.WriteLine(Convert.ToUInt32("17", 8));    //15 Parsed in base 8
            Console.WriteLine(Convert.ToUInt32("101", 2));   //5 Parsed in binary

            //Base-64 conversion
            
            //Step 1: Original
            //Either a string with strange characters or already a byte[], perhaps an image
            string strOrigin = "This could be a hash key representing a strong password";
            byte[] bytesOrigin = System.Text.Encoding.UTF8.GetBytes(strOrigin);
            Console.WriteLine();
            Console.WriteLine(strOrigin);

            //Step2: Convert to Base64:
            //Convert to either a Base64 char[] or Base64 string. I demonstrate both
            string strBase64 = Convert.ToBase64String(bytesOrigin);

            char[] charsBase64 = new char[strBase64.Length];
            Convert.ToBase64CharArray(bytesOrigin,0,bytesOrigin.Length, charsBase64, 0);
            Console.WriteLine(strBase64); //The text representation of the string, byte[] or image

            //Step3: Convert back to byte[] or string
            //First the Base64 string
            byte[] bytesConverted = Convert.FromBase64String(strBase64);
            string stringConverted = System.Text.Encoding.UTF8.GetString(bytesConverted);
            Console.WriteLine(stringConverted);

            //Demonstrate the same but from the Base64 char[]
            bytesConverted = Convert.FromBase64CharArray(charsBase64, 0, charsBase64.Length);
            stringConverted = System.Text.Encoding.UTF8.GetString(bytesConverted);
            Console.WriteLine(stringConverted);
        }
    }
}
