using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class WhiteRook: Unit
    {
        public WhiteRook(int Hpos, int Vpos)
        {
            team = 0;
            species = "Rook";
            setPosition(Hpos, Vpos);
        }
    }
}
