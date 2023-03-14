using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Creat the List of the questions//
        string[] questions = {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};
        List<string> questionsList = new List<string>(questions);

        //While loop to keep the program going//
        Random randomGenerator = new Random();
        string response = "0";
        int questionsIndex = -1;
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
                int ramdomIndex = randomGenerator.Next(0, questionsList.Count);

                //This part is to not repeat the questions//
                while (ramdomIndex == questionsIndex)
                {
                    ramdomIndex = randomGenerator.Next(0, questionsList.Count);
                }

                questionsIndex = ramdomIndex;

                Console.WriteLine(questionsList[questionsIndex]);
                string textResponse = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                string entireResponse = ($"{dateText} {questionsList[questionsIndex]}: {textResponse}");
                Console.WriteLine(entireResponse);

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