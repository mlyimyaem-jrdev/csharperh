namespace ConsoleApp1.DataProtection;

public class Indexers
{
    static void Main(string[] args)
    {
        Temprature temp = new Temprature();
        float todayTemp = temp[3];
        System.Console.WriteLine(todayTemp);
        System.Console.WriteLine(temp[1]);
        temp[1] = -5.0f;
        System.Console.WriteLine(temp[1]);
    }
}

class Temprature
{
    private float[] weekTemp = {47.5F,40.0F,52.5F,45.5F,48.0F,38.0F,35.7F};
    public float this[int index]
    {
        get{
            if(index >=0 && 0 < weekTemp.Length) 
                return weekTemp[index];
            else
                return 0;
                }
        set{
            if(value > 0) 
                weekTemp[index]=value;
            else
                System.Console.WriteLine("Please set a value greater than 0");
            }
    }
    
}