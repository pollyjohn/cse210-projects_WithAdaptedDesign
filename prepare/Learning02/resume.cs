public class Resume
{
    public string _personName;
    public List<job> jobs = new List<job>();
    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("jobs");
        foreach (job j in jobs)
        {
            j.Display();
        }
    }
}