using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class SetUserSlot : INetObject
    {
        /// <summary>
        /// Remote player ID
        /// </summary>
        public byte playerId = default(byte);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(playerId);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            playerId = reader.ReadByte();
        }
    }
}

//Generate at 2020/6/9 22:04:50