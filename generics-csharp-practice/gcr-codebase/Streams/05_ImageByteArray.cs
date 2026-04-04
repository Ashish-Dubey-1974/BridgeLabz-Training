
using System;
using System.IO;

class ImageBytes
{
    static void Main()
    {
        byte[] data = File.ReadAllBytes("img.jpg");
        File.WriteAllBytes("copy.jpg", data);
        Console.WriteLine("Image copied successfully.");
    }
}
