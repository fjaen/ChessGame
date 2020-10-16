using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Entities
{
    public partial class Person
    {
        public Person()
        {
            this.WhiteGames = new List<ChessGame>();
            this.BlackGames = new List<ChessGame>();
            this.GamesIsActivePlayer= new List<ChessGame>();
        }

        public Person(int Age,String Name) :this() {
            this.Name = Name;
            this.Age = Age;
        }
       
    }
}
