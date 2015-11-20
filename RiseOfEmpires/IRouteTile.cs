using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiseOfEmpires
{
    public interface IRouteTile
    {
        Tile ConnectedRouteTileA { get; set; }
        Tile ConnectedRouteTileB { get; set; }
        Tile GetLastRouteConnectedSideA();
        Tile GetLastRouteConnectedSideB();
    }
}