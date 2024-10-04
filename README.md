Tic-Tac-Toe Game
This is a Windows Forms-based Tic-Tac-Toe game developed using C# in Visual Studio 2022. The project features a two-player turn-based system where the game starts with player O. Players take turns clicking on the grid to place their marks (X or O), and the game will declare the winner, tie, or reset for the next round.

Features
Two-player mode: The game is played between two players (O and X).
Turn-based system: Players alternate turns, starting with player O.
Game status tracking: The current player is displayed and updated after each move.
Win/Tie detection: The game detects wins or ties and announces the result via a message box.
Game reset: After each game (win/tie), the board resets automatically for the next round.
Winner history: Keeps a list of winners and ties for the session, with a count of games played.
Project Structure
Components
Windows Forms UI: A simple UI made with Windows Forms, using PictureBox controls to represent the Tic-Tac-Toe grid.
Game Logic: Managed by the GameFunctions class, which handles player turns, checking for wins or ties, and updating the game board.
Files
Form1.cs:

Manages the main form where the game UI is implemented and integrates game logic.
Handles player moves and updates the game status (current player, winner, tie).
Implements event handlers for clicking the grid, resetting the game, and closing the application.
GameFunctions.cs:

Handles core game logic, including tracking the current player, checking for wins, and detecting ties.
Optimized methods for win and tie detection:
EndGame(): Determines if a player has won by checking all rows, columns, and diagonals.
CheckTie(): Verifies if the board is fully occupied and declares a tie if no winner is found.
StartGame(): Manages the player's move, updates the game board, and switches turns.
Resources: Contains images for Player X and Player O, used to visually distinguish between the two players on the grid.

How to Run the Game
Clone the repository to your local machine or download the ZIP file.

bash
Copy code
git clone https://github.com/yourusername/tic-tac-toe.git
Open the project in Visual Studio 2022.

Build and run the solution by pressing F5 or using the Run button in Visual Studio.

The game window will launch, and the game will start with player O.

Click on any empty box to place your symbol (O or X).

The game will declare a winner or tie after each round, and the board will reset for the next game.

How the Game Works
The game uses a 3x3 grid of PictureBox controls to represent the Tic-Tac-Toe board.
Players click on a box to place their symbol (X or O), which updates the box's image accordingly.
Win conditions: The game checks all rows, columns, and diagonals for three identical symbols to declare a winner.
Tie conditions: If all boxes are filled and no player has won, the game declares a tie.
Winner list: The game maintains a list of winners and ties, displayed in the ListBox control.
Reset and Close Buttons
Reset Button: Resets the game board manually and starts a new game.
Close Button: Closes the application.
Prerequisites
Visual Studio 2022 with .NET Framework support
Basic understanding of C# and Windows Forms
Future Enhancements
Add single-player mode with AI.
Improve the UI with more customization options (e.g., themes or player icons).
Add sound effects or animations for a more engaging experience.
Implement tracking statistics (e.g., win percentages for each player).
License
This project is licensed under the MIT License - see the LICENSE file for details
