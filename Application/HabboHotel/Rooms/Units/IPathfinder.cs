using System.Collections.Generic;

namespace Revolution.Revision.R63B.Game.Rooms.Units
{
    public interface IPathfinder
    {
        void ApplyCollisionMap(byte[,] map, float[,] height);
        ICollection<byte[]> Path(byte startX, byte startY, byte endX, byte endY, float maxDrop, float maxJump);
    }
}