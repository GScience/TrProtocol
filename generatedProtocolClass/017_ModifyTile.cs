using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class ModifyTile : INetObject
    {
        /// <summary>
        /// 
        /// </summary>
        public  action = ;
        /// <summary>
        /// 
        /// </summary>
        public short hp = default(short);
        /// <summary>
        /// 
        /// </summary>
        public short maxHp = default(short);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write((byte)action);
            writer.Write(hp);
            writer.Write(maxHp);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            action = (ModifyTileAction)reader.ReadByte();
            hp = reader.ReadInt16();
            maxHp = reader.ReadInt16();
        }
    }
}

//Generate at 2020/6/9 22:04:51