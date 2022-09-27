namespace AssignmentTwo
{
  class GroupsLeftOver
  {
    static void Main(string[] args)
    {
        Func<int, int, int> MinusLetter = (x, y) => x % y;
        Console.Write("How many people are in your group?");
        string inputString = Console.ReadLine() ?? "Z";
        char inputCharacter = char.Parse(inputString);
        Console.WriteLine($"The next letters after {inputCharacter} are {MinusLetter(inputCharacter, 1)}, {MinusLetter(inputCharacter, 2)} and {MinusLetter(inputCharacter, 3)}.");
        
    }
  }
}