namespace ConsoleApp1.Polymorphism;

public class VirtualMethod
{
    static void Main(string[] args)
    {
        Vehicle vc = new Bike();
        vc.Run();
        vc.Run2();
        Vehicle2 vc2 = new Ebike202x();
        vc2.Run();
    }
}

class Vehicle
{
    protected int speed = 21;
    public virtual void Run()
    {
        System.Console.WriteLine("Run Vehicle");
    }
    public virtual void Run2()
    {
        System.Console.WriteLine($"Run at speed:{speed}");
    }
}

class Bike: Vehicle
{
    public Bike()
    {
        base.speed = 10;
    }
    public override void Run()
    {
        System.Console.WriteLine("Bike Run");
    }
}

abstract class Vehicle2
{
    public abstract void Run();
}

class Ebike202x : Vehicle2
{
    public override void Run()
    {
        System.Console.WriteLine("Ebike is Running");
    }
}