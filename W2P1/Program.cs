using System;

namespace W2P1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           // Console.WriteLine("Please type something and press the enter key");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed : " + userValue);
            //Console.ReadLine();
            Console.WriteLine("Would you prefer what is behind door number 1, 2, or 3?");
            string userValue = Console.ReadLine();

			// the double equal sign means that we want to determine
			// weather the expression is true or not
			// whereas the single equal assigns a value to a variable
			string message = "";
            /* using the string message to clean up the code
             * so that I can avoid typing Console.WriteLine
             * and Console.ReadLine more that I have to 
             */
            if (userValue == "1")
            {
                message = "You won a new car!";
            }
            else if (userValue == "2")
            {
                message = "You won a new boat!";
            }
            else if (userValue == "3")
            {
                message = "You won a new cat!";
            }
            else
            {
                messsage = "Sorry, We didn't unerstand. You Lose!";
            }

                     Console.WriteLine(message);
                     Console.ReadLine();
        }
    }
}
