using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg40SetActiveNPC : INetObject
    {
        public const int ID = 40;
        /// <summary>
        /// 
        /// </summary>
        public byte playerId = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public short npcTalkTarget = default(short);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(playerId);
            writer.Write(npcTalkTarget);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            playerId = reader.ReadByte();
            npcTalkTarget = reader.ReadInt16();
        }
    }
}

//Json file changed at 2020/6/9 22:50:25