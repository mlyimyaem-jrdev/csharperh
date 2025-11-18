namespace ConsoleApp1;

public class JaggedArrayLesson
{
    static void Main(string[] args)
    {
        int[][] jagged =
        {
            new int[]{ 4,5}, //0
            new int[]{ 6,7,8}, //1
            new int[]{ 9,10,11,12}, //2
            new int[]{ 13,14,15,16,17}, //3
        };
        System.Console.WriteLine(jagged[2][2]);
        for (int i=0;i<jagged.Length;i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                System.Console.Write(jagged[i][j]+", ");
            }
            System.Console.WriteLine();
            
        }
    }
}