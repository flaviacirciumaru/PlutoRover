# PlutoRover
TDD based project that simulates the grid of a planet and allows a rover to move around the grid with simple commands such as left, right, forward, backward.

The project was implemented strictly in C#, using UnitTest template. 

The solution implied at first thinking about the postential tests one might need to make in order to move the rover from one point to another. The position, the grid and the rover itself have been constructed as classes in order to encapsulate the solution in such way that it would be easier to understand from an outside perspective.

The Grid class has information about the number of lines, number of columns and the positions (pairs of <x,y> coordinates) of the obstacles placed on the grid.

The Position class has information about the X coordinate, the Y coordinate and the orientation of the rover at a particular moment.

The Rover class has most of the logic behind the rover next move. The Move method has been implemented as followed:
  1. Verify at first the validity of the single-letter command.
  2. Based on where the rover was facing (E - East, W - West, S - South, N - North), the next command would influence its <x,y> coordinates differently. Therefore, each case was treated in different functions.
  3. Given that, accordingly to the problem statement, once the code is committed, there is no turning back, I tried to foresee the next steps towards implementation when there was space for interpretation.
  4. Once the potential next position is found, obstacles coordinates are reported on the grid and are compared to the posible next position of the rover. If both are the same, then the rover remains located on the last valid position and no longer follows the next moves.
  
  The following tests were treated:
    1. A standard single move on the grid, with no expectations to encouter the edges of the grid.
    2. A standard rotation on the same spot.
    3. A standard single move on the grid, edge expected.
    4. Retreat on the last valid position if obstacle is found.
    5. Following multiple-letter commands, expecting no obstacles.
    6. Following multiple-letter commands, expecting obstacles.
  
