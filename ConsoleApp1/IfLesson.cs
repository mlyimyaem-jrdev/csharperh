namespace ConsoleApp1;

public class IfLesson
{
    static void Main(string[] args)
    {
        int number = 18;
        //if structure
        if (number % 2 == 0)
        {
            System.Console.WriteLine("Even number");
            number++;
        }
        System.Console.WriteLine(number);
        //if-else
        string username = "ded";
        // System.Console.Write("Enter username: ");
        // string username = Console.ReadLine();
        if (username == "dev")
        {
            System.Console.WriteLine("Login Successful");
        }
        else
        {
            System.Console.WriteLine("Invalid username, please try again");
        }
        //if-else if()-else
        // int age = 20;
        System.Console.Write("Enter your age: ");
        int age = Int32.Parse(Console.ReadLine());
        if (age < 11)
        {
            System.Console.WriteLine("You're a child!");
        }
        else if (age < 18)
        {
            System.Console.WriteLine("You're a teenager");
        }
        else if (age < 50)
        {
            System.Console.WriteLine("You're an adult");
        }
        else
        {
            System.Console.WriteLine("You're an old person");
        }
    }
}