using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiseOfEmpires
{
    public class Player
    {
        public event EventHandler OnTurnStart;
        public event EventHandler OnTurnEnd;

        public IEnumerable<LandTile> PossesiontLandTiles
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}