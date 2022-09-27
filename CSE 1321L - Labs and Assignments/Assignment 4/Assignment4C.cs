class Assignment4C
{
    static public void Main(String[] args)
    {
        const string lower = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
        Console.WriteLine("Please enter your sentence: ");
        string inputLine = Console.ReadLine() ?? throw new ArgumentException("Parameter cannot be null", nameof(inputLine));
        string line = inputLine;
        Console.WriteLine("How many letters do you want to backspace?");
        int amountOfDeletes = int.Parse(Console.ReadLine() ?? "1");
        Console.Write($"{lower}{inputLine}\n");
        System.Threading.Thread.Sleep(700);
        for(int i=0;i<amountOfDeletes;i++)
        {
            for(int x=0;x<=i;x++){line = line + "\b";}
            for(int x=0;x<=i;x++){line = line + " ";}
            Console.WriteLine($"{lower}{line}"); // (19 \n)
            System.Threading.Thread.Sleep(500);
        }
        Console.WriteLine($"{lower}Loading...{lower}");  
        Console.WriteLine("Please enter your sentence: ");
        Console.WriteLine(inputLine);
        Console.WriteLine("How many letters do you want to backspace?");
        Console.WriteLine(amountOfDeletes);
        Console.WriteLine($"line"); //added quotation marks to clearly mark the end of the string when it ends on a space.
    }
}
