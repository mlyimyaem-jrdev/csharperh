namespace ConsoleApp1.Inheritance;

public class AbstractLesson
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Bike();
        Bike bike = new Bike();
        Motor motor = new Motor();
        Bike motorbike = new Motor();
        System.Console.WriteLine(vehicle.Wheels);
        System.Console.WriteLine(bike.Wheels);
        System.Console.WriteLine(motor.Wheels);
        System.Console.WriteLine(motorbike.Wheels);
        
    }    
}

abstract class Vehicle
{
    protected int wheels;
    public int Wheels
    {
        get{return wheels;}
    }

    

}
class Bike: Vehicle
    {
        public Bike(){
            base.wheels = 2;
        }
    }
class Motor: Bike
{
   
}
abstract class Machine{
    int Gear
    {
        get;
        set;
    }

}