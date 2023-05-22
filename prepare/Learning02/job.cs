public class job
{
    public string _compname;
    public string _title;
    public int _starty;
    public int _endy;

    public void Display()
    {
        Console.WriteLine($"{_title} ({_compname}) {_starty}-{_endy}");
    }
}
