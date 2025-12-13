



namespace ConsoleApp1.TypesInC;

struct Vector
{
    public int x;
    public int y;
    // public Vector(int a, int b)
    // {
    //     x = a;
    //     y = b;
    // }
    public Vector(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public class StructLesson
{
    static void Main(string[] args)
    {
        // Vector vector1 = new Vector();
        // vector1.x = 10;
        // vector1.y = 20;
        Vector vector1 = new Vector(10,20);
        System.Console.WriteLine($"x = {vector1.x}");
        System.Console.WriteLine($"y = {vector1.y}");
       
    }
}