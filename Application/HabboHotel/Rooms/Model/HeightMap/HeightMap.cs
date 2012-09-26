using System;
using System.Text;
using System.Text.RegularExpressions;
using Revolution.Revision.R63B.Game.Rooms.Model.HeightMap.Tilestate;

namespace Revolution.Revision.R63B.Game.Rooms.Model.HeightMap
{
    public class Heightmap
    {
        public sbyte[,] LogicalHeightMap;
        public TileState[,] TileStates { get; set; }
        public int[,] FloorHeight { get; set; }
        public bool[,] RoomUnit { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }

        public void SetMap(string heightmap)
        {
            string[] l = Regex.Split(heightmap, "\r\n");

            SizeX = l[0].Length;
            SizeY = l.Length;

            TileStates = new TileState[SizeX,SizeY];
            FloorHeight = new int[SizeX,SizeY];

            for (int y = 0; y < SizeY; y++)
            {
                for (int x = 0; x < SizeX; x++)
                {
                    string value = l[y][x].ToString().ToLower();

                    TileStates[x, y] = (value == "x" ? TileState.Blocked : TileState.Open);
                    FloorHeight[x, y] = (value == "x" ? 0 : int.Parse(value));
                    RoomUnit = new bool[x,y];
                    LogicalHeightMap = new sbyte[x,y];
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int y = 0; y < SizeY; y++)
            {
                for (int x = 0; x < SizeX; x++)
                {
                    sb.Append(TileStates[x, y] == TileState.Blocked ? "x" : FloorHeight.ToString());
                }

                sb.Append(Convert.ToChar(13));
            }

            return sb.ToString();
        }
    }
}