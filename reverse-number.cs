using System;

namespace firstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string userInput = "";
            int iUserInput;
            int userNum = 23;
            int reverseNum;

            //get number from user
            Console.Clear();
            Console.WriteLine("Program to Reverse the Digits of Any Integer");
            Console.WriteLine();
            Console.WriteLine("Enter an integer of any length: ");
            userInput = Console.ReadLine();

            //make sure input is an integer
            if (int.TryParse(userInput, out iUserInput))
            {
                userNum = iUserInput;
                Console.WriteLine("\nYou entered " + userNum);
                reverseNum = ReverseNumber(userNum);
                Console.WriteLine("\nYour number in reverse order is: " + reverseNum);
                Console.WriteLine("\nPress any key to continue . . .");
                string pauseTime = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nThat is not an integer.");
                Console.WriteLine("\nPress any key to continue . . .");
                string pauseTime = Console.ReadLine();
            }
             
        }
        public static int ReverseNumber(int userNum)
        //reverse number
        {
            int reverseNum = 0;
            int onesPlace;
            while (userNum != 0)
            {
                onesPlace = userNum % 10;
                userNum = userNum / 10;
                reverseNum = (reverseNum * 10) + onesPlace;
            }
            return reverseNum;
        }
    }
}
