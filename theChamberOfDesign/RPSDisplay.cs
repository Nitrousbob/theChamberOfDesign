using System;
using System.Collections.Generic;
using System.Text;

namespace theChamberOfDesign
{
    internal class RPSDisplay
    {
        //this class displays the game and runs the menu
        public void RPSStart()
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
        }
    }
}
