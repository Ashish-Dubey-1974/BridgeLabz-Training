
using System;
class FormatEx
{
    static void Main()
    {
        try
        {
            int x=int.Parse("abc");
        }
        catch(Exception e)
        {
            Console.WriteLine(e.GetType().Name);
        }
    }
}
