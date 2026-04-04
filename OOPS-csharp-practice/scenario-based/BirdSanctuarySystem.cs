
using System;

interface IFlyable
{
    void Fly();
}

interface ISwimmable
{
    void Swim();
}

abstract class Bird
{
    public string Name { get; set; }

    protected Bird(string name)
    {
        Name = name;
    }
}

class Eagle : Bird, IFlyable
{
    public Eagle(string name) : base(name) { }
    public void Fly()
    {
        Console.WriteLine(Name + " is flying high");
    }
}

class Sparrow : Bird, IFlyable
{
    public Sparrow(string name) : base(name) { }
    public void Fly()
    {
        Console.WriteLine(Name + " is flying");
    }
}

class Duck : Bird, ISwimmable
{
    public Duck(string name) : base(name) { }
    public void Swim()
    {
        Console.WriteLine(Name + " is swimming");
    }
}

class Penguin : Bird, ISwimmable
{
    public Penguin(string name) : base(name) { }
    public void Swim()
    {
        Console.WriteLine(Name + " is swimming");
    }
}

class Seagull : Bird, IFlyable, ISwimmable
{
    public Seagull(string name) : base(name) { }
    public void Fly()
    {
        Console.WriteLine(Name + " is flying");
    }

    public void Swim()
    {
        Console.WriteLine(Name + " is swimming");
    }
}

class Sanctuary
{
    public Bird[] Birds;

    public Sanctuary(Bird[] birds)
    {
        Birds = birds;
    }

    public void ShowActivities()
    {
        foreach (Bird bird in Birds)
        {
            if (bird is IFlyable flyable)
                flyable.Fly();

            if (bird is ISwimmable swimmable)
                swimmable.Swim();
        }
    }
}
