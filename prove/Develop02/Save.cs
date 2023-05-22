public class Save
{
    string fileName = "";
    public void save(List<string> entriesW)
    {   
        Console.WriteLine("What is the file name? ");
        fileName = Console.ReadLine();
        using( StreamWriter outputfile = new StreamWriter(fileName, true))
        {
            foreach (string entry in entriesW)
            {
                outputfile.WriteLine($"{entry}");
            }
        }

    }
}