using System;

namespace Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            long userNum;
            bool isRunning = true;
            while (isRunning)
            {
                // Greet the user
                Console.WriteLine("Welcome to the Factorial Calculator!");
                // prompt user to enter num from 1 to 10
                Console.WriteLine("Please enter an integer that is greater than 0 but less than  10");
                // store user input
                userNum = long.Parse(Console.ReadLine());
                // check if userNum is in range - if true calculate the factorial of the user input
                if (IsNumInRange(userNum))
                {
                    // display factorial of user input
                    Console.WriteLine(CalculateFactorial(userNum));
                }
                else
                {
                    Console.WriteLine("Sorry but your input must be an integer greater than 0 and less than 10");
                }
                // end program on user input
                if (!PlayAgain())
                {
                    // turn off flag
                    isRunning = false;
                    // say buh bye
                    Console.WriteLine("Thanks for playing!");
                }
            }
        }
        // recursive algorithm for n!
        private static long CalculateFactorial(long n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorial(n - 1);
            }
        }
        // method to check if user input is within range
        private static bool IsNumInRange(long userNumIn)
        {
            if ((userNumIn > 0 && userNumIn < 10))
            {
                return true;
            }
            else
            {
                return false;
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
                char yesOrNo = char.Parse(Console.ReadLine().ToLower().Trim());
                // check for y or n
                if (yesOrNo == 'y')
                {
                    return true;
                }
                else if (yesOrNo == 'n')
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
