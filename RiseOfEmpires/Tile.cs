using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiseOfEmpires
{
    public class Tile
    {
        public Tile Side1 { get; set; }
        public Tile Side2 { get; set; }
        public Tile Side3 { get; set; }
        public Tile Side4 { get; set; }
        public Tile Side5 { get; set; }
        public Tile Side6 { get; set; }


        public IEnumerable<Tile> GetAllSides()
        {
            yield return Side1;
            yield return Side2;
            yield return Side3;
            yield return Side4;
            yield return Side5;
            yield return Side6;
        }

        public IEnumerable<Tile> GetAllUsedSides()
        {
            return GetAllSides().Where(tile => tile != null);
        }

        public virtual void PerformTurnAction()
        {
            
        }
    }
}