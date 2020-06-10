using System.IO;
using System;
using System.Collections.Generic;

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

//Json file changed at 2020/6/9 23:11:33