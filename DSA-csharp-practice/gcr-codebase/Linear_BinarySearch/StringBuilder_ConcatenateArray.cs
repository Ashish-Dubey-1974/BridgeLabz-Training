
using System;
using System.Text;

class ConcatStrings
{
    static void Main()
    {
        string[] arr = { "Hello", " ", "World", "!" };
        StringBuilder sb = new StringBuilder();

        foreach (string s in arr)
            sb.Append(s);

        Console.WriteLine(sb.ToString());
    }
}
