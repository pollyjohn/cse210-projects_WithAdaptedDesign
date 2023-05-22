public class Prompts
{
    
    public List<string> questions = new List<string>()
    {
        "What was the best thing that happened in your day?",
        "what was the best thing someone said to you today",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the most useful thing I learned today?",
        "What was the most interesting thing I learned today?",
        "what did I learn from the scriptures today?",
    };
    public string prompt()
    {
        Console.WriteLine( "1.write\n2.save\n3.load\n4.Display\n5.quit");
        string choice = Console.ReadLine();
        return choice;
    }
     public void question()
            {
                Random randomGenerator = new Random();
                int option = randomGenerator.Next(0, questions.Count); 
                Console.WriteLine($"{questions[option]}");
            }
}