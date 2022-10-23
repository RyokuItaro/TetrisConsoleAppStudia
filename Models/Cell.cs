using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsoleApp.Models
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char State { get; set; }

        public Cell(int x, int y, char state)
        {
            X = x;
            Y = y;
            State = state;
        }
    }
}
