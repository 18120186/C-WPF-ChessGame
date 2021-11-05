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

        public Unit PhongTot(string unitName)
        {
            if(unitName == "Rook")
            {
                Unit newUnit = new WhiteRook();
                return newUnit;
            }
            else if (unitName == "Knight")
            {
                Unit newUnit = new WhiteKnight();
                return newUnit;
            }
            else if (unitName == "Bishop")
            {
                Unit newUnit = new WhiteBishop();
                return newUnit;
            }
            else if (unitName == "Queen")
            {
                Unit newUnit = new WhiteQueen();
                return newUnit;
            }
            else
            {
                //Do nothing
            }
            return null;
        }
    }
}
