using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Media.Media3D;
using Mango.Communication.Sessions;
using NHibernate;
using Revolution.Api;
using Revolution.Application.HabboHotel.Rooms.Controllers;
using Revolution.Core;
using Revolution.Revision.R63B.Game.Rooms.Engine;
using Revolution.Revision.R63B.Game.Rooms.Model.HeightMap;
using Revolution.Revision.R63B.Game.Rooms.Model.HeightMap.Tilestate;
using Revolution.Revision.R63B.Game.Rooms.Objects.Habbo;

using Revolution.Application.HabboHotel.Rooms.Pathfinder;
using System.Threading;
using RevolutionDatabase.Tables;

namespace Revolution.Revision.R63B.Game.Rooms.Sql
{
    internal class RoomModelSql
    {
        // Model
        private readonly Dictionary<string, RoomModelSql> RoomModels = new Dictionary<string, RoomModelSql>();
        private roommodel model;
        private int clubOnly;
        private int doorDir;
        private int doorX;
        private int doorY;
        private double doorZ;
        private string heightmap;
        private Heightmap map;
        private string privateItems;
        private int roomId;

        public RoomModelSql CreateIntsance(int userId)
        {
            LoadRoomModels(userId);

            return this;
        }

        public void LoadRoomModels(int userId)
        {
           

            using (ISession session = ApiRoot.DatabaseCallback.GetDatabase().GetSessionFactory().OpenSession())
            {
                foreach (RoomSql data in RoomEngine.GetRoomByOwner(userId))
                {
                 
                    model = session.Get<roommodel>(data.id);

                    doorX = model.doorX;
                    doorY = model.doorY;
                    doorZ = model.doorZ;
                    //doorDir = model.doorDir;
                    heightmap = model.heightmap;
                    privateItems = Convert.ToString(model.publicItems);
                    clubOnly = Convert.ToInt32(model.clubOnly);
                    this.roomId = data.id;

                    map = new Heightmap();

                    map.SetMap(heightmap);

                    //habboObject = new HabboRoomObject(userId, data.id, );

                    //RoomModels.Add(model.id, this);
                }
            }
        }

        public bool TryGetModel(string name, out RoomModelSql model)
        {
            return RoomModels.TryGetValue(name, out model);
        }

        public void Walk(Session session, Message Response)
        {
            int X = Response.NextInt32();
            int Y = Response.NextInt32();

            session.habboRoomObject.GoalX = X;
            session.habboRoomObject.GoalY = Y;


            WalkThread walkthread = new WalkThread(session, new Pathfinder(this.map, session.habboRoomObject));

            Thread thread = new Thread(new ThreadStart(walkthread.run));

            // Send Packet here
            /*Response = new Message(1887);
            Response.WriteInt32(1);
            Response.WriteInt32(session.Habbo.Getid);
            Response.WriteInt32(X);
            Response.WriteInt32(Y);
            Response.WriteString("0.0");
            Response.WriteInt32(0);
            Response.WriteInt32(0);
            Response.WriteString("/mv " + X + "," + Y + ",0.0//");
            session.SendPacket(Response);*/
        }

        public static int CalculateRot(int X1, int Y1, int X2, int Y2)
        {
            int Rotation = 0;

            if (X1 > X2 && Y1 > Y2)
                Rotation = 7;
            else if (X1 < X2 && Y1 < Y2)
                Rotation = 3;
            else if (X1 > X2 && Y1 < Y2)
                Rotation = 5;
            else if (X1 < X2 && Y1 > Y2)
                Rotation = 1;
            else if (X1 > X2)
                Rotation = 6;
            else if (X1 < X2)
                Rotation = 2;
            else if (Y1 < Y2)
                Rotation = 4;
            else if (Y1 > Y2)
                Rotation = 0;

            return Rotation;
        }
    }

    public class WalkThread
    {
        private Pathfinder pathfinder;
        private Session session;

        public WalkThread(Session session, Pathfinder pathfind)
        {
            this.pathfinder = pathfind;
            this.session = session;
        }

        public void run()
        {
            try
            {
                foreach (Coord coord in pathfinder.PathCollection())
                {
                    pathfinder.RoomObject().X = coord.X;
                    pathfinder.RoomObject().Y = coord.Y;
                    pathfinder.RoomObject().Rotation = RoomModelSql.CalculateRot(pathfinder.RoomObject().X, pathfinder.RoomObject().Y, pathfinder.RoomObject().GoalX, pathfinder.RoomObject().GoalY);
 
                    Thread.Sleep(500);

                    Message Response = new Message(1887);
                    Response.WriteInt32(1);
                    Response.WriteInt32(session.Habbo.id);
                    Response.WriteInt32(pathfinder.RoomObject().X);
                    Response.WriteInt32(pathfinder.RoomObject().X);
                    Response.WriteString("0.0");
                    Response.WriteInt32(pathfinder.RoomObject().Rotation);
                    Response.WriteInt32(pathfinder.RoomObject().Rotation);
                    Response.WriteString("/mv " + pathfinder.RoomObject().X + "," + pathfinder.RoomObject().X + ",0.0//");
                    session.SendPacket(Response);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}