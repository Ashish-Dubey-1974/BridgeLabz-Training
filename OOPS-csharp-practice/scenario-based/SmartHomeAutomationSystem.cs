
interface IControllable
{
    void TurnOn();
    void TurnOff();
}

abstract class Appliance
{
    protected string name;

    protected Appliance(string name)
    {
        this.name = name;
    }

    public abstract void DisplayStatus();
}

class Light : Appliance, IControllable
{
    public Light(string name) : base(name) { }

    public void TurnOn()
    {
        System.Console.WriteLine(name + " light is turned ON with soft brightness");
    }

    public void TurnOff()
    {
        System.Console.WriteLine(name + " light is turned OFF");
    }

    public override void DisplayStatus()
    {
        System.Console.WriteLine("Light appliance: " + name);
    }
}

class Fan : Appliance, IControllable
{
    public Fan(string name) : base(name) { }

    public void TurnOn()
    {
        System.Console.WriteLine(name + " fan is spinning at medium speed");
    }

    public void TurnOff()
    {
        System.Console.WriteLine(name + " fan is turned OFF");
    }

    public override void DisplayStatus()
    {
        System.Console.WriteLine("Fan appliance: " + name);
    }
}

class AC : Appliance, IControllable
{
    public AC(string name) : base(name) { }

    public void TurnOn()
    {
        System.Console.WriteLine(name + " AC is cooling the room to 22°C");
    }

    public void TurnOff()
    {
        System.Console.WriteLine(name + " AC is turned OFF");
    }

    public override void DisplayStatus()
    {
        System.Console.WriteLine("AC appliance: " + name);
    }
}
