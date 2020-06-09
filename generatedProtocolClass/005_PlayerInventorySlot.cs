using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class PlayerInventorySlot : INetObject
    {
        /// <summary>
        /// Remote player ID
        /// </summary>
        public byte playerId = default(byte);
        /// <summary>
        /// Slot ID
        /// </summary>
        public byte slotId = default(byte);
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
            slotId = reader.ReadByte();
            stack = reader.ReadInt16();
            prefix = reader.ReadByte();
            netId = reader.ReadInt16();
        }
    }
}

//Generate at 2020/6/9 22:04:50