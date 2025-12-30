using System;
class FriendsInfo
{
    static void Main()
    {
        int aAge = int.Parse(Console.ReadLine());
        int aHt = int.Parse(Console.ReadLine());
        int bAge = int.Parse(Console.ReadLine());
        int bHt = int.Parse(Console.ReadLine());
        int cAge = int.Parse(Console.ReadLine());
        int cHt = int.Parse(Console.ReadLine());

        int minAge = Math.Min(aAge, Math.Min(bAge,cAge));
        int maxHt = Math.Max(aHt, Math.Max(bHt,cHt));

        if(minAge==aAge) Console.WriteLine("Amar");
        else if(minAge==bAge) Console.WriteLine("Akbar");
        else Console.WriteLine("Anthony");

        if(maxHt==aHt) Console.WriteLine("Amar");
        else if(maxHt==bHt) Console.WriteLine("Akbar");
        else Console.WriteLine("Anthony");
    }
}