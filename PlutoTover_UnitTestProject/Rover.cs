using System;
using System.Collections.Generic;

namespace PlutoTover_UnitTestProject
{
    internal class Rover
    {
        private Position currentPosition;
        private Grid grid;

        private static bool noObstaclesFoundYet = true;
        private static Position copyOfCurrentPosition;

        public Rover(Position newPosition, Grid grid)
        {
            CurrentPosition = newPosition;
            Grid = grid;
        }

        
        internal Position CurrentPosition { get => currentPosition; set => currentPosition = value; } 
        internal Grid Grid { get => grid; set => grid = value; }
        public bool NoObstaclesFoundYet { get => noObstaclesFoundYet; set => noObstaclesFoundYet = value; }

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
            copyOfCurrentPosition = new Position(currentPosition); //remember last position without obstacles

            switch (singleCommand)
            {
                case 'F':
                    {
                        /* when the rover is on the first column of the grid, facing
                         * west and it needs to go forward, the x coordinate
                         * of the rover is reset to the last column of the grid */
                        if (currentPosition.XCoordinate == 0)
                        {
                            currentPosition.XCoordinate = Grid.NumberOfColumns - 1;
                        }
                        else
                            currentPosition.XCoordinate--;
                        break;
                    }
                case 'B':
                    {/* when the rover is on the last column of the grid, facing
                         * west and it needs to go backwards, the x coordinate
                         * of the rover is reset to the first column of the grid */
                        if (currentPosition.XCoordinate == Grid.NumberOfColumns - 1)
                            currentPosition.XCoordinate = 0;
                        else
                            currentPosition.XCoordinate++;
                        break;
                    }
                case 'L':
                    {
                        currentPosition.Orientation = 'S';
                        break;
                    }
                case 'R':
                    {
                        currentPosition.Orientation = 'N';
                        break;
                    }
            }

            if (Grid.ObstaclesPostion != null) {
                var pairOfcurrentCoordinates = new KeyValuePair<int, int>(
                                    currentPosition.XCoordinate,
                                    currentPosition.YCoordinate);

                foreach (var obstacle in Grid.ObstaclesPostion)
                {
                    if (Equals(pairOfcurrentCoordinates, obstacle))
                    {
                        currentPosition = copyOfCurrentPosition;
                        noObstaclesFoundYet = false;
                        break;
                    }
                }
            }
        }

        private void FindeNewPositionFacingEast(char singleCommand)
        {
            copyOfCurrentPosition = new Position(currentPosition); //remember last position without obstacles

            switch (singleCommand)
            {
                case 'F':
                    {
                        /* when the rover is on the last column of the grid, facing
                         * east and it needs to go backwards, the x coordinate
                         * of the rover is reset to the first column of the grid */
                        if (currentPosition.XCoordinate == Grid.NumberOfColumns - 1)
                        {
                            currentPosition.XCoordinate = 0;
                        }
                        else
                            currentPosition.XCoordinate++;
                        break;
                    }
                case 'B':
                    {
                        /* when the rover is on the first column of the grid, facing
                         * east and it needs to go backwards, the x coordinate
                         * of the rover is reset to the last column of the grid */
                        if (currentPosition.XCoordinate == 0)
                        {
                            currentPosition.XCoordinate = Grid.NumberOfColumns - 1;
                        }
                        else
                            currentPosition.XCoordinate--;
                        break;
                    }
                case 'L':
                    {
                        currentPosition.Orientation = 'N';
                        break;
                    }
                case 'R':
                    {
                        currentPosition.Orientation = 'S';
                        break;
                    }
            }
        }

        private void FindNewPositionFacingSouth(char singleCommand)
        {
            copyOfCurrentPosition = new Position(currentPosition); //remember last position without obstacles
            switch (singleCommand)
            {
                case 'F':
                    {
                        /* when the rover is on the first line of the grid, facing
                         * south and it needs to go forward, the y coordinate
                         * of the rover is reset to the last line of the grid */
                        if (currentPosition.YCoordinate == 0)
                        {
                            currentPosition.YCoordinate = Grid.NumberOfLines - 1;
                        }
                        else
                            currentPosition.YCoordinate--;
                        break;
                    }
                case 'B':
                    {
                        /* when the rover is on the last line of the grid, facing
                         * south and it needs to go backwards, the y coordinate
                         * of the rover is reset to the first line of the grid */
                        if (currentPosition.YCoordinate == Grid.NumberOfLines - 1)
                        {
                            currentPosition.YCoordinate = 0;
                        }
                        else
                            currentPosition.YCoordinate++;
                        break;
                    }
                case 'L':
                    {
                        currentPosition.Orientation = 'E'; ;
                        break;
                    }
                case 'R':
                    {
                        currentPosition.Orientation = 'W';
                        break;
                    }
            }
        }

        private void FindNewPositionFacingNorth(char singleCommand)
        {
            copyOfCurrentPosition = new Position(currentPosition); //remember last position without obstacles

            switch (singleCommand)
            {
                case 'F':
                    {
                        /* when the rover is on the last line of the grid, facing
                         north and it needs to go forward, the y coordinate
                         of the rover is reset to 0 */
                        if (currentPosition.YCoordinate == Grid.NumberOfLines - 1)
                        {
                            currentPosition.YCoordinate = 0;
                        }
                        else
                            currentPosition.YCoordinate++;
                        break;
                    }
                case 'B':
                    {
                        /* when the rover is on the first line of the grid, facing
                         * north and it needs to go backwards, the y coordinate
                         * of the rover is reset to the last line of the grid */
                        if (currentPosition.YCoordinate == 0)
                        {
                            currentPosition.YCoordinate = Grid.NumberOfLines - 1;
                        }
                        else
                            currentPosition.YCoordinate--;
                        break;
                    }
                case 'L':
                    {
                        currentPosition.Orientation = 'W';
                        break;
                    }
                case 'R':
                    {
                        currentPosition.Orientation = 'E';
                        break;
                    }
            }
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