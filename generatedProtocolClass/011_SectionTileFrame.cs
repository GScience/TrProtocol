using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class SectionTileFrame : INetObject
    {
        /// <summary>
        /// 
        /// </summary>
        public short startX = default(short);
        /// <summary>
        /// 
        /// </summary>
        public short startY = default(short);
        /// <summary>
        /// 
        /// </summary>
        public short endX = default(short);
        /// <summary>
        /// 
        /// </summary>
        public short endY = default(short);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(startX);
            writer.Write(startY);
            writer.Write(endX);
            writer.Write(endY);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            startX = reader.ReadInt16();
            startY = reader.ReadInt16();
            endX = reader.ReadInt16();
            endY = reader.ReadInt16();
        }
    }
}

//Generate at 2020/6/9 22:04:50