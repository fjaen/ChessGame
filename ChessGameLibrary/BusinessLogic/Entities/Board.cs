using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessGame.Entities
{
    public partial class Board
    {
        public Board()
        {
            this.Cells = new List<Cell>();
        }
        public Board(ICollection<Cell> Cells):this()
        {
            //Restrictions could be verified using OCL
            //e.g. 64 Cells with correct Rows and Columns
            // Adding Cells...
            this.Cells = Cells.ToList<Cell>();
        }

    }
}
