using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percent grade? ");
        string grade = Console.ReadLine();
        int convertedgrade = int.Parse(grade);
        string letter = "";
        if (convertedgrade >= 90)
        {
            letter = "A";
        }
        else if (convertedgrade >=80)
        {
            letter = "B";
        }
        else if (convertedgrade >= 70)
        {
            letter = "C";
        }
        else if (convertedgrade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"Grade: {letter}");
        if(convertedgrade>=70)
            {
                Console.WriteLine("congrats! You passed");
             }
        else {
                Console.WriteLine("We are sorry. You did not pass.");
            }

    }
}