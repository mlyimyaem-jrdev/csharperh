namespace ConsoleApp1.Polymorphism;

public class MethodOverload
{
    public void Show(string name)
    {
        System.Console.WriteLine($"Name = {name}");
    }
    public void Show(string name, int age)
    {
        System.Console.WriteLine($"Name = {name}\nAge = {age}");
    }
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        calculator.Add(1,10);
        calculator.Add("1","10");
        calculator.Add();
        MethodOverload methodOverload = new MethodOverload();
        methodOverload.Show("marc");
        methodOverload.Show("marc",21);
        Distance distance = new Distance();
        distance.meter =15;
        distance++;
        System.Console.WriteLine(distance.meter);
        Item s1 = new Item{Price=10};
        Item s2 = new Item{Price=20};
        Item s3 = s1+s2; //bundled item of 1 and 2
        System.Console.WriteLine(s3.Price);
        Distance distance2 = new Distance{meter=10};
        if (distance < distance2)
        {
            System.Console.WriteLine("distance is less than distance2");
        }
        else if (distance2 < distance)
        {
            System.Console.WriteLine("distance2 is less than distance");
        }
        
    }

    
}

class Calculator
{
    public void Add(int a, int b)
    {
        int result = a+b;
        System.Console.WriteLine($"Sum of ints = {result}");
    }
    public void Add(string a, string b)
    {
        string result = a+b;
        System.Console.WriteLine($"Sum of ints = {result}");
    }
    public void Add()
    {
        System.Console.WriteLine("this is overloading method without parameter");
    }
    
}
//Unary operator overloading
class Distance
{
    public int meter{ get; set;}

    public static Distance operator ++(Distance dis)
    {
        dis.meter+=1;
        return dis;
    }

    //Comparison operator overloading
    //syntax public bool operator op (Type1 t1,type2 t2){}

    public static bool operator < (Distance d1,Distance d2)
    {
        return (d1.meter<d2.meter);
    }
    public static bool operator > (Distance d1,Distance d2)
    {
        return (d1.meter>d2.meter);
    }

    
}

//Binary operator overloading
class Item
{
    public int Price{ get; set;}
    // syntax
    // public static return_type operator op (Type1 t1,type2 t2){}
    public static Item operator + (Item s1,Item s2)
    {
        Item std = new Item();
        std.Price = s1.Price + s2.Price;
        return std; 
    }
}

