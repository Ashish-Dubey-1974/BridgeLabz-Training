
using System;
class Friends
{
    public static void Main()
    {
        int[] age=new int[3];
        int[] height=new int[3];
        for(int i=0;i<3;i++){
            age[i]=int.Parse(Console.ReadLine());
            height[i]=int.Parse(Console.ReadLine());
        }
        Console.WriteLine(Youngest(age));
        Console.WriteLine(Tallest(height));
    }
    static int Youngest(int[] a){
        return Math.Min(a[0],Math.Min(a[1],a[2]));
    }
    static int Tallest(int[] h){
        return Math.Max(h[0],Math.Max(h[1],h[2]));
    }
}
