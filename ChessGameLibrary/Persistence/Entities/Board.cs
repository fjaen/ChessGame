using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Entities
{
    public partial class Board
    {
        public virtual ICollection<Cell> Cells
        {
            get;
            set;
        }
    }
}
