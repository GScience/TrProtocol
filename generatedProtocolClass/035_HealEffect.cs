using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg35HealEffect : INetObject
    {
        public const int ID = 35;
        /// <summary>
        /// 
        /// </summary>
        public byte playerId = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public short healAmount = default(short);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(playerId);
            writer.Write(healAmount);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            playerId = reader.ReadByte();
            healAmount = reader.ReadInt16();
        }
    }
}

//Json file changed at 2020/6/9 22:46:31