using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Entities
{
    public partial class ChessGame
    {
        public DateTime EllapsedTime
        {
            get;
            set;
        }
        public virtual Person ActivePlayer
        {
            get;
            set;
        }

        public virtual Person BlackPlayer
        {
            get;
            set;
        }
        public virtual Person WhitePlayer
        {
            get;
            set;
        }
        public virtual Board GameBoard
        {
            get;
            set;
        }
    }

   
}
