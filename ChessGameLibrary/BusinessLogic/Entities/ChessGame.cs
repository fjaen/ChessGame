using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Entities
{
    public partial class ChessGame
    {

        public ChessGame(DateTime EllapsedTime, Person ActivePlayer, 
            Person BlackPlayer, Board GameBoard, Person WhitePlayer)
        {
            this.EllapsedTime = EllapsedTime;
            this.ActivePlayer = ActivePlayer;
            this.BlackPlayer = BlackPlayer;
            this.WhitePlayer = WhitePlayer;
            this.GameBoard = GameBoard;
        }
        public void foo()
        {
            Piece p = new King(Colors.Black);
            p.Draw();
        }
    }

   
}
