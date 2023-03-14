using System;

class Program
{
    static void Main(string[] args)
    {

        string response = "0";
        while (response != "5")
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            response = Console.ReadLine();
            
            if (response == "1")
            {

            }

            else if (response == "2")
            {
                
            }

            else if (response == "3")
            {
                
            }

            else if (response == "4")
            {
                
            }

            else if (response == "5")
            {
                Console.Write("Goodbye!");
            }

            else
            {
                Console.WriteLine("Please enter a valid number");
            }

        }

    }
}