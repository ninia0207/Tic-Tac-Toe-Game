using System;
using System.Diagnostics;
using TicTacToe.Implementations;

namespace L2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            bool enterNewNames = true;
            var player1 = new Player('X');
            var player2 = new Player('O');
            
            int counter = 0;

            do
            {
                if (enterNewNames)
                {
                    enterNewNames = false;

                    Console.Write("Enter player 1(X) name: ");
                    var player1Name = Console.ReadLine();
                    player1.SetPlayerName(player1Name);

                    Console.Write("Enter player 2(O) name: ");
                    var player2Name = Console.ReadLine();
                    player2.SetPlayerName(player2Name);

                }

                var tictactoe = new Game(player1, player2);
                var board = new Board();
                tictactoe.GameBoard = new char[3, 3];
                bool isWin = false;
                
                do
                {
                    //Drawing the Board
                    board.DrawGameBoard(tictactoe.GameBoard);

                    if(counter % 2 == 1)
                    {
                        Console.WriteLine($"{player2.Name}'s move.");
                    }
                    else
                    {
                        Console.WriteLine($"{player1.Name}'s move.");
                    }

                    //User Input Indicies
                    Console.Write("Enter the row index: ");
                    var row = int.Parse(Console.ReadLine());

                    Console.Write("Enter the column index: ");
                    var col = int.Parse(Console.ReadLine());

                    isWin = tictactoe.PlayerMove(counter % 2 == 1 ? player2 : player1, row, col);
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write($"{tictactoe.GameBoard[i, j]}  ");
                        }
                        Console.WriteLine();
                    }
                    Console.Clear();
                    counter++;

                    bool isDraw = tictactoe.IsGameDraw(counter);
                    if (isDraw)
                    {
                        isWin = false;
                        Console.WriteLine("The game is draw.");
                        counter = 0;
                        Console.WriteLine("Press Enter");
                        break;
                    }

                } while (!isWin);

                if (isWin)
                {
                    var winPlayer = (counter - 1) % 2 == 1 ? player2 : player1;

                    Console.WriteLine("Name: " + winPlayer.Name);
                    Console.WriteLine("X_Or_O: " + winPlayer.X_Or_O);

                    winPlayer.SetPlayerWinCount(++winPlayer.WinCount);
                    Console.WriteLine("WinCount: " + winPlayer.WinCount);
                }

                
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Play Again ? (y, n)");
                string choice = Console.ReadLine();
                
                Console.Clear();

                if (choice.ToLowerInvariant() == "n")
                {
                    counter = 0;
                    break;
                }

                Console.WriteLine("Enter new names? (y, n)");
                string choiceNewName = Console.ReadLine();

                if (choiceNewName.ToLowerInvariant() == "y")
                {
                    enterNewNames = true; 
                }

                


            } while (true);

        }

        
    }
}
