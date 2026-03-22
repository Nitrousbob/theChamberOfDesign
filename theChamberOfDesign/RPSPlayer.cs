namespace theChamberOfDesign
{
    internal class RPSPlayer
    {
        public string Name { get; private set; }
        public int Wins { get; set; } = 0;

        public RPSPlayer(string name)
        {
            Name = name;
        }

    }
}
