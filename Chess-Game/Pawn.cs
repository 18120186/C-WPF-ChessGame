using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class Pawn: Unit
    {
        Dictionary<int, int> PossibleMove = new Dictionary<int, int>();

        Pawn()
        {
            //List<int> myPosition = getPosition();
            //PossibleMove.Add(myPosition[0], myPosition[1]);
        }
    }
}
