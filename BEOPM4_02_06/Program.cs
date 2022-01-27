﻿using System;
using System.IO;

namespace BEOPM4_02_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop through all special folders
            Console.WriteLine("Special Folder exploration");
            foreach (Environment.SpecialFolder val in typeof(Environment.SpecialFolder).GetEnumValues())
            {
                Console.WriteLine($"{val, -25} {Environment.GetFolderPath(val)}");
            }
            Console.WriteLine();
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            Console.WriteLine();
            
            
            //Explore the Path class
            Console.WriteLine("\nPath exploration");
            Console.WriteLine($"Volume separator:  {Path.VolumeSeparatorChar}");
            Console.WriteLine($"Path separator:    {Path.PathSeparator}");
            Console.WriteLine($"Dir separator:     {Path.PathSeparator}");

            
            Console.WriteLine();
            Console.WriteLine($"Invalid file name char: {new string(Path.GetInvalidFileNameChars())}");
            
            string pwd = Directory.GetCurrentDirectory();
            Console.WriteLine();
            Console.WriteLine($"Current directory: {pwd}");
            Console.WriteLine($"Current root:      {Path.GetPathRoot(pwd)}");

            string mylog = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "mylog.txt");
            Console.WriteLine(  );
            Console.WriteLine($"Full Path name:    {Path.GetFullPath(mylog)}");
            Console.WriteLine($"Directory name:    {Path.GetDirectoryName(mylog)}");
            Console.WriteLine($"File name:         {Path.GetFileName(mylog)}");
            Console.WriteLine($"File ext:          {Path.GetExtension(mylog)}");
        }
    }
}
