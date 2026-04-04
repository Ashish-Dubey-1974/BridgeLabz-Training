
interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

abstract class Vehicle
{
    private string vehicleNumber;
    protected double rentalRate;

    protected Vehicle(string number, double rate)
    {
        vehicleNumber = number;
        rentalRate = rate;
    }

    public abstract double CalculateRentalCost(int days);
}

class Car : Vehicle, IInsurable
{
    public Car(string no, double rate) : base(no, rate) { }
    public override double CalculateRentalCost(int days) => rentalRate * days;
    public double CalculateInsurance() => 500;
    public string GetInsuranceDetails() => "Car Insurance";
}

class Bike : Vehicle
{
    public Bike(string no, double rate) : base(no, rate) { }
    public override double CalculateRentalCost(int days) => rentalRate * days;
}

class Truck : Vehicle, IInsurable
{
    public Truck(string no, double rate) : base(no, rate) { }
    public override double CalculateRentalCost(int days) => rentalRate * days * 1.5;
    public double CalculateInsurance() => 1000;
    public string GetInsuranceDetails() => "Truck Insurance";
}
