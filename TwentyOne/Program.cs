﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        //This comment is for testing 

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack. Let's start by telling me your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money do you want to play with?");
            var bank = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of BlackJack right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();

        }
    }
}
