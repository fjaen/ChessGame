using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Entities
{
    public abstract partial class Piece
    {
        public Piece(Colors Color)
        {
            this.Color = Color;
            LocatedAt = null;
        }
        public abstract void Draw();
        public abstract bool IsValidMovement(Cell origin,Cell destination);
    }
}
