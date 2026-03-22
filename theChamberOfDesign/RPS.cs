using System.Net.NetworkInformation;

namespace theChamberOfDesign
{
    internal class RPS
    {
        public int Round { get; set; } = 0;
        public int DrawCount { get; set; } = 0;
        public RPSPlayer Player1 { get; }
        public RPSPlayer Player2 { get; }

        public enum Weapon
        {
            Rock,
            Paper,
            Scissors
        }

        public enum TurnOutcome
        {
            Win,
            Lose,
            Draw
        }

        public RPS(RPSPlayer player1, RPSPlayer player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public static RPS.TurnOutcome RPSEvaluate(RPS.Weapon c1, RPS.Weapon c2)
        {
            if (c1 != c2)
            {
                //if (c1 == RPS.Weapon.Rock && c2 == RPS.Weapon.Paper) { return RPS.TurnOutcome.Lose; }  //referring to the first player
                //if (c1 == RPS.Weapon.Paper && c2 == RPS.Weapon.Rock) { return RPS.TurnOutcome.Win; } //paper beats rock
                //if (c1 == RPS.Weapon.Scissors && c2 == RPS.Weapon.Paper) { return RPS.TurnOutcome.Win; } //scissors beats paper
                //if (c1 == RPS.Weapon.Paper && c2 == RPS.Weapon.Scissors) { return RPS.TurnOutcome.Lose; } // paper lose to scissors
                //if (c1 == RPS.Weapon.Scissors && c2 == RPS.Weapon.Rock) { return RPS.TurnOutcome.Lose; } //scissors lose to rock
                //if (c1 == RPS.Weapon.Rock && c2 == RPS.Weapon.Scissors) { return RPS.TurnOutcome.Win; } //rock beats scissors
                //return RPS.TurnOutcome.Draw;  //return draw if no other option
                //we can flip the outcome for the other player

                switch (c1)
                {
                    case Weapon.Rock:
                        if (c2 == Weapon.Paper)
                        { return RPS.TurnOutcome.Lose; }
                        else
                            return RPS.TurnOutcome.Win;
                    case Weapon.Paper:
                        if (c2 == Weapon.Rock)
                        { return RPS.TurnOutcome.Win; }
                        else
                            return RPS.TurnOutcome.Lose;
                    case Weapon.Scissors:
                        if (c2 == Weapon.Rock)
                        { return RPS.TurnOutcome.Lose; }
                        else
                            return RPS.TurnOutcome.Win;
                }
            }
            return RPS.TurnOutcome.Draw;
        }

        public static void UpDateScore(RPS.TurnOutcome outcome, RPS game)
        {

            if (outcome == TurnOutcome.Win)
            {
                game.Player1.Wins += 1;
            }
            else if (outcome == TurnOutcome.Lose)
            {
                game.Player2.Wins += 1;
            }
            else
            {
                game.DrawCount++;
            }
        }
    }
}
