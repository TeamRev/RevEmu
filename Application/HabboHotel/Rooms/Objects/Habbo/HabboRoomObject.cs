using System.Collections.Generic;
using System.Drawing;

namespace Revolution.Revision.R63B.Game.Rooms.Objects.Habbo
{
    public class HabboRoomObject
    {
        internal int HabboId
        {
            get;
            private set;
        }

        internal int RoomId
        {
            get;
            private set;
        }

        internal int X
        {
            get;
            set;
        }

        internal int Y
        {
            get;
            set;
        }

        internal double Z
        {
            get;
            private set;
        }

        internal int GoalX
        {
            get;
            set;
        }

        internal int GoalY
        {
            get;
            set;
        }

        public Point Point
        {
            get
            {
                return new Point(X, Y);
            }
        }

        public int TilesWalked
        {
            get;
            private set;
        }

        public int Rotation
        {
            get;
            set;
        }

        public HabboRoomObject(int hId, int rId, Point Location)
        {
            HabboId = hId;
            RoomId = rId;
            this.X = Location.X;
            this.Y = Location.Y;
            this.Z = Z;
            this.TilesWalked = 0;
            this.Rotation = 0;

        }
    }
}