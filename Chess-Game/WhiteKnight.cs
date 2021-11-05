using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class WhiteKnight: Unit
    {
        public WhiteKnight(int Hpos, int Vpos)
        {
            team = 0;
            species = "Knight";
            setPosition(Hpos, Vpos);
        }
    }
}
