using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Entities
{
    public abstract partial class Piece
    {
        public Colors Color
        {
            get;
            set;
        }
        public virtual Cell? LocatedAt
        {
            get;
            set;
        }

        
    }
}
