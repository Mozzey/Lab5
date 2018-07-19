using System;

namespace Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            long userNum;
            bool isRunning = true;
            while (isRunning)
            {
                // Greet the user
                Console.WriteLine("Welcome to the Factorial Calculator!");
                // prompt user to enter num from 1 to 10
                Console.WriteLine("Enter an integer that is greater than 0 but less than 10!");
                // Store user input
                userNum = long.Parse(Console.ReadLine());
                long result = userNum;
                // use a for loop for calculation
                for (int i = 1; i < userNum; i++)
                {
                    // check that user input is between 1 and 10
                    if (IsNumInRange(userNum))
                    {
                        // if valid do factorial calculation
                        result *= i;
                    }
                // display factorial of user input
                    Console.WriteLine(result);
                }
                // use long type to store factorial

                // factorial ex: 5! == 4*3*2*1 == 24
                if (!PlayAgain())
                {
                    isRunning = false;
                    Console.WriteLine("Thanks for playing!");
                }
            }
        }
        // method to do factorial calculation on user input
        public static long CalculateFactorial(long userNum)
        {
            for (int i = 1; i < userNum; i++)
            {
                userNum *= i;
                
            }
            return userNum;
        }
        // method to check if user input is within range
        private static bool IsNumInRange(long userNumIn)
        {
            if (!(userNumIn > 0 && userNumIn < 10))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // seerate method to ask if the user would like to terminate the program
        private static bool PlayAgain()
        {
            // try catch to handle the exception of needing at least 1 character in the input
            try
            {
                // prompt user to continue (only continue if user agrees)
                Console.WriteLine("Would you like to play again? ( y/n )");
                // store user response
                char yOrN = char.Parse(Console.ReadLine().ToLower().Trim());
                // check for y or n
                if (yOrN == 'y')
                {
                    return true;
                }
                else if (yOrN == 'n')
                {
                    return false;
                }
                else
                {
                    // recursive check for input other than y or n
                    return PlayAgain();
                }
            }
            // try catch to handle the exception of needing at least 1 character in the input
            catch (Exception)
            {
                return PlayAgain();
            }
        }
    }
}
