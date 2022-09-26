namespace HelloWorld
{
  class FinalGrades
  {
    static void Main(string[] args)
    {
        float labsAverage = 100f;
        float assignmentsAverage = 100f;
        float midtermAverage = 100f;
        float finalExamAverage = 100f;
        Func<float, float, float> MultiplyPercentages = (Input, Average) => ((Input/100) * (Average/100))*100;

        Console.WriteLine("Hello and welcome to Grade Master 2000\u00A9");
        Console.WriteLine("Enter your average grade for labs:");
        float labsInput = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter your average grade for assignments:");
        float assignmentsInput = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter your average grade for the midterm exam:");
        float midtermInput = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter your average grade for the final exam:");
        float finalExamInput = float.Parse(Console.ReadLine());

        float labsOutput = MultiplyPercentages(labsInput, labsAverage);
        float assignmentsOutput = MultiplyPercentages(assignmentsInput,assignmentsAverage);
        float midtermsOutput = MultiplyPercentages(midtermInput, midtermAverage);
        float finalExamOutput = MultiplyPercentages(finalExamInput, finalExamAverage);

        Console.WriteLine($"\nYour weighted average scores are:\n");
        Console.WriteLine($"labs: {labsOutput}%");
        Console.WriteLine($"assignments: {assignmentsOutput}%");
        Console.WriteLine($"midterms: {midtermsOutput}%");
        Console.WriteLine($"final exam: {finalExamOutput}%");
        Console.WriteLine($"Your final grade in CSE 1321L is {(labsOutput+assignmentsOutput+midtermsOutput+finalExamOutput)/4}%");
    }
  }
}