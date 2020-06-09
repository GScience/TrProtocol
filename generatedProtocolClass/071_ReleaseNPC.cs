using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg71ReleaseNPC : INetObject
    {
        public const int ID = 71;
        /// <summary>
        /// 
        /// </summary>
        public int x = default(int);
        /// <summary>
        /// 
        /// </summary>
        public int y = default(int);
        /// <summary>
        /// 
        /// </summary>
        public short npcType = default(short);
        /// <summary>
        /// Sent to NPC AI[2]
        /// </summary>
        public byte style = default(byte);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(x);
            writer.Write(y);
            writer.Write(npcType);
            writer.Write(style);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            x = reader.ReadInt32();
            y = reader.ReadInt32();
            npcType = reader.ReadInt16();
            style = reader.ReadByte();
        }
    }
}

//Json file changed at 2020/6/9 23:16:39