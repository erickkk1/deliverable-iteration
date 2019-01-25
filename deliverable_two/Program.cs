using System;

namespace deliverable_two
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input.
            Console.WriteLine(" Hello !, what grade are you expecting to have in this class?");
            

            //Use the Try Catch block variable user input.If the user.
            // If the user provide bad input, the catch block will handle the error
            // and a message will display.
            try
            {
                String input = Console.ReadLine();
                int value_of_input = int.Parse(input);

                if ((value_of_input >= 98) && (value_of_input <= 100))
                {
                    Console.WriteLine("Yeah ! It means EXCELLENT, Consider getting an A+ for the class.");
                   
                   
                }

                else if ((value_of_input >=92) && (value_of_input <= 97))
                {
                    Console.WriteLine(" Great!,consider getting a A for this class. ");

                }

                else if ((value_of_input >=90) && (value_of_input <= 91))
                {
                    Console.WriteLine("Great, consider getting an A- for this class ");
                }
                else if ((value_of_input >= 88) && (value_of_input <= 89))
                {
                    Console.WriteLine("Great!,  consider getting a B+ for this class.");

                }
                else if ((value_of_input >= 82) && (value_of_input <= 87))
                {
                    Console.WriteLine(" Great!, Consider getting a B for this class.");
                }
                else if ((value_of_input >= 80) && (value_of_input <= 81))
                {
                    Console.WriteLine("Great!, consider getting a B-.");
                }
                else if ((value_of_input >= 78) && (value_of_input <= 79))
                {
                    Console.WriteLine("Good!,consider getting C+, ");
                }
                else if ((value_of_input >= 72) && (value_of_input <= 77))
                {
                    Console.WriteLine("Good!,consider getting a C for this class;");
                }
                else if ((value_of_input >= 70) && (value_of_input <= 71))
                {
                    Console.WriteLine("good!,consider getting a C - .");
                }
                else if ((value_of_input >= 68) && (value_of_input <= 69))
                {
                    Console.WriteLine("Ouch!,consider getting a D+.");
                }
                else if ((value_of_input >= 62) && (value_of_input <= 67))
                {
                    Console.WriteLine("Ouch!, Consider getting a D for this class.");
                }
                else if ((value_of_input >= 60) && (value_of_input <= 61))
                {
                    Console.WriteLine("Ouch!,consider getting a D-.");
                }
                else if ((value_of_input <60))
                {
                    Console.WriteLine("Ouch!,Consider getting a F for this class..");

                }
                else
                {
                    Console.WriteLine("You have to type in an enteger between 0 and 100 please..");
                }

            }// end of Try



            catch
            {
                Console.WriteLine("Sorry, You need to enter an integer betwwen 0 and 3,Thank you.");
                Console.ReadKey(true);
            }// end of catch.
            Console.ReadLine();

        }// End of Main
    } // End of class
}// End of namespace
    
    

