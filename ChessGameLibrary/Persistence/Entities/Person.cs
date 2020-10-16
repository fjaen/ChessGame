using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Entities
{
    public partial class Person
    {
        public String Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public virtual ICollection<ChessGame> BlackGames
        {
            get;
            set;
        }
        public virtual ICollection<ChessGame> WhiteGames
        {
            get;
            set;
        }
        public virtual ICollection<ChessGame> GamesIsActivePlayer
        {
            get;
            set;
        }
    }
}
