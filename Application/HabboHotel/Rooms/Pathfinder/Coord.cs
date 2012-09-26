using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Revolution.Application.HabboHotel.Rooms.Pathfinder
{
    public class Coord
    {
        public int X;
        public int Y;

        public int PositionDistance;
        public int ReversedPositionDistance;

        public Coord(int x, int y)
        {
            X = x;
            Y = y;
            PositionDistance = 1000;
            ReversedPositionDistance = 1000;
        }
    }
}
