using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class PlayerHP : INetObject
    {
        /// <summary>
        /// Remote player ID
        /// </summary>
        public byte playerId = default(byte);
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
            writer.Write(playerId);
            writer.Write(hp);
            writer.Write(maxHp);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            playerId = reader.ReadByte();
            hp = reader.ReadInt16();
            maxHp = reader.ReadInt16();
        }
    }
}

//Generate at 2020/6/9 22:04:51