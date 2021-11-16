using System;
using System.IO;

namespace BEOPM4_02_10
{
    class Program
    {
        static void Main(string[] args)
        {
			foreach (DriveInfo d in DriveInfo.GetDrives())
			{
				Console.WriteLine();
				Console.WriteLine(d.Name);             
				Console.WriteLine(d.DriveType);        
				Console.WriteLine(d.RootDirectory);    

				if (d.IsReady)
				{
					Console.WriteLine(d.VolumeLabel);   
					Console.WriteLine(d.DriveFormat);   
					Console.WriteLine($"{d.TotalSize:N0}");
					Console.WriteLine($"{d.TotalFreeSpace:N0}");
					Console.WriteLine($"{d.AvailableFreeSpace:N0}");
				}
			}
		}
    }
}
