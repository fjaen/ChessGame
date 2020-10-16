using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Entities
{
    public partial class Tower:Piece
    {
        public Tower(Colors Color) : base(Color)
        {

        }
        public override void Draw()
        {
            //Implementation of draw method
        }
        public override bool IsValidMovement(Cell origin, Cell destination)
        {
            return false;

        }
    }
}
