using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            string[] hockeyTeams = { "Bruins", "Capitals", "Maple Leafs", "Hurricanes", "Rangers", "Stars" };

            Console.WriteLine("Please select a number between 0 and 5 to get a hockey team...");
            var selection = int.Parse(Console.ReadLine());

            if (selection < 0 || selection > 5)
            {
                Console.WriteLine("You must select a number between 0 and 5...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(hockeyTeams[selection].ToString());
                Console.ReadLine();
            }

            Console.WriteLine("Want to guess again? Press 1 for yes and 0 for no...");
            var choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                int i = 0;
                while (i < 10)
                {
                    Console.WriteLine("Please select a number between 0 and 5 to get a hockey team...");
                    var secondSelection = int.Parse(Console.ReadLine());

                    if (secondSelection < 0 || secondSelection > 5)
                    {
                        Console.WriteLine("You must select a number between 0 and 5...");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(hockeyTeams[secondSelection].ToString());
                        Console.ReadLine();
                    }

                    Console.WriteLine("Want to guess again? Press 1 to continue or 0 to stop...");
                    var secondChoice = int.Parse(Console.ReadLine());

                    if (secondChoice == 1)
                    {
                        Console.WriteLine("Okay lets go again!");
                    }
                    else
                    {
                        break;
                    }

                }
            }

            Console.WriteLine("Thank you for playing our first guessing game, press enter to continue...");
            Console.ReadLine();

            List<string> userList = new List<string>();
            int j = 0;

            Console.WriteLine("Now we're going to let you create a list...");

            while (j < 1000)
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

            for(int x = 0; x < userList.Count; x++)
            {
                Console.WriteLine(userList[x]);
            }

            Console.ReadLine();

            Console.WriteLine("Thanks for participating, see you next time!");
            Console.ReadLine();

        }
    }
}
