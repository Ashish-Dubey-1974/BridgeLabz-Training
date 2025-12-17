// package core-java-practice.gcr-codebase.programming-elements;
import java.util.*;
public class primeNumber {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int number = sc.nextInt();
        sc.close();
        number = Math.abs(number);
        if(number<2){
            System.out.print("Not Prime");
        }
        else if (number==2){
            System.out.println("Prime");
        }else{
            for(int i=2;i*i<=number;i++){
                if(number%i==0){
                    System.out.println("Not Prime");
                    return;
                }
            }System.out.print("Prime");
        }
    }
}
