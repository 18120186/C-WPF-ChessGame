using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class BlackKing:Unit
    {
        public BlackKing(int Hpos, int Vpos)
        {
            team = 1;
            species = "King";
            setPosition(Hpos, Vpos);
        }
    }
}
