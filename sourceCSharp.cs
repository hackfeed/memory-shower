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
                Console.WriteLine($" Диск {d.Name}");
                Console.WriteLine($"  Название раздела        : {d.VolumeLabel}");
                Console.WriteLine($"  Файловая система        : {d.DriveFormat}");
                Console.WriteLine(
                   $"  Доступно места на диске : {d.TotalFreeSpace} байт,\n" +
                   $"                            {Rounder(d.TotalFreeSpace / Powder(2,10))} кбайт,\n" +
                   $"                            {Rounder(d.TotalFreeSpace / Powder(2,20))} мбайт,\n" +
                   $"                            {Rounder(d.TotalFreeSpace / Powder(2,30))} гбайт.");
                Console.WriteLine(
                   $"  Занято места на диске   : {d.TotalSize - d.TotalFreeSpace} байт,\n" +
                   $"                            {Rounder((d.TotalSize - d.TotalFreeSpace) / Powder(2,10))} кбайт,\n" +
                   $"                            {Rounder((d.TotalSize - d.TotalFreeSpace) / Powder(2,20))} мбайт,\n" +
                   $"                            {Rounder((d.TotalSize - d.TotalFreeSpace) / Powder(2,30))} гбайт.");
                Console.WriteLine(
                   $"  Полный размер диска     : {d.TotalSize} байт,\n" +
                   $"                            {Rounder(d.TotalSize / Powder(2,10))} кбайт,\n" +
                   $"                            {Rounder(d.TotalSize / Powder(2,20))} мбайт,\n" +
                   $"                            {Rounder(d.TotalSize / Powder(2,30))} гбайт.");
                Console.WriteLine(" ---------------------------------------------------------------");
            }
        }
        Console.WriteLine();
        Console.WriteLine(" Нажмите любую клавишу для выхода из программы...");
        Console.ReadKey();
    }

    private static double Powder(double a, double b) => Math.Pow(a, b);
    private static double Rounder(double a) => Math.Round(a, 1);
}