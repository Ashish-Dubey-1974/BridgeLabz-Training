using System;
class Handshakes
{
    public static void Main()
    {
        int students = int.Parse(Console.ReadLine());
        int handshakes = (students * (students - 1)) / 2;
        Console.WriteLine($"The maximum number of handshakes possible are {handshakes}");
    }
}