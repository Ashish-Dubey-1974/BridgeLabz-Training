
using System;
using System.IO;

class FileReadWrite
{
    static void Main()
    {
        string source = "source.txt";
        string dest = "destination.txt";

        try
        {
            if (!File.Exists(source))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            using FileStream fsRead = new FileStream(source, FileMode.Open);
            using FileStream fsWrite = new FileStream(dest, FileMode.Create);

            fsRead.CopyTo(fsWrite);
            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
