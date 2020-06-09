using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg3SetUserSlot : INetObject
    {
        public const int ID = 3;
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

//Json file changed at 2020/6/9 19:46:21