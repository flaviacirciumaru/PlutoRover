namespace PlutoTover_UnitTestProject
{
    internal class Rover
    {
        private Position currentPosition;
        private Grid grid;

        public Rover(Position newPosition, Grid grid)
        {
            CurrentPosition = newPosition;
            Grid = grid;
        }

        
        internal Position CurrentPosition { get => currentPosition; set => currentPosition = value; } 
        internal Grid Grid { get => grid; set => grid = value; }

    }
}