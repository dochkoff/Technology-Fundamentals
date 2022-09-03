using System;
using System.Threading;

namespace _01_Tetris
{
    class Program
    {
        //Settings
        static int TetrisRows = 30;
        static int TetrisCols = 10;
        static int InfoCols = 10;
        static int ConsoleRows = (1 + TetrisRows + 1);
        static int ConsoleCols = (1 + TetrisCols + 1 + InfoCols + 1);

        //State
        static int Score = 0;

        static void Main(string[] args)
        {
            Console.Title = "Tetris v1.0";
            Console.CursorVisible = false;
            Console.SetWindowSize(40, 40);
            //Console.WindowHeight = ConsoleRows;
            //Console.WindowWidth = ConsoleCols;
            //Console.BufferHeight = ConsoleRows;
            //Console.BufferWidth = ConsoleCols;
            DrawBorder();
            DrawInfo();

            while (true)
            {
                Score++;
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        return; //becouse of Main()
                        // Environment.Exit(0); -> drug variant
                    }
                }
                //Redraw UI
                DrawBorder();
                DrawInfo();
                Thread.Sleep(40);
            }
        }

        static void DrawBorder()
        {
            Console.SetCursorPosition(0, 0);
            string line = "╔";
            line += new string('═', TetrisCols); //tova e ekvivalentno na sledvashtia komentar
            //for (int i = 0; i < tetrisCols; i++)
            //{
            //    line += "═";
            //}

            line += "╦";
            line += new string('═', InfoCols);
            line += "╗";
            Console.WriteLine(line);

            for (int i = 0; i < TetrisRows; i++)
            {
                string middleLine = "║";
                middleLine += new string(' ', TetrisCols);
                middleLine += "║";
                middleLine += new string(' ', TetrisCols);
                middleLine += "║";
                Console.WriteLine(middleLine);
            }

            string endLine = "╚";
            endLine += new string('═', TetrisCols);
            endLine += "╩";
            endLine += new string('═', InfoCols);
            endLine += "╝";
            Console.Write(endLine);
        }

        static void DrawInfo()
        {
            Write("Score:", 1, 3 + TetrisCols);
            Write(Score.ToString(), 2, 3 + TetrisCols);
        }

        static void Write(string text, int row, int col, ConsoleColor color = ConsoleColor.Yellow)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(col, row);
            Console.Write(text);
            Console.ResetColor();
        }
    }
}
