using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Revolution.Revision.R63B.Game.Rooms.Model.HeightMap.Tilestate;
using Revolution.Revision.R63B.Game.Rooms.Model.HeightMap;
using Mango.Communication.Sessions;
using Revolution.Revision.R63B.Game.Rooms.Objects.Habbo;

namespace Revolution.Application.HabboHotel.Rooms.Pathfinder
{
    public class Pathfinder
    {
        private Point[] AvaliablePoints;

        private int MapSizeX = 0;
        private int MapSizeY = 0;

        private TileState[,] Squares;

        private HabboRoomObject User;

        public int GoX;
        public int GoY;

        public Pathfinder(Heightmap Map, HabboRoomObject Session)
        {
            AvaliablePoints = new Point[]
				{ 
				new Point(0, -1),
				new Point(0, 1),
				new Point(1, 0),
				new Point(-1, 0),
				new Point(1, -1),
				new Point(-1, 1),
				new Point(1, 1),
				new Point(-1, -1)
				};

            MapSizeX = Map.SizeX;
            MapSizeY = Map.SizeY;
            Squares = Map.TileStates;

            this.User = Session;
        }

        public List<Coord> PathCollection()
        {
            List<Coord> CoordSquares = new List<Coord>();

            int UserX = User.X;
            int UserY = User.Y;

            GoX = User.GoalX;
            GoY = User.GoalY;

            Coord LastCoord = new Coord(-200, -200);
            int Trys = 0;

            while (true)
            {
                Trys++;
                int StepsToWalk = 10000;
                foreach (Point MovePoint in AvaliablePoints)
                {
                    int newX = MovePoint.X + UserX;
                    int newY = MovePoint.Y + UserY;

                    if (newX >= 0 && newY >= 0 && MapSizeX > newX && MapSizeY > newY && Squares[newX, newY] == TileState.Open/* && !User.getRoomUser().getCurrentRoom().CheckUserCoordinates(User, newX, newY) && !CheckFurniCoordinates(newX, newY)*/)
                    {
                        Coord pCoord = new Coord(newX, newY);
                        pCoord.PositionDistance = DistanceBetween(newX, newY, GoX, GoY);
                        pCoord.ReversedPositionDistance = DistanceBetween(GoX, GoY, newX, newY);

                        if (StepsToWalk > pCoord.PositionDistance)
                        {
                            StepsToWalk = pCoord.PositionDistance;
                            LastCoord = pCoord;
                        }
                    }
                }
                if (Trys >= 200)
                    return null;

                else if (LastCoord.X == -200 && LastCoord.Y == -200)
                    return null;

                UserX = LastCoord.X;
                UserY = LastCoord.Y;
                CoordSquares.Add(LastCoord);

                if (UserX == GoX && UserY == GoY)
                    break;
            }
            return CoordSquares;
        }

        public Boolean CheckFurniCoordinates(int X, int Y)
        {
            return false;
        }
        private int DistanceBetween(int currentX, int currentY, int goX, int goY)
        {
            return Math.Abs(currentX - goX) + Math.Abs(currentY - goY);
        }

        public HabboRoomObject RoomObject()
        {
            return User;
        }
    }
}
