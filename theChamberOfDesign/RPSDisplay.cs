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
            RPSPlayer player1 = new RPSPlayer(p1Name);
            Console.WriteLine("Player two name: ");
            string p2Name = Console.ReadLine() ?? "";
            RPSPlayer player2 = new RPSPlayer(p2Name);
            //create player two
            RPS game = new RPS(player1, player2); //create a new game and start with round 0
            while (true)
            {
                RPSPlay(game);  //sends us into the game.
                DisplayScoreBoard(game);
            }
        }

        public static void RPSPlay(RPS game)
        {

            RPS.TurnOutcome outcome;
            game.Round += 1;
            
            RPS.Weapon player1Choice = RPSTurn(game.Player1);
            RPS.Weapon player2Choice = RPSTurn(game.Player2);
            
            outcome = RPS.RPSEvaluate(player1Choice, player2Choice);
            
            if (outcome == RPS.TurnOutcome.Win)
            {
                Console.WriteLine($"{game.Player1.Name} is the winner of this round! ");
            }
            if (outcome == RPS.TurnOutcome.Lose)
            {
                Console.WriteLine($"{game.Player2.Name} is the winner of this round! ");
            }
            if (outcome == RPS.TurnOutcome.Draw)
            {
                Console.WriteLine($"Well played you two, Round {game.Round} is a draw! ");
            }

            RPS.UpDateScore(outcome, game); //update the score
        }

        public static void DisplayScoreBoard(RPS game)
        {
            Console.WriteLine($"{game.Player1.Name}-[{game.Player1.Wins}] {game.Player2.Name}-[{game.Player2.Wins}]  Draws-[{game.DrawCount}].");
        }

        public static RPS.Weapon RPSTurn(RPSPlayer p)  //this will return the enum called RPS.Weapon, we dont put Enum in the signature
        {
            char input;
            while (true)  //keep asking until sucessful creation of our output
            {
                do Console.WriteLine($"{p.Name} choose your weapon. [R]ock, [P]aper, [S]cissors");
                while (!char.TryParse(Console.ReadLine(), out input));  //did I get a single character (shape of input)
                input = Char.ToLower(input);

                if (input == 'r' || input == 'p' || input == 's')  //the meaning of the input
                {
                    if (input == 'r')
                    {
                        return RPS.Weapon.Rock;
                    }
                    else if (input == 'p')
                    {
                        return RPS.Weapon.Paper;
                    }
                    //verify our char choice and turn the choice into
                    else
                    {
                        return RPS.Weapon.Scissors;
                    }
                }
                else
                {
                    Console.WriteLine("Please choose from 'r', 'p', or 's'");
                }
            }
        }

    }
}
