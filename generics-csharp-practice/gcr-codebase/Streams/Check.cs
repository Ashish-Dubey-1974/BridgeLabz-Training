using System.IO;
class Check
{
    public static void Main()
    {
        using(StreamWriter writer = new StreamWriter("file.txt",true))
        {
            writer.WriteLine("Hello Ashish Dubey...");
            writer.WriteLine("This is Second time Line");
            writer.Flush();
            Thread.Sleep(10000);
        }        
    }
}