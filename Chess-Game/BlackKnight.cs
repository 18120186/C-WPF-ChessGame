using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class BlackKnight : Unit
    {
        public BlackKnight(int Hpos, int Vpos)
        {
            team = 1;
            species = "Knight";
            setPosition(Hpos, Vpos);
        }
    }
}
