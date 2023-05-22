using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int Number;
        do
        {
            Console.WriteLine("Enter a number: ");
            string number =  Console.ReadLine();
            Number = int.Parse(number);
            numbers.Add(Number);
            numbers.Sort(); 
        } while(Number != 0);
            float sum = numbers.Sum();
            float avg = sum/numbers.Count();
            int largest = numbers.Count > 0 ? numbers[numbers.Count - 1] : 0;
        Console.WriteLine($"the sum is: {sum}");
        Console.WriteLine($"the average is: {avg}");
        Console.WriteLine($"the largest is: {largest}");
        Console.WriteLine("The sorted list is:");
        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}