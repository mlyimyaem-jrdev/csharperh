namespace ConsoleApp1.TypesInC;

public class ClassLesson
{
    static void Main(string[] args)
    {
        // Person person1 = new Person();
        // person1.name = "Marc Yim";
        // person1.age = 21;
        Person person1 = new Person("Marc Yim", 21);
        person1.Display();
        Employee employee1 = new Employee("Zoro",26,3);
        employee1.Display();
    }
}

class Person
{
    public string name;
    public int age;
    public Person() // Default constructor
    {
        name = "Nill";
        age = -1;
    }
    public Person(string name,int age) // with parameters constructor
    {
        this.name = name;
        this.age = age;
    }
    public void Display()
    {
        int y =  22;
        System.Console.WriteLine($"Name = {name} \nAge = {age}");
    }
    
}

class Employee: Person
{
    int DeptID;
    public Employee(string name, int age, int DeptID): base(name,age)
    {
        this.DeptID = DeptID;
    }
     public new void Display()
    {
        base.Display();
        System.Console.WriteLine($"Employee ID = {DeptID}");
    }
    
}