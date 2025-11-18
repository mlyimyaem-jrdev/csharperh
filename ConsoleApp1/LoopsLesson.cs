namespace ConsoleApp1;

public class LoopsLesson
{
    static void Main(string[] args)
    {
        // while condition
        bool isFound = false;
        int value = 0;
        while (isFound != true)
        {
            System.Console.WriteLine(value);
            if (value == 99)
            {
                isFound = true;
            }
            value = value + 3;
        }
        System.Console.WriteLine("end of while loop");
        //do while loop
        int count = 1;
        do
        {
            System.Console.WriteLine("Hello World");
            count++;
        } while (count <= 5);
        System.Console.WriteLine("end of do while loop");
    }
}