using System.Text;
using System.IO;

namespace PII_Game_Of_Life{
    public class Printer{
        public Printer(GameBoard tablero){
            while (true)
            {
                bool[,] b=tablero.gameBoard;
                int width= tablero.boardWidth;
                int height= tablero.boardHeight;
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<height;y++)
                {
                    for (int x = 0; x<width; x++)
                    {
                        if(b[x,y])
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
                tablero.NewGen();
                Thread.Sleep(300);
            }
        }
    }

}