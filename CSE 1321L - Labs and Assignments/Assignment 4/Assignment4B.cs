class Assignment4B
{
    /*static public void Main(String[] args)
    {
        //Number input code
        Console.WriteLine("Welcome!");
        Console.Write("Please input a number: ");
        float number = float.Parse(Console.ReadLine() ?? "-1"); // this is the number that will be plugged into the forumla menu
        if (number < 0)
        {
            Console.WriteLine("Invalid number entered. Number must be higher than or equal to 0.\n");
            Console.Write("Please input a number: "); number = float.Parse(Console.ReadLine() ?? "-1");
        }
        while (true)
        {
            //Choice code
            Console.WriteLine("\nWhat would you like to do to this number:");
            Console.WriteLine("-1- Re-enter the number");
            if (number != 0f) { Console.WriteLine(" 0- Get the additive inverse of the number"); }
            Console.WriteLine(" 1- Get the reciprocal of the number");
            Console.WriteLine(" 2- Square the number");
            Console.WriteLine(" 3- Cube the number");
            Console.WriteLine(" 4- Exit the program");
            int choice = int.Parse(Console.ReadLine() ?? "5");
            if (choice <= -1 && choice >= 4) { Console.Write("Invalid choice entered. Please select a choice from -1 to 4\n"); choice = int.Parse(Console.ReadLine() ?? "5");}
            switch (choice)
            {
                case (-1):
                    Console.Write("Please enter your new number:");
                    number = float.Parse(Console.ReadLine() ?? "-1");
                    break;
                case 0:
                    Console.Write($"The additive inverse of {number} is {number * -1}\n"); break;
                case 1:
                    Console.Write($"The reciprocal of {number} is {1 / number}\n"); break;
                case 2:
                    Console.Write($"The square of {number} is {number * number}\n"); break;
                case 3:
                    Console.Write($"the cube of {number} is {number * number * number}\n"); break;
                case 4:
                    Console.Write("Thank you, goodbye!\n"); break;
                default:
                    Console.Write("Invalid input, please try again! \n"); break;
            }
        }
    }*/
}