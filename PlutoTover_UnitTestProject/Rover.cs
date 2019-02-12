using System;

namespace PlutoTover_UnitTestProject
{
    internal class Rover
    {
        private Position currentPosition;
        private Grid grid;

        private static bool noObstaclesFoundYet = true;

        public Rover(Position newPosition, Grid grid)
        {
            CurrentPosition = newPosition;
            Grid = grid;
        }

        
        internal Position CurrentPosition { get => currentPosition; set => currentPosition = value; } 
        internal Grid Grid { get => grid; set => grid = value; }
        public static bool NoObstaclesFoundYet { get => noObstaclesFoundYet; set => noObstaclesFoundYet = value; }

        internal void Move(char singleCommand)
        {
            VerifyIfCommandHasValidLetter(singleCommand);

            if (NoObstaclesFoundYet)
            {
                switch (CurrentPosition.Orientation)
                {
                    case 'N':
                        {
                            FindNewPositionFacingNorth(singleCommand);
                            break;
                        }
                    case 'S':
                        {
                            FindNewPositionFacingSouth(singleCommand);
                            break;
                        }
                    case 'E':
                        {
                            FindeNewPositionFacingEast(singleCommand);
                            break;
                        }
                    case 'W':
                        {
                            FindNewPositionFacingWest(singleCommand);
                            break;
                        }
                }
            }
        }

        private void FindNewPositionFacingWest(char singleCommand)
        {
            throw new NotImplementedException();
        }

        private void FindeNewPositionFacingEast(char singleCommand)
        {
            throw new NotImplementedException();
        }

        private void FindNewPositionFacingSouth(char singleCommand)
        {
            throw new NotImplementedException();
        }

        private void FindNewPositionFacingNorth(char singleCommand)
        {
            throw new NotImplementedException();
        }

        private void VerifyIfCommandHasValidLetter(char singleCommand)
        {
            if (!Equals(singleCommand, 'F') && !Equals(singleCommand, 'B')
                && !Equals(singleCommand, 'L') && !Equals(singleCommand, 'R'))
            {
                throw new Exception("Rover can accept only F(forward)," +
                    " B(backward), L (left) or R (right) commands." +
                    "Please type a valid character.");
            }
        }
    }
}