using System;
using System.Collections.Generic;
using System.Text;

namespace theChamberOfDesign
{
    //two human players compete against each other
    //each player picks rock, paper, or scissors
    //evaluate, rock beats scissors, paper beats rock, scissors beat paper
    //if both players pick the same option its a draw
    //must display who won the round
    //the game will keep running rounds until the window is closed but must remember
    //the historical record of how many times each player won and how many draws there were

    //does not need to be a full game, just a potential design as a starting point
    internal class RPS
    {
        public int Round { get; set; }
        

        public RPS(int round = 0)
        {
            Round = round;
        }


    }
}
