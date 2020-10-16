using System;
using System.Collections.Generic;
using System.Data;
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

        public Cell(Colors Color, char Column, char Row)
        {
            this.Row = Row;
            this.Column = Column;
            this.Color = Color;
            this.LocatedAtPiece = null;

        }
        

    }
}
