using System;
using System.IO;

namespace BEOPM4_02_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string pwd = Directory.GetCurrentDirectory();
            Console.WriteLine($"Current directory: {pwd}");
            Console.WriteLine($"Parent directory: {Directory.GetParent(pwd)}");
            Console.WriteLine($"Current root:     {Directory.GetDirectoryRoot(pwd)}");

            Console.WriteLine($"\nGet logical drives");
            foreach (var item in Directory.GetLogicalDrives())
            {
                Console.WriteLine(item);
            }

            pwd = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine($"\nGet Directories in {pwd}");
            foreach (var item in Directory.GetDirectories(pwd))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nGet Files in {pwd}");
            foreach (var item in Directory.GetFiles(pwd))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nGet FileSystemEntries in {pwd}");
            foreach (var item in Directory.GetFileSystemEntries(pwd))
            {
                Console.WriteLine(item);
            }
        }
    }
}
