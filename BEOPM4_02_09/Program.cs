using System;
using System.IO;

namespace BEOPM4_02_09
{
	class Program
	{
		static void Main(string[] args)
		{
			FileInfo fi = new FileInfo(fname("temp.txt"));
			using (TextWriter w = fi.CreateText())
				w.Write("The quick brown fox catches the white rabbit\n");

			fi.Refresh();
			Console.WriteLine(fi.Exists);         // true
			Console.WriteLine(fi.Name);
			Console.WriteLine(fi.FullName);
			Console.WriteLine(fi.DirectoryName);
			Console.WriteLine(fi.Extension);

			string pwd = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			DirectoryInfo di = new DirectoryInfo(pwd);

			Console.WriteLine($"\nGet Directories in {di.Name}");
			foreach (var item in di.GetDirectories())
			{
				Console.WriteLine(item);
			}

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
