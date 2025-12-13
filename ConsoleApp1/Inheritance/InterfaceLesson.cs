namespace ConsoleApp1.Inheritance;

public class InterfaceLesson
{
    static void Main(string[] args)
    {
        IVehicle ebike= new eBike();
        System.Console.WriteLine(ebike.Display);
    }
}

interface IVehicle
{
    int Wheels2 {get;}
    string Display{get;}
}
interface IPropeller
{
    int Blade {get;}
    
}

class eBike: Vehicle, IVehicle, IPropeller
{
    private int wheels;
    private int blade;


    public int Wheels2
    {
        get{return wheels;}
        
    }
    public string Display
    {
        get{return "Display basic info";}
    }
    public int Blade {
        get{return blade;}
    }
}