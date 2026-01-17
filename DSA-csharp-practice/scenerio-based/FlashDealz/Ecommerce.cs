namespace FlashDealz{
    internal class Ecommerce
    {
        string ItemName;
        double DiscountPercentage;
        double Amount;
        double DiscountAmount;

        public Ecommerce(string name,double percent,double amount)
        {
            ItemName=name;
            DiscountPercentage=percent;
            Amount=amount;
            DiscountAmount = (amount*percent)/100;
        }
        public double GetDiscountedAmount()
        {
            return DiscountAmount;
        }

        public override string ToString()
        {
            return $"Item name : {ItemName}\nDiscounted Percentage : {DiscountPercentage}\nAmount : {Amount}\nDiscounted Amount : {DiscountAmount}";
        }
    }
}