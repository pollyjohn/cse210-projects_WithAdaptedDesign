using System;

class Program
{
    static void Main(string[] args)
    { 
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,10);
        int inputNumber;
        do {
            Console.WriteLine("what is the magicNumber?");
            string Number = Console.ReadLine();
            inputNumber = int.Parse(Number);
            if(inputNumber > magicNumber ) 
            {
                Console.WriteLine("Try Again. Guess lower this time.");
            }
            else if (inputNumber < magicNumber)
             {
                Console.WriteLine("Try Again. Guess higher this time.");
             }
            else {Console.WriteLine("That's it!");}
            } while(magicNumber != inputNumber);
    }
}