using System;
class CheckNumbersArray{
static void Main(){
int[] a=new int[5];
for(int i=0;i<a.Length;i++) a[i]=int.Parse(Console.ReadLine());
for(int i=0;i<a.Length;i++){
if(a[i]>0){
if(a[i]%2==0) Console.WriteLine(a[i]+" is positive even");
else Console.WriteLine(a[i]+" is positive odd");
}else if(a[i]<0) Console.WriteLine("negative");
else Console.WriteLine("zero");
}
if(a[0]==a[4]) Console.WriteLine("First and last are equal");
else if(a[0]>a[4]) Console.WriteLine("First is greater");
else Console.WriteLine("Last is greater");
}}