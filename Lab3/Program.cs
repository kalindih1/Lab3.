using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {




            string userName = "";
            string userInput = "";
            int userNumber = -1;




            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();

            while (userNumber != 0)

            {
                Console.WriteLine("Please enter a number between 1 and 100.");
                userInput = Console.ReadLine();
                userNumber = int.Parse(userInput);



                if (userNumber % 2 == 0 && userNumber >= 2 && userNumber <= 25)
                {

                    Console.WriteLine(userName + " your number even and less than 25");

                }
                else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
                {

                    Console.WriteLine(userName + "your number is even");
                }
                else if (userNumber % 2 == 0 && userNumber > 60)
                {

                    Console.WriteLine(userName + " your number" + userNumber + " is even");
                }
                else if (userNumber % 2 == 1)
                {

                    Console.WriteLine(userName + " your number" + userNumber + " is odd");
                }
                else if (userNumber % 2 == 1 && userNumber > 60)
                {

                    Console.WriteLine(userName + " your number" + userNumber + " is odd");
                }
            }


        }
    }
}
