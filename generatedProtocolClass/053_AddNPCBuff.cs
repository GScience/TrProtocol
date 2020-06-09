using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg53AddNPCBuff : INetObject
    {
        public const int ID = 53;
        /// <summary>
        /// 
        /// </summary>
        public short npcId = default(short);
        /// <summary>
        /// 
        /// </summary>
        public ushort buff = default(ushort);
        /// <summary>
        /// 
        /// </summary>
        public short time = default(short);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(npcId);
            writer.Write(buff);
            writer.Write(time);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            npcId = reader.ReadInt16();
            buff = reader.ReadUInt16();
            time = reader.ReadInt16();
        }
    }
}

//Json file changed at 2020/6/9 23:00:26