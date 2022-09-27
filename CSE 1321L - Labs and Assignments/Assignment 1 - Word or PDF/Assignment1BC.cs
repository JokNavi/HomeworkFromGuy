namespace HelloWorld
{
  class LettersMinusThree
  {
    static void Main(string[] args)
    {
        Func<int, int, char> MinusLetter = (x, y) => (char)(x + y);
        Console.WriteLine("Please enter a letter: ");
        string inputString = Console.ReadLine() ?? "Z";
        char inputCharacter = char.Parse(inputString);
        Console.WriteLine($"The next letters after {inputCharacter} are {MinusLetter(inputCharacter, 1)}, {MinusLetter(inputCharacter, 2)} and {MinusLetter(inputCharacter, 3)}.");
    }
  }
}