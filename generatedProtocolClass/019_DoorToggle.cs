using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg19DoorToggle : INetObject
    {
        public const int ID = 19;
        /// <summary>
        /// 
        /// </summary>
        public DoorToggleAction action = default(DoorToggleAction);
        /// <summary>
        /// 
        /// </summary>
        public short tileX = default(short);
        /// <summary>
        /// 
        /// </summary>
        public short tileY = default(short);
        /// <summary>
        /// 
        /// </summary>
        public byte direction = default(byte);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write((byte)action);
            writer.Write(tileX);
            writer.Write(tileY);
            writer.Write(direction);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            action = (DoorToggleAction)reader.ReadByte();
            tileX = reader.ReadInt16();
            tileY = reader.ReadInt16();
            direction = reader.ReadByte();
        }
    }
}

//Json file changed at 2020/6/9 22:14:11