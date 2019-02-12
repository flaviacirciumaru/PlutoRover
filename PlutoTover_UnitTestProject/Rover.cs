namespace PlutoTover_UnitTestProject
{
    internal class Rover
    {
        private Position initialPosition;
        private Grid grid;

        public Rover(Position initialPosition, Grid grid)
        {
            this.initialPosition = initialPosition;
            this.grid = grid;
        }
    }
}