using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class WhitePawn: Unit
    {
        public WhitePawn(int Hpos, int Vpos)
        {
            team = 0;
            species = "Pawn";
            setPosition(Hpos, Vpos);
        }
    }
}
