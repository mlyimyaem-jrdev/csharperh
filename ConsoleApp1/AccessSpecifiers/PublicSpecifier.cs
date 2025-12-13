

namespace ConsoleApp1.AccessSpecifiers;

public class PublicSpecifier
{
    static void Main(string[] args)
    {
        AccessPublic ap1 = new AccessPublic();
        Child child1 = new Child();
        ap1.Method();
        ap1.getAge2();
        Console.WriteLine(ap1.publicCode);
        // Console.WriteLine(ap1.age); //error 
        System.Console.WriteLine(ap1.getAge2());
        ap1.setAge(11);
        System.Console.WriteLine(ap1.getAge2());
        child1.Display();
        System.Console.WriteLine(ap1.publicCode2);
        
    }
}

public class AccessPublic
{
    public int publicCode = 21434;
    internal int publicCode2 = 43412;
    private int age = 10;
    
    public int getAge2()
    {
        return age;
    }
    public void setAge(int a)
    {
        age = a;
    }
    public void Method()
    {
        Console.WriteLine($"Public Method {publicCode2}");
    }
}
class Father
{
    protected string lastName = "yim";
}

class Child : Father
{
    // string lastName = "yim"; 
    public void Display()
    {
        System.Console.WriteLine($"My last name from my father is {lastName} {new AccessPublic().publicCode2}");
    }
}