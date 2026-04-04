namespace FlashDealz
{
    internal class Menu
    {
        public static void Display()
        {
            IEcommerce item = new Utility();
            bool Switched_off = false;
            do
            {
                Console.WriteLine("\n-----------> Home Page <------------");
                Console.WriteLine("Press 1. To Add Items ");
                Console.WriteLine("Press 2. Display All Items ");
                Console.WriteLine("Press 3. To Exit");
                Console.Write("Choose     ======>         ");
                int input = int.Parse(Console.ReadLine());
                if(input==1)item.AddItem();
                else if(input==2)item.DisplayAll();
                else if(input==3)Switched_off=true;
                
            }while(!Switched_off);

        }
    }
}