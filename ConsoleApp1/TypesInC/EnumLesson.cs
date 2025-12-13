namespace ConsoleApp1.TypesInC;

enum Status :byte // byte, short, int, long & sbyte, ushort, uint, ulong
{
    Alive =1, //0 if Alive =1 Injured =2 UnAlive =3
    Injured, //1
    UnAlive, //2
}

public class EnumLesson
{
    static void Main(string[] args)
    {
        // uint v = -20; //error uint cannot accept negative numbers
        
        Status player = Status.Alive;
        switch (player)
        {
            case Status.Alive:
            //Do Alive Code
            System.Console.WriteLine($"the player status is {player}");
            break;
            case Status.Injured:
            //Do Alive Code
            System.Console.WriteLine($"the player status is {player}");
            break;
            case Status.UnAlive:
            //Do Alive Code
            System.Console.WriteLine($"the player status is {player}");
            break;
        
        }
        System.Console.WriteLine((int)Status.UnAlive);
    }
}