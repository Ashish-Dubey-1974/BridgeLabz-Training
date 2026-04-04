using System;
class CircularTour
{
    static void Main()
    {
        int[] p={4,6,7,4};
        int[] d={6,5,3,5};
        int start=0,bal=0,def=0;
        for(int i=0;i<p.Length;i++)
        {
            bal+=p[i]-d[i];
            if(bal<0){start=i+1;def+=bal;bal=0;}
        }
        Console.WriteLine(bal+def>=0?start:-1);
    }
}