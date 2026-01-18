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
            QuickSort(items,0,items.Count-1);
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
        void QuickSort(IList<Ecommerce> items,int low,int high){
            if (low < high)
            {
                int pivot = Partition(items, low, high);
                QuickSort(items, low, pivot - 1);
                QuickSort(items, pivot + 1, high);
            }
        }

        int Partition(IList<Ecommerce> items, int low, int high)
        {
            double pivot = items[high].GetDiscountedAmount();
            int idx = low;
            for(int i = low; i < high; i++)
            {
                if (items[i].GetDiscountedAmount() > pivot)
                {
                    Ecommerce tempp = items[i];
                    items[i] = items[idx];
                    items[idx] = tempp;
                    idx++;
                }

            }
            Ecommerce temp = items[idx];
            items[idx] = items[high];
            items[high] = temp;
            return idx;
        }
    }
}