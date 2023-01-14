namespace GoXLR_Utility.NET.ConsoleTests;

public class Program
{
    private static Utility _utility = new Utility();
    
    public static void Main(string[] args)
    {
        _utility.Connect();
        Console.ReadKey();
        Console.ReadKey();
    }
}