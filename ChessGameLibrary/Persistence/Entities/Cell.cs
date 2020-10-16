using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Entities
{
    public enum Colors
    {
        Black = 0,
        White = 1
    }

    public partial class Cell
    {
        

        public char Row
        {
            get;
            set;
        }
        public char Column
        {
            get;
            set;
        }
        public Colors Color
        {
            get;
            set;
        }
        public virtual Piece? LocatedAtPiece
        {
            get;
            set;
        }

    }
}
