using System;
using System.Text;
using System.IO;

namespace BEOPM4_02_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string aBookFileName = fname("aBook.txt");

            // Use string builder to create a book with 1000 sentences
            string strSentence = "The quick brown fox catches the white rabbit\n";
            StringBuilder sbBook = new StringBuilder();
            for (int i = 0; i < 100_000; i++)
            {
                sbBook.AppendLine(strSentence);
            }

            //First 100_000 lines then append another 100_000 in Unicode encoding
            File.WriteAllText(aBookFileName, sbBook.ToString(), Encoding.Unicode);
            File.AppendAllText(aBookFileName, sbBook.ToString(), Encoding.Unicode);

            Console.WriteLine("Create a large text file");
            Console.WriteLine(aBookFileName);
            Console.WriteLine($"Exists: {File.Exists(aBookFileName)}"); // True

            
            //Copy the text file
            string aBookCopy = $"{Path.GetFileNameWithoutExtension(aBookFileName)}_copy{Path.GetExtension(aBookFileName)}";
            aBookCopy = Path.Combine(Path.GetDirectoryName(aBookFileName), aBookCopy);

            Console.WriteLine("\nCopy the text file");
            Console.WriteLine(aBookCopy);
            File.Copy(aBookFileName, aBookCopy, true);
            Console.WriteLine($"Exists: {File.Exists(aBookCopy)}"); // True
            
            //Set the attributes of the copy to read only
            FileAttributes fa = File.GetAttributes(aBookFileName);
            fa = fa | FileAttributes.ReadOnly;  //Set the readonly flag using bitwise Or
            
            File.SetAttributes(aBookFileName, fa);

            //Toggle to reset the readonly flag
            fa ^= FileAttributes.ReadOnly;  //Toggle the Readonly flag using bitwise Xor
            File.SetAttributes(aBookFileName, fa);

            
            //Delete the Original
            File.Delete(aBookFileName);
            Console.WriteLine("\nDelete the text file");
            Console.WriteLine(aBookFileName);
            Console.WriteLine($"Exists: {File.Exists(aBookFileName)}"); // True

            //Read file and timestamps
            Console.WriteLine(aBookCopy);
            StringBuilder sbBookCopy = new StringBuilder(File.ReadAllText(aBookCopy, Encoding.Unicode));

            Console.WriteLine($"CreationTime: {File.GetCreationTime(aBookCopy)}");
            Console.WriteLine($"LastWriteTime: {File.GetLastWriteTime(aBookCopy)}");
            Console.WriteLine($"LastAccessTime: {File.GetLastAccessTime(aBookCopy)}");
            
        }

        static string fname(string name)
        {
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            documentPath = Path.Combine(documentPath, "BEOPM4", "Examples");

            if (!Directory.Exists(documentPath)) Directory.CreateDirectory(documentPath);
            return Path.Combine(documentPath, name);
        }
    }
}
