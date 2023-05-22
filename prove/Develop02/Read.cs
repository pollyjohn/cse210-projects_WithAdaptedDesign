public class Read{     
    public string[]  read(List<string> entriesW)
    {
        Console.WriteLine("what's the path to the file? ");
        string fileName = Console.ReadLine(); 
        string[] lines = System.IO.File.ReadAllLines(fileName);
        return lines;
    }
}