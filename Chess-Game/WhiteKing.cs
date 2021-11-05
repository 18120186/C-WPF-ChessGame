using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class WhiteKing : Unit
    {
        public WhiteKing(int Hpos, int Vpos)
        {
            team = 0;
            species = "King";
            setPosition(Hpos, Vpos);
        }
    }
}
