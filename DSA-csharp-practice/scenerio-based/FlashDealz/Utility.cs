using System.Collections;
namespace FlashDealz
{
    internal class Utility : IEcommerce
    {
        IList<Ecommerce> items = new List<Ecommerce>();
        public void AddItem()
        {
            Console.Write("\nEnter Item Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Amount : ");
            double amount = double.Parse(Console.ReadLine());
            Console.Write("Enter Discount Percentage : ");
            double percent = double.Parse(Console.ReadLine());
            items.Add(new Ecommerce(name, percent, amount));
            BubbleSort(items);
        }
        public void DisplayAll()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("-- No Item Present ");
                return;
            }
            Console.WriteLine("\n-------- Flash Dealz --------\n");
            foreach (var item in items)
            {
                Console.WriteLine(item);
                Console.WriteLine("----------------------------");
            }
        }
        void BubbleSort(IList<Ecommerce> items){
            int n = items.Count;
            for (int i = 0; i < n - 1; i++){
                for (int j = 0; j < n - i - 1; j++){
                    if (items[j].GetDiscountedAmount() < items[j+1].GetDiscountedAmount()){
                        var temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                    }
                }
            }
        }
    }
}