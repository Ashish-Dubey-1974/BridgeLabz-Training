using System;
public class primeNumber {
    public static void Main(string[] args) {
        int number = int.Parse(Console.ReadLine());
        number = Math.Abs(number);
        if(number<2){
            Console.WriteLine("Not Prime");
        }
        else if (number==2){
            Console.WriteLine("Prime");
        }else{
            for(int i=2;i*i<=number;i++){
                if(number%i==0){
                    Console.WriteLine("Not Prime");
                    return;
                }
            }Console.WriteLine("Prime");
        }
    }
}
