namespace ConsoleApp1.DataProtection;

public class FullAutoProperty
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.Age = 10;
        student1.Name = "";
        System.Console.WriteLine(student1.Age);
        System.Console.WriteLine(student1.Name);
        Employee employee1 = new Employee();
        employee1.Age = 21;
        employee1.Name = "Bing";
        System.Console.WriteLine(employee1.Age);
        System.Console.WriteLine(employee1.Name);
        

    }
}

//full property
class Student
{
    private int age;
    private string name;
    private readonly string status;


    public int Age
    {
        get{ return age;}
        set{ this.age = value;}

    }
    public string Name
    {
        get{ return $"My name is {this.name}";}
        set{
            if(value!="") 
                this.name = value;
            else
                this.name ="Invalid";
            }
    }
    public string Status
    {
        get{ return status;}
        // set{ this.status = value;}

    }
}
//Auto property
class Employee
{
    public int Age{
        get;
        set;
    }
    public string Name{
        get;
        set;
    }
     public string  Status{
        get;
     }
}