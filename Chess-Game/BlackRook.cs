using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class BlackRook:Unit
    {
        public BlackRook(int Hpos, int Vpos)
        {
            team = 1;
            species = "Rook";
            setPosition(Hpos, Vpos);
        }
    }
}
