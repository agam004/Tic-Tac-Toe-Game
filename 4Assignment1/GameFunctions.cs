using System;

namespace _4Assignment1
{
    internal class GameFunctions
    {
        public static string currentPlayer = "O"; // Initialize to "O"
        public static string[,] gameBoard = {
            { "", "", "" },
            { "", "", "" },
            { "", "", "" }
        };//initialize GameBoard
        public static bool WinnerFound = false;//Other Flags
        public static bool gameTie = true;
        public static bool gameOver = false;



        public static string StartGame(int boxTag)
        {
            if (boxTag > 0 && boxTag <= 9) // Ensure boxTag is within valid range
            {
                int row = (boxTag - 1) / 3; // 0-based row index
                int col = (boxTag - 1) % 3; // 0-based column index
                string thisUser = currentPlayer;

                // Check if the cell is empty before placing the symbol
                if (gameBoard[row, col] == "")
                {
                    // Place the current player's symbol (O or X) in the array
                    gameBoard[row, col] = currentPlayer;

                    // Switch to the other player
                    currentPlayer = (currentPlayer == "O") ? "X" : "O";
                    WinnerFound = EndGame();//Check if anyone win
                    gameTie = CheckTie();//Check if its a tie
                        return thisUser;//Send current player name
                }
                return null;
                
            }
            else
            {
                return null;
            }
        }
        public static bool EndGame()
        {
            //check Rows
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[i, 0] == gameBoard[i, 1] && gameBoard[i, 1] == gameBoard[i, 2] && gameBoard[i, 0] != "")
                {
                    return true; 
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[0, i] == gameBoard[1, i] && gameBoard[1, i] == gameBoard[2, i] && gameBoard[0, i] != "")
                {
                    return true;
                }
            }

            // Check diagonals
            if (gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 2] && gameBoard[0, 0] != "")
            {
                return true;
            }

            if (gameBoard[0, 2] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 0] && gameBoard[0, 2] != "")
            {
                return true; 
            }
            return false;
        }
        public static bool CheckTie()
        {
            bool tie = true;//Default true
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (gameBoard[i, j] == "") 
                    {
                        tie =  false;//if any cell is empty then flag that still continue
                    }
                }
            }
            return tie;//if true means no cell is empty means tie
        }
    }
}
