using System;
    class Assignment3C
    {
        public void PhoneCompatibility()
        {
            Console.Write("What mobile device do you have?");
            string device = Console.ReadLine() ?? "No-Input";
            if(device.Equals("Android") || device.Equals("Apple"))
            {
                Console.WriteLine("What version do you have?");
                int version = int.Parse(Console.ReadLine());
                if(device.Equals("Android") && version >= 11){
                    
                }
            }
        }
    }
    class Assignment3B
    {
        public void MartialArts()
        {
            Console.Write("What belt grade are you?");
            int grade =  int.Parse(Console.ReadLine());
            switch(grade) 
            {
            case 10:
            case 9:
                Console.WriteLine($"You have a White Belt,\nwith {grade%2} stripe!");
                break;
            case 8:
            case 7:
                Console.WriteLine($"You have a Yellow Belt,\nwith {grade%2} stripe!");
                break;
            case 6:
            case 5:
                Console.WriteLine($"You have a Blue Belt,\nwith {grade%2} stripe!");
                break;
            case 4:
            case 3:
                Console.WriteLine($"You have a Green Belt,\nwith {grade%2} stripe!");
                break;
            case 2:
            case 1:
                Console.WriteLine($"Brown Belt,\nwith {grade%2} stripe!");
                break;
            case 0:
                Console.WriteLine($"Black Belt,\nwith {grade%2} stripe!");
                break;
            default:
                Console.WriteLine($"You have no belt...");
                break;
            }
        }
    }
    class Assignment3A
    { 
        
        public void StoryNestedIf()
        {
            Console.WriteLine("Hello stranger! Do you have time to hear my tale? \n1) Yes \n2) No");
            string choice =  Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Thank you! I come from the land of Pax Bisonica. Our country has been taken over by a cruel tyrant! \n1) That’s awful! \n2) What can I do?");
                choice =  Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Alas, it is truly terrible...");
                    Console.WriteLine("Please, you must journey to Pax Bisonica and free our country! \n1) Yes \n2) No");
                    choice =  Console.ReadLine();
                    if (choice == "1"){Console.WriteLine("Hooray!!");}
                    else{Console.WriteLine("Then all is lost...");}
                }
                else
                {
                    Console.WriteLine("Please, you must journey to Pax Bisonica and free our country! \n1) Yes \n2) No");
                    choice =  Console.ReadLine();
                    if (choice == "1"){Console.WriteLine("Hooray!!");}
                    else{Console.WriteLine("Then all is lost...");}
                }
            }
            else
            {
                Console.WriteLine("Ah, then goodbye...");
            }
        }
    }
class AssignmentThree {

    static void Main(String[] args)
    {
        Assignment3A Assignment3A = new Assignment3A();
        //Assignment3A.StoryNestedIf();
        Assignment3B Assignment3B = new Assignment3B();
        //Assignment3B.MartialArts();
        Assignment3C Assignment3C = new Assignment3C();
        Assignment3C.PhoneCompatibility();
    }
  
}
