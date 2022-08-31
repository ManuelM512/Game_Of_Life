using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            //Que el gameboard pueda ser creado por diferentes maneras
            Reader lector = new Reader();
            GameBoard tablero = new GameBoard(lector.board);
            Printer impr = new Printer(tablero);
        }
    }
}