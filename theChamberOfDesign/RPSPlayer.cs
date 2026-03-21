using System;
using System.Collections.Generic;
using System.Text;

namespace theChamberOfDesign
{
    internal class RPSPlayer
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Draw {  get; set; }
        public enum Weapon
        {
            Rock,
            Paper,
            Scissors
        }

        public RPSPlayer(string name) 
        {
            Name = name;
            Score = 0;
            Draw = 0;
        }

    }
}
