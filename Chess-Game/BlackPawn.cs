using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class BlackPawn: Unit
    {
        public BlackPawn(int Hpos, int Vpos)
        {
            team = 1;
            species = "Pawn";
            setPosition(Hpos, Vpos);
        }
        Dictionary<int, int> PossibleMove = new Dictionary<int, int>();

    }
}
