using System;
using System.Collections.Generic;
using System.IO;


public class Program
{

    public static Journal journal;

    public static void Main(string[] args)
    {
        journal = new Journal();
        string choice;

        do
        {
            DisplayMenu();
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    SaveJournalToFile();
                    break;
                case "3":
                    LoadJournalFromFile();
                    break;
                case "4":
                    DisplayJournal();
                    break;
                case "5":
                    Console.WriteLine("Don't forget to write again tomorrow!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        } while (choice != "5");
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("Journal");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Save the journal to a file");
        Console.WriteLine("3. Load the journal from a file");
        Console.WriteLine("4. Display the journal");
        Console.WriteLine("5. Quit");
        Console.Write("Enter your choice: ");
    }

    private static void WriteNewEntry()
    {
        Prompts prompts = new Prompts();
        string prompt = prompts.question();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();
        journal.AddEntry(prompt, response, date);
        Console.WriteLine("Entry added!");
    }

    private static void SaveJournalToFile()
    {
        Console.Write("Enter the file name: ");
        string fileName = Console.ReadLine();
        journal.SaveToFile(fileName);
        Console.WriteLine("Journal saved to file.");
    }

    private static void LoadJournalFromFile()
    {
        Console.Write("Enter the file name: ");
        string fileName = Console.ReadLine();
        journal.LoadFromFile(fileName);
        Console.WriteLine("Journal loaded from file.");
    }

    private static void DisplayJournal()
    {
        journal.DisplayEntries();
    }
}





