using System;
class FriendsAgeHeight{
    static void Main(){
        int[] age=new int[3];
        double[] height=new double[3];
        for(int i=0;i<3;i++){
            age[i]=int.Parse(Console.ReadLine());
            height[i]=double.Parse(Console.ReadLine());
        }
        int minAge=age[0];
        double maxHeight=height[0];
        for(int i=1;i<3;i++){
            if(age[i]<minAge) minAge=age[i];
            if(height[i]>maxHeight) maxHeight=height[i];
        }
        Console.WriteLine(minAge);
        Console.WriteLine(maxHeight);
    }
}