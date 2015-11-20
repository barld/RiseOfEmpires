using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiseOfEmpires
{
    public class SeaRouteTile : SeaTile, IRouteTile
    {
        /// <summary>
        /// may not be null
        /// </summary>
        public Tile ConnectedRouteTileA { get; set; }
        /// <summary>
        /// may not be null
        /// </summary>
        public Tile ConnectedRouteTileB { get; set; }

        /// <remarks>Recursive method</remarks>
        public Tile GetLastRouteConnectedSideA()
        {
            if (this.ConnectedRouteTileA is IRouteTile)
                return (this.ConnectedRouteTileA as IRouteTile).GetLastRouteConnectedSideA();
            else
                return this.ConnectedRouteTileA;
        }

        /// <remarks>Recursive method</remarks>
        public Tile GetLastRouteConnectedSideB()
        {
            if (this.ConnectedRouteTileB is IRouteTile)
                return (this.ConnectedRouteTileB as IRouteTile).GetLastRouteConnectedSideB();
            else
                return this.ConnectedRouteTileB;
        }
    }
}