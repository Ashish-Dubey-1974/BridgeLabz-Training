using System;
namespace BikeDetails
{
    class Program
    {
        public static void Main()
        {
            BikeUtility obj = new BikeUtility();
            do
            {
                Console.WriteLine("-----------Home Page------------");
                Console.WriteLine("Press 1. To Add Bike");
                Console.WriteLine("Press 2. Group Bikes By Brands");
                Console.WriteLine("Press 3 To Exit");
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.Write("Enter Bike Model : ");
                    string m = Console.ReadLine();
                    Console.Write("Enter The Bike Brand : ");
                    string b = Console.ReadLine();
                    Console.Write("Enter Bike Price : ");
                    double p = double.Parse(Console.ReadLine());
                    obj.AddBikeDetails(m,b,p);
                }
                else if(input == 2)
                {
                    obj.ShowBikesBrands();
                }
                else if(input ==3)return;
                else Console.WriteLine("Invalid Input");
            }while(true);
        }
    }
}
