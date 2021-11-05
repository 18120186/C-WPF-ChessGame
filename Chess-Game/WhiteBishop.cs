using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class WhiteBishop: Unit
    {
        public WhiteBishop(int Hpos, int Vpos)
        {
            team = 0;
            species = "Bishop";
            setPosition(Hpos, Vpos);
        }
    }
}
