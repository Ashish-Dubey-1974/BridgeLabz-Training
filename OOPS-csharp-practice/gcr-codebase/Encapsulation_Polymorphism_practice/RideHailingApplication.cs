
interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string location);
}

abstract class Vehicle
{
    private int vehicleId;
    protected string driverName;
    protected double ratePerKm;

    protected Vehicle(int id, string driver, double rate)
    {
        vehicleId = id;
        driverName = driver;
        ratePerKm = rate;
    }

    public abstract double CalculateFare(double distance);
}

class Car : Vehicle, IGPS
{
    private string location;
    public Car(int id, string driver, double rate) : base(id, driver, rate) { }
    public override double CalculateFare(double distance) => ratePerKm * distance;
    public string GetCurrentLocation() => location;
    public void UpdateLocation(string loc) { location = loc; }
}

class Bike : Vehicle
{
    public Bike(int id, string driver, double rate) : base(id, driver, rate) { }
    public override double CalculateFare(double distance) => ratePerKm * distance * 0.8;
}

class Auto : Vehicle
{
    public Auto(int id, string driver, double rate) : base(id, driver, rate) { }
    public override double CalculateFare(double distance) => ratePerKm * distance * 0.9;
}
