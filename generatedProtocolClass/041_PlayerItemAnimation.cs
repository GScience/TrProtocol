using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg41PlayerItemAnimation : INetObject
    {
        public const int ID = 41;
        /// <summary>
        /// 
        /// </summary>
        public byte playerId = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public float itemRotation = default(float);
        /// <summary>
        /// 
        /// </summary>
        public short itemAnimation = default(short);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(playerId);
            writer.Write(itemRotation);
            writer.Write(itemAnimation);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            playerId = reader.ReadByte();
            itemRotation = reader.ReadSingle();
            itemAnimation = reader.ReadInt16();
        }
    }
}

//Json file changed at 2020/6/9 22:51:07