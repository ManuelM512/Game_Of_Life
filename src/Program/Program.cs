using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            //Que el gameboard pueda ser creado por diferentes maneras
            GameBoard tablero = new GameBoard();
            Printer impr = new Printer(tablero);
        }
    }
}