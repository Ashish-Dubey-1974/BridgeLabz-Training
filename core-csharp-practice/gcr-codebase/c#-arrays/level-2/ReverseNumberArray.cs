using System;
class ReverseNumberArray{
    static void Main(){
        int n=int.Parse(Console.ReadLine());
        int temp=n,count=0;
        while(temp!=0){
            count++;
            temp/=10;
        }
        int[] d=new int[count];
        for(int i=0;i<count;i++){
            d[i]=n%10;
            n/=10;
        }
        for(int i=0;i<count;i++) Console.WriteLine(d[i]);
    }
}