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
            RPS Game = new RPS(Player1, Player2); //create a new game and start with round 0
            RPSPlay(Game);  //sends us into the game.
        }

        public static void RPSPlay(RPS game)
        {
            //update Round
            game.Round += 1;
            Console.WriteLine($"Round {game.Round}!");
            RPS.Weapon player1Choice = RPSTurn(game.Player1);
            //could make a list of players to use
            RPS.Weapon player2Choice = RPSTurn(game.Player2);
            

            //we could check the outcomes of the battle

            //update round
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
