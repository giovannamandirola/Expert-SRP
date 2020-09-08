using System;
using System.Text;
using System.Threading;

namespace Library
{
    public class ImprimirTablero
    {
        public static void ImprimirConsola (GameBoard g) 
        {
            int width = g.gameBoard.GetLength(0);
            int height = g.gameBoard.GetLength(1);
            
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<height;y++)
                {
                    for (int x = 0; x<width; x++)
                    {
                        if(g.gameBoard[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());

                g.NewGameBoard();
                
            Thread.Sleep(300);
            }
        }
       
    }
}
