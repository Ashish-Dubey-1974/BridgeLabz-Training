
interface IRentable
{
    double CalculateRent(int days);
}

abstract class Vehicle
{
    protected string vehicleNumber;
    protected double ratePerDay;

    protected Vehicle(string number, double rate)
    {
        vehicleNumber = number;
        ratePerDay = rate;
    }

    public abstract double CalculateRent(int days);
}

class Bike : Vehicle, IRentable
{
    public Bike(string number, double rate) : base(number, rate) { }

    public override double CalculateRent(int days)
    {
        return ratePerDay * days;
    }
}

class Car : Vehicle, IRentable
{
    public Car(string number, double rate) : base(number, rate) { }

    public override double CalculateRent(int days)
    {
        return ratePerDay * days * 1.2;
    }
}

class Truck : Vehicle, IRentable
{
    public Truck(string number, double rate) : base(number, rate) { }

    public override double CalculateRent(int days)
    {
        return ratePerDay * days * 1.5;
    }
}

class Customer
{
    public string Name { get; set; }

    public Customer(string name)
    {
        Name = name;
    }
}
