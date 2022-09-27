class Program
{
    public float InputNumber()
    {
        while (true)
        {
            Console.Write("Please input a number: ");
            float number = float.Parse(Console.ReadLine() ?? "-1");// this is the number that will be plugged into the forumla menu
            if (number >= 0) return number;
            Console.WriteLine("Invalid number entered. Number must be higher than or equal to 0.\n");
        }
    }
    public int Choice(float number)
    {
        while (true)
        {
            Console.WriteLine("\nWhat would you like to do to this number:");
            Console.WriteLine("-1- Re-enter the number");
            if (number != 0f) { Console.WriteLine(" 0- Get the additive inverse of the number"); }
            Console.WriteLine(" 1- Get the reciprocal of the number");
            Console.WriteLine(" 2- Square the number");
            Console.WriteLine(" 3- Cube the number");
            Console.WriteLine(" 4- Exit the program");
            int choice = int.Parse(Console.ReadLine() ?? "5");
            if (choice >= -1 && choice <= 4) return choice;
            Console.WriteLine("Invalid choice entered. Please select a choice from -1 to 4\n");
        }
    }
    public int DoLogic(int choice, float number)
    {
        switch (choice)
        {
            case (-1):
                return -1;
            case 0:
                Console.Write($"The additive inverse of {number} is {number * -1}"); return 0;
            case 1:
                Console.Write($"The reciprocal of {number} is {1 / number}"); return 0;
            case 2:
                Console.Write($"The square of {number} is {number * number}"); return 0;
            case 3:
                Console.Write($"the cube of {number} is {number * number * number}"); return 0;
            case 4:
                Console.Write("Thank you, goodbye!"); return 1;
            default:
                Console.Write("Invalid input, please try again! \n"); return -1;
        }
    }
}
class Lab4C
{
    static public void Main(String[] args)
    {
        Console.WriteLine("Welcome!");
        Program P = new Program();
        int ErrorCode = -1;
        while (ErrorCode < 0){
        float number = P.InputNumber();
        int choice = P.Choice(number);
        ErrorCode = P.DoLogic(choice,number);
        }
    }
}
