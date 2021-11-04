using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class Unit
    {
        private int HorizontalPosition = new int();
        private int VerticalPostition = new int();

        public List<int> getPosition()
        {
            List<int> pos = new List<int>() { VerticalPostition, HorizontalPosition };
            return pos;
        }
    }
}
