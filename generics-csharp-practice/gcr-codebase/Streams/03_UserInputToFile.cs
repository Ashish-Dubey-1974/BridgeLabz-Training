
using System;
using System.IO;

class UserInput
{
    static void Main()
    {
        try
        {
            using StreamWriter sw = new StreamWriter("user.txt");
            Console.Write("Name: ");
            sw.WriteLine(Console.ReadLine());
            Console.Write("Age: ");
            sw.WriteLine(Console.ReadLine());
            Console.Write("Language: ");
            sw.WriteLine(Console.ReadLine());
            Console.WriteLine("Saved successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
