using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber= SquareNumber(number);
        DisplayResult(name, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your name: ");
        string name =  Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number: ");
        string iNumber =  Console.ReadLine();
        int number = int.Parse(iNumber);
        return number;
    } 
    static int SquareNumber(int number)
    {
        int squareNumber = number*number;
        return squareNumber;
    }
    static void DisplayResult(string PromptUserName ,int PromptUserNumber)
    {
        Console.WriteLine($"your name is {PromptUserName} and the squared number is {PromptUserNumber}.");
    }
}