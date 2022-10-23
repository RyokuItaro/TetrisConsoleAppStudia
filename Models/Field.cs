using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsoleApp.Models
{
    public class Field
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Cell[,] Cells { get; set; }

        public Field(int width, int height)
        {
            Cells = new Cell[width, height];

            for (int i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    Cells[j, i] = new Cell(j, i, '.');
                }
            }
        }

        public void Draw()
        {

        }
    }
}
