using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class WhiteQueen : Unit
    {
        public WhiteQueen(int Hpos, int Vpos)
        {
            team = 0;
            species = "Queen";
            setPosition(Hpos, Vpos);
        }
    }
}
