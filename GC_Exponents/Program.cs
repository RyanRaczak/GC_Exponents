using System;

namespace GC_Exponents
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user input
            //Validate if number
            //Validate if in range -- Check max number for INT for range & dont allow neg
            //Display table -- Format table
            //Get user continue

            Console.WriteLine("Welcome to the exponents tables...\n");
            int rangeMin = 1;
            int rangeMax = 1290;
            bool continueProgram = true;
            //Main program loop
            while (continueProgram)
            {
                //Validation loop
                while (true)
                {
                    //Getting input
                    string input = GetInput("\nPlease enter a number to start: ");
                    if (ValidateNum(input))
                    {
                        //Checking Range
                        if (ValidateRange(rangeMin, rangeMax, int.Parse(input)))
                        {
                            //ENTER TABLE HERE
                            Console.WriteLine("\n{0,-10} {1,15} {2,20}", "Number", "Squared", "Cubed");
                            Console.WriteLine("{0,-10} {1,15} {2,20}", "______", "_______", "_____");
                            for (int i = 1; i <= int.Parse(input); i++)
                            {
                                Console.WriteLine("{0,-18:n0} {1,-22:n0} {2:n0}", i, Math.Pow(i, 2), Math.Pow(i, 3));
                            }
                            //Checking continue
                            continueProgram = UserContinue();
                        }
                    }
                }
            }
        }
        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }

        public static bool ValidateNum(string input)
        {
            double num;
            if (double.TryParse(input, out num))
            {
                return true;
            }
            else
            {
                Console.WriteLine("\nPlease enter an actual number...");
                return false;
            }
        }

        public static bool ValidateRange(double min, double max, double num)
        {
            if (min < max)
            {
                if (num >= min && num <= max)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"\n{num} is out of range...");
                    return false;
                }
            }
            else
            {
                Console.WriteLine($"\n{min} as min was set larger than {max} as max. Can't check range...");
                return false;
            }
        }

        public static bool UserContinue()
        {
            string input = GetInput("\n\nWould you like to run the program again? (y/n)");
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                Console.WriteLine("Ending program...");
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input...please enter y or n...");
                return UserContinue();
            }
        }

    }
}
