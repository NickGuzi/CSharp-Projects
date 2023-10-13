using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            //GAME ONE
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
                
                while (true)
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

            //GAME TWO

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

            for(int x = 0; x < userList.Count; x++)
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

            //GAME THREE

            Console.WriteLine("Okay this one is going to be real easy...");
            Console.ReadLine();

            int[] nums = { 66, 42, 19, 48, 33, 99, 1032, 1221, 1456 };

            while (true)
            {
                Console.WriteLine("Pick a number between 0 and 8 to see that position's number");
                var number = int.Parse(Console.ReadLine());

                if (number > 8 || number < 0)
                {
                    Console.WriteLine("You must pick a number between 0 and 8...");
                }
                else
                {
                    Console.WriteLine("The number with this position is: " + nums[number]);
                }

                Console.WriteLine("Want pick another number? Press 1 to pick again or 0 to not...");
                var listChoice3 = int.Parse(Console.ReadLine());

                if (listChoice3 == 1)
                {
                    Console.WriteLine("Okay lets pick another number");
                }
                else
                {
                    break;
                }

            }


            Console.WriteLine("Thanks for participating, see you next time!");
            Console.ReadLine();

        }
    }
}
