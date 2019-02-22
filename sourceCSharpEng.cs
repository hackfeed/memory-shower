using System;
using System.IO;

class MemoryShower
{
    public static void Main()
    {
        Console.Title = "MemoryShower";
        Console.WriteLine();
        DriveInfo[] allDrives = DriveInfo.GetDrives();

        foreach (DriveInfo d in allDrives)
        {
            if (d.IsReady)
            {
                Console.WriteLine($" Drive {d.Name}");
                Console.WriteLine($"  Volume label            : {d.VolumeLabel}");
                Console.WriteLine($"  Drive filesystem        : {d.DriveFormat}");
                Console.WriteLine(
                   $"  Available disk space    : {d.TotalFreeSpace} B,\n" +
                   $"                            {Rounder(d.TotalFreeSpace / Powder(2,10))} KB,\n" +
                   $"                            {Rounder(d.TotalFreeSpace / Powder(2,20))} MB,\n" +
                   $"                            {Rounder(d.TotalFreeSpace / Powder(2,30))} GB.");
                Console.WriteLine(
                   $"  In use disk space       : {d.TotalSize - d.TotalFreeSpace} B,\n" +
                   $"                            {Rounder((d.TotalSize - d.TotalFreeSpace) / Powder(2,10))} KB,\n" +
                   $"                            {Rounder((d.TotalSize - d.TotalFreeSpace) / Powder(2,20))} MB,\n" +
                   $"                            {Rounder((d.TotalSize - d.TotalFreeSpace) / Powder(2,30))} GB.");
                Console.WriteLine(
                   $"  Total disk space        : {d.TotalSize} B,\n" +
                   $"                            {Rounder(d.TotalSize / Powder(2,10))} KB,\n" +
                   $"                            {Rounder(d.TotalSize / Powder(2,20))} MB,\n" +
                   $"                            {Rounder(d.TotalSize / Powder(2,30))} GB.");
                Console.WriteLine(" ---------------------------------------------------------------");
            }
        }
        Console.WriteLine();
        Console.WriteLine(" Press any key to exit...");
        Console.ReadKey();
    }

    private static double Powder(double a, double b) => Math.Pow(a, b);
    private static double Rounder(double a) => Math.Round(a, 1);
}