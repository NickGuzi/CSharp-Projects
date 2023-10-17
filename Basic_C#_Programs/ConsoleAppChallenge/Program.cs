using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChallenge
{
    class Program
    {
        static void Main()
        {
            List<string> userList = new List<string>();

            Console.WriteLine("Now we're going to let you create a list...");

            while (true)
            {
                Console.WriteLine("Enter any word of your desire!");
                string input = Console.ReadLine();
                userList.Add(input);

                Console.WriteLine("Want add another word? Or do you want to see your list? Press 1 to add more or 0 to see your list...");
                var listChoice = int.Parse(Console.ReadLine());

                if (listChoice == 1)
                {
                    Console.WriteLine("Okay lets add some more!");
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine("Here is your list...");
            Console.ReadLine();

            for (int x = 0; x < userList.Count; x++)
            {
                Console.WriteLine(userList[x]);
            }

            Console.ReadLine();

            Console.WriteLine("Here is the amount of elements in your list...");
            Console.WriteLine(userList.Count);

            int indices = userList.Count - 1;

            while (true)
            {
                Console.WriteLine("Pick a number between 0 and " + indices + " to see a word's associated position");
                var pick = int.Parse(Console.ReadLine());

                if (pick > indices)
                {
                    Console.WriteLine("You must pick a number between 0 and " + indices);
                }
                else
                {
                    Console.WriteLine("The word associated with this position is: " + userList[pick]);
                }

                Console.WriteLine("Want pick another number? Press 1 to pick again or 0 to not...");
                var listChoice2 = int.Parse(Console.ReadLine());

                if (listChoice2 == 1)
                {
                    Console.WriteLine("Okay lets pick another number");
                }
                else
                {
                    break;
                }

            }

            List<string> identicalList = new List<string>() { "dodgers", "mets", "braves", "padres", "mariners", "mets", "rangers"};

            while (true)
            {
                Console.WriteLine("Please guess an MLB team (do not include city name within guess...");
                string guess = Console.ReadLine().Trim().ToLower();

                if (guess == "mets")
                {
                    Console.WriteLine("The list includes the " + guess + " within it");
                    Console.WriteLine("The team is held at index 1 and 5");

                }
                else if (identicalList.Contains(guess) && guess != "mets")
                {
                    Console.WriteLine("The list includes the " + guess + " within it");
                    Console.WriteLine("The team is held at index " + identicalList.IndexOf(guess));
                }
                else
                {
                    Console.WriteLine("The list does not include the " + guess + " within it");
                }

                Console.WriteLine("Want pick guess again? Press 1 to guess again or 0 to not...");
                var listChoice2 = int.Parse(Console.ReadLine());

                if (listChoice2 == 1)
                {
                    Console.WriteLine("Okay lets guess again");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Here are the teams contained in the list...");
            Console.ReadLine();

            List<string> repeatCheck = new List<string>();

            foreach(string team in identicalList)
            {
                Console.WriteLine(team);
                if (repeatCheck.Contains(team))
                {
                    Console.WriteLine("This name has been repeated.");
                }
                else
                {
                    Console.WriteLine("This name has not been repeated.");
                }
                repeatCheck.Add(team);
            }
            Console.ReadLine();



            Console.WriteLine("Thanks for playing our games! See you next time.");
            Console.ReadLine();
        }
    }
}
