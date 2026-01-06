
interface IDiscountable
{
    void ApplyDiscount();
    string GetDiscountDetails();
}

abstract class FoodItem
{
    protected string itemName;
    protected double price;
    protected int quantity;

    protected FoodItem(string name, double price, int qty)
    {
        itemName = name;
        this.price = price;
        quantity = qty;
    }

    public abstract double CalculateTotalPrice();
}

class VegItem : FoodItem, IDiscountable
{
    public VegItem(string name, double price, int qty) : base(name, price, qty) { }
    public override double CalculateTotalPrice() => price * quantity;
    public void ApplyDiscount() { }
    public string GetDiscountDetails() => "Veg Discount";
}

class NonVegItem : FoodItem
{
    public NonVegItem(string name, double price, int qty) : base(name, price, qty) { }
    public override double CalculateTotalPrice() => price * quantity * 1.1;
}
