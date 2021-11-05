using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class BlackBishop : Unit
    {
        public BlackBishop(int Hpos, int Vpos)
        {
            team = 1;
            species = "Bishop";
            setPosition(Hpos, Vpos);
        }
    }
}
