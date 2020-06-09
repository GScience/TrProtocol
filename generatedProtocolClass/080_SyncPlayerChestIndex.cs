using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg80SyncPlayerChestIndex : INetObject
    {
        public const int ID = 80;
        /// <summary>
        /// 
        /// </summary>
        public byte player = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public short chest = default(short);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(player);
            writer.Write(chest);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            player = reader.ReadByte();
            chest = reader.ReadInt16();
        }
    }
}

//Json file changed at 2020/6/9 23:26:44