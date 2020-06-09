using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class WorldTile : INetObject
    {
        /// <summary>
        /// 
        /// </summary>
        public Tile tile = new Tile();

        public void OnSerialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }

        public void OnDeserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}

//Generate at 2020/6/9 22:04:51