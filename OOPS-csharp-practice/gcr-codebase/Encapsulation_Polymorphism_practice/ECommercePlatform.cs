
interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

abstract class Product
{
    private int productId;
    private string name;
    protected double price;

    protected Product(int id, string name, double price)
    {
        this.productId = id;
        this.name = name;
        this.price = price;
    }

    public abstract double CalculateDiscount();
}

class Electronics : Product, ITaxable
{
    public Electronics(int id, string name, double price) : base(id, name, price) { }
    public override double CalculateDiscount() => price * 0.1;
    public double CalculateTax() => price * 0.18;
    public string GetTaxDetails() => "18% GST";
}

class Clothing : Product
{
    public Clothing(int id, string name, double price) : base(id, name, price) { }
    public override double CalculateDiscount() => price * 0.2;
}

class Groceries : Product
{
    public Groceries(int id, string name, double price) : base(id, name, price) { }
    public override double CalculateDiscount() => price * 0.05;
}
