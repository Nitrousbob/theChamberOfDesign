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
            RPSTurn(game.Player1);
            //could make a list of players to use
            RPSTurn(game.Player2);
            

            //we could check the outcomes of the battle

            //update round
        }

        public static void RPSTurn(RPSPlayer p)
        {
            Console.WriteLine($"{p.Name} choose your weapon. [R]ock, [P]aper, [S]cissors");
            //this is where i thought I should have the player store their selection.
            Console.ReadLine();
        }
    }
}
