using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    class Player
    {

        public int Col;
        public int Row;
        public string Symbol;

        public Player(int Row, int Col, string Symbol)
        {
            this.Row = Row;
            this.Col = Col;
            this.Symbol = Symbol;
        }

        public void PrintPlayer(int Row, int Col, string Symbol)
        {
            this.Row = Row;
            this.Col = Col;
            this.Symbol = Symbol;
            Console.SetCursorPosition(this.Col, this.Row);
            Console.WriteLine(Symbol);
        }

    }
}
