using System.Text;
using System.IO;

namespace PII_Game_Of_Life{
    public class Printer{
        bool[,] b;
        int width;
        int height;

        public GameBoard Tablero{get; set;}
        public Printer(GameBoard tablero){
            this.Tablero=tablero;
            while (true)
            {
                bool[,] b=this.Tablero.gameBoard;
                int width= this.Tablero.boardWidth;
                int height= this.Tablero.boardHeight;
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
                this.Tablero.NewGen();
                Thread.Sleep(300);
            }
        }
        public void Print(){
            
        }
    }

}