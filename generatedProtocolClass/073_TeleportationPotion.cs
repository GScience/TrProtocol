using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg73TeleportationPotion : INetObject
    {
        public const int ID = 73;
        /// <summary>
        /// 
        /// </summary>
        public TeleportationPotionType type = default(TeleportationPotionType);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write((byte)type);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            type = (TeleportationPotionType)reader.ReadByte();
        }
    }
}

//Json file changed at 2020/6/9 23:19:12