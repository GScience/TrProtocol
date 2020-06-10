using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg5PlayerInventorySlot : INetMessage
    {
        public const int ID = 5;

        public Side Side { get; set; }

        /// <summary>
        /// Remote player ID
        /// </summary>
        public byte playerId = default(byte);
        /// <summary>
        /// Slot ID
        /// </summary>
        public short slotId = default(short);
        /// <summary>
        /// Stack
        /// </summary>
        public short stack = default(short);
        /// <summary>
        /// Prefix
        /// </summary>
        public byte prefix = default(byte);
        /// <summary>
        /// Net ID
        /// </summary>
        public short netId = default(short);



        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(playerId);
            writer.Write(slotId);
            writer.Write(stack);
            writer.Write(prefix);
            writer.Write(netId);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            playerId = reader.ReadByte();
            slotId = reader.ReadInt16();
            stack = reader.ReadInt16();
            prefix = reader.ReadByte();
            netId = reader.ReadInt16();
        }
    }
}

//Json file changed at 2020/6/10 0:52:01