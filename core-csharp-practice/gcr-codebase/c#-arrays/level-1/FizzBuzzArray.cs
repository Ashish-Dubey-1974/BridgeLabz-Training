using System;
class FizzBuzzArray{
    static void Main(){
        int n=int.Parse(Console.ReadLine());
        if(n<=0) return;
        string[] a=new string[n+1];
        for(int i=0;i<=n;i++){
            if(i%3==0 && i%5==0) a[i]="FizzBuzz";
            else if(i%3==0) a[i]="Fizz";
            else if(i%5==0) a[i]="Buzz";
            else a[i]=i.ToString();
        }
        for(int i=0;i<=n;i++) Console.WriteLine("Position "+i+" = "+a[i]);
    }
}