using System;
class PrimeCheck
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool flag = true;
        if(n<=1) flag = false;
        for(int i=2;i<n;i++)
        {
            if(n%i==0)
            {
                flag = false;
                break;
            }
        }
        if(flag) Console.WriteLine("Prime");
        else Console.WriteLine("Not Prime");
    }
}