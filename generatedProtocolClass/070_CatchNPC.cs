using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg70CatchNPC : INetObject
    {
        public const int ID = 70;
        /// <summary>
        /// 
        /// </summary>
        public short npcId = default(short);
        /// <summary>
        /// 
        /// </summary>
        public byte playerId = default(byte);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(npcId);
            writer.Write(playerId);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            npcId = reader.ReadInt16();
            playerId = reader.ReadByte();
        }
    }
}

//Json file changed at 2020/6/9 23:15:43