using System;
using System.IO;

class MemShow
{
    public static void Main()
    {
        Console.Title = "MemInspector v2.0";
        Console.WriteLine();
        DriveInfo[] allDrives = DriveInfo.GetDrives();

        foreach (DriveInfo d in allDrives)
        {
            if (d.IsReady)
            {
                Console.WriteLine(" Диск {0}", d.Name);
                Console.WriteLine("  Название раздела        : {0}", d.VolumeLabel);
                Console.WriteLine("  Файловая система        : {0}", d.DriveFormat);
                Console.WriteLine(
                    "  Доступно места на диске : {0} байт, {1} кбайт,\n " +
                    "                           {2} мбайт, {3} гбайт.",
                    d.TotalFreeSpace, d.TotalFreeSpace / 1024, d.TotalFreeSpace / 1048576, d.TotalFreeSpace / 1073741824);
                Console.WriteLine(
                    "  Занято места на диске   : {0} байт, {1} кбайт,\n " +
                    "                           {2} мбайт, {3} гбайт.",
                    d.TotalSize - d.TotalFreeSpace, (d.TotalSize - d.TotalFreeSpace) / 1024,
                    (d.TotalSize - d.TotalFreeSpace) / 1048576,
                    (d.TotalSize - d.TotalFreeSpace) / 1073741824);
                Console.WriteLine(
                    "  Полный размер диска     : {0} байт, {1} кбайт,\n " +
                    "                           {2} мбайт, {3} гбайт.",
                    d.TotalSize, d.TotalSize / 1024, d.TotalSize / 1048576, d.TotalSize / 1073741824);
                Console.WriteLine(" ---------------------------------------------------------------");
            }
        }
        Console.WriteLine();
        Console.WriteLine(" Нажмите любую клавишу для выхода из программы...");
        Console.ReadKey();
    }
}
