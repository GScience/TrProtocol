using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg51SpecialNPCEffect : INetObject
    {
        public const int ID = 51;
        /// <summary>
        /// 
        /// </summary>
        public byte playerId = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public SpecialNPCEffectType type = default(SpecialNPCEffectType);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(playerId);
            writer.Write((byte)type);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            playerId = reader.ReadByte();
            type = (SpecialNPCEffectType)reader.ReadByte();
        }
    }
}

//Json file changed at 2020/6/9 22:58:40