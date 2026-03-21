using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace theChamberOfDesign
{
    internal static class RPSDisplay
    {
        //this class displays the game and runs the menu
        public static void RPSStart()
        {
            Console.Title = "Rock, Paper, Scissors";
            Console.WriteLine("Welcome to Rock, Paper, Scissors.");
            Console.WriteLine("Player one name: ");
            string p1Name = Console.ReadLine() ?? "";
            //create player one
            RPSPlayer Player1 = new RPSPlayer(p1Name);
            Console.WriteLine("Player two name: ");
            string p2Name = Console.ReadLine() ?? "";
            RPSPlayer Player2 = new RPSPlayer(p2Name);
            //create player two
            RPS Game = new RPS(0); //create a new game and start with round 0
        }

        public static void RPSPlay()
        {
            //update Round
            var game = RPS.Game;
            //could make a list of players to use
            var p1 = RPSPlayer(Player1);
            
            //foreach could go through the list
            Console.WriteLine($"{p1} choose your weapon. [R]ock, [P]aper, [S]cissors");

            //we could check the outcomes of the battle

            //update round
        }
    }
}
