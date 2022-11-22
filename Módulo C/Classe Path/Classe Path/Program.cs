using System;
using System.IO;

namespace Classe_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\LucasSilva-AfixCode\Documents\Arquivo_Path.txt";

            Console.WriteLine($"DirectorySeparatorChar: {Path.DirectorySeparatorChar}");
            Console.WriteLine($"PathSeparator: {Path.PathSeparator}");
            Console.WriteLine($"GetDirectoryName: {Path.GetDirectoryName(path)}");
            Console.WriteLine($"GetFileName: {Path.GetFileName(path)}");
            Console.WriteLine($"GetExtension: {Path.GetExtension(path)}");
            Console.WriteLine($"GetFullPath: {Path.GetFullPath(path)}");
            Console.WriteLine($"GetTempPath: {Path.GetTempPath()}");

            //GetPath possui uma gama de comandos...
        }
    }
}
