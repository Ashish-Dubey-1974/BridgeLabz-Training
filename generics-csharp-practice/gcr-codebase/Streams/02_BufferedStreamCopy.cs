
using System;
using System.Diagnostics;
using System.IO;

class BufferedCopy
{
    static void Main()
    {
        byte[] buffer = new byte[4096];
        Stopwatch sw = new Stopwatch();

        using FileStream src = new FileStream("bigfile.dat", FileMode.Open);
        using FileStream dest = new FileStream("copy.dat", FileMode.Create);
        using BufferedStream bs = new BufferedStream(dest);

        sw.Start();
        int bytes;
        while ((bytes = src.Read(buffer, 0, buffer.Length)) > 0)
            bs.Write(buffer, 0, bytes);
        sw.Stop();

        Console.WriteLine("Buffered Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
