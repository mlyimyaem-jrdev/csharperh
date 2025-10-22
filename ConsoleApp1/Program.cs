﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome Devs");
        int age = 26;
        System.Console.WriteLine("my age is" + age);
        float cent = 0.76f;
        double price = 21.09;
        char letter = '!';
        byte p = 1; //0-255
        long trillions = 9999999999;
        System.Console.WriteLine("Price is " + price);
        string name = "Marc Yim";
        bool isRunning = true;
        System.Console.WriteLine(name + isRunning);
        // System.Console.WriteLine(name + isRunning);
        string _fullName = "";
        System.Console.WriteLine("10 + 3" + (10 + 3));
        System.Console.WriteLine("10 - 3" + (10 - 3));
        System.Console.WriteLine("10 * 3" + (10 * 3));
        System.Console.WriteLine("10 / 3" + (10 / 3));
        System.Console.WriteLine("10 % 3" + (10 % 3));
        System.Console.WriteLine("10 < 3" + (10 < 3));
        System.Console.WriteLine("10 > 3" + (10 > 3));
        System.Console.WriteLine("1 <= 1" + (1 <= 1));
        System.Console.WriteLine("3 >= 3" + (3 >= 3));
        System.Console.WriteLine("1 == 1" + (1 == 1));
        System.Console.WriteLine("2 != 3" + (2 != 3));

        System.Console.WriteLine("true && true" + (true && true));
        System.Console.WriteLine("false && true" + (false && true));
        System.Console.WriteLine("true && false" + (true && false));
        System.Console.WriteLine("false && false" + (false && false));

        System.Console.WriteLine("true || true" + (true || true));
        System.Console.WriteLine("false || true" + (false || true));
        System.Console.WriteLine("true || false" + (true || false));
        System.Console.WriteLine("false || false" + (false || false));
        System.Console.WriteLine("!true" + (!true));
        System.Console.WriteLine("!false" + (!false));
        System.Console.WriteLine("!(!false)" + (!(!false)));

        //day 3
        int price2 = 100;
        float discount = price2 - (price2 * 0.5f);
        System.Console.WriteLine(discount);

        string s = "22";
        // string s = "22s"; //error
        int age2 = int.Parse(s);
        System.Console.WriteLine(age2);
        var nickname = "Mac";
        nickname = "Mac D cheese";
        // nickname = 21; //error
        System.Console.WriteLine(nickname);

        // ThisIsAVeryLongClassNameAndItIsRealyAnnoying a = new ThisIsAVeryLongClassNameAndItIsRealyAnnoying();
        var a = new ThisIsAVeryLongClassNameAndItIsRealyAnnoying();
        int year;
        year = 2028;
        var b = true;
        //arrays
        // int[] winningCombination;
        int[] winningCombination = new int[6];
        // string[] friends;
        string[] friends = new string[10];
        winningCombination[0] = 8;
        winningCombination[1] = 43;
        winningCombination[1] = 30;

        friends[0] = "bob";
        friends[1] = "bobby";
        friends[3] = "bobbydi";
        friends[5] = "bobbydiyo";
        // string[] toyColor = new string[4];
        // toyColor[0] = "red";
        // toyColor[1] = "green";
        // toyColor[2] = "blue";
        // toyColor[3] = "pink";
        string[] toyColor = { "red", "green", "blue", "pink" };
        bool[] result1 = { false, true, true };
        // char[] chars = new char[3];
        char[] chars = { 'a', 'b', 'c' };
        System.Console.WriteLine(chars);
        chars[1] = 'B';
        System.Console.WriteLine(chars);
        string[] food = new string[3] { "adobo", "sinigang", "sisig", };
        string[] StrawHatCrew = new string[] { "Luffy", "Nami", "Zoro", "Sanji" };
        StrawHatCrew[3] = "chopper";
        int[] newWinningCombinations = { 56, 11, 9 };
        System.Console.WriteLine(newWinningCombinations[0] + winningCombination[0]);
        int[] jackpotCombination = winningCombination;
        System.Console.WriteLine(StrawHatCrew);
        // Toy toy1 = new Toy();
        Toy[] toys = { new Toy(), new Toy(), new Toy(), };
        System.Console.WriteLine(newWinningCombinations);
        float[] grades = { 99.9f, 87.4f };
        // var[] grades = { 99.9f, 87.4f }; //error
        // var grades = { 99.9f, 87.4f }; //error

        //2d Array
        int[,] table1 = new int[2, 5];
        // 0 0 0 0 0
        // 0 0 0 0 0
        int[,] table2 = new int[2, 5]
        {
            {2,4,6,8,10, }, //0
            {1,3,5,7,9, }, //1
        };
        System.Console.WriteLine(table2[0,1]+table2[1,4]);

    }
}

class ThisIsAVeryLongClassNameAndItIsRealyAnnoying { }
class Toy
{
    string name;
}