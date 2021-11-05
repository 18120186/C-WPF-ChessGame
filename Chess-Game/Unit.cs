using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class Unit
    {
        private int x = new int();
        private int y = new int();
        public int team = new int();
        public string species = "";
        public List<int> getPosition()
        {
            List<int> pos = new List<int>() { x, y };
            return pos;
        }
        public void setPosition(int Hpos, int Vpos)
        {
            x = Hpos;
            y = Vpos;
        }

        public string getPositionID()
        {
            string ID = x.ToString() + y.ToString();
            return ID;
        }
        //public Unit PhongTot(string unitName)
        //{
        //    if(unitName == "Rook")
        //    {
        //        Unit newUnit = new WhiteRook();
        //        return newUnit;
        //    }
        //    else if (unitName == "Knight")
        //    {
        //        Unit newUnit = new WhiteKnight();
        //        return newUnit;
        //    }
        //    else if (unitName == "Bishop")
        //    {
        //        Unit newUnit = new WhiteBishop();
        //        return newUnit;
        //    }
        //    else if (unitName == "Queen")
        //    {
        //        Unit newUnit = new WhiteQueen();
        //        return newUnit;
        //    }
        //    else
        //    {
        //        //Do nothing
        //    }
        //    return null;
        //}
    }
}
