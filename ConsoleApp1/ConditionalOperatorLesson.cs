namespace ConsoleApp1;

public class ConditionalOperatorLesson
{
    static void Main(string[] args)
    {
        int num = -2;
        string result = (num % 2 == 0) ? "Even" : "Odd";
        System.Console.WriteLine($"{num} is {result} number");
        result = (num==0)? "zero":(num>0)?"positive":"negetive"; //()?t:f
        System.Console.WriteLine($"{num} is a {result} number");
        // null coalescing operator (??)
        string name = null;
        //set username = name, if name is not null;
        //set username = "user", if name is null;
        string username = name ?? "user";
        System.Console.WriteLine($"username is {username}");
    }
}