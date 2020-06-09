using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// Color
    /// </summary>
    public class Color : INetObject
    {
        /// <summary>
        /// Red
        /// </summary>
        public byte r = default(byte);
        /// <summary>
        /// Red
        /// </summary>
        public byte g = default(byte);
        /// <summary>
        /// Red
        /// </summary>
        public byte b = default(byte);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(r);
            writer.Write(g);
            writer.Write(b);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            r = reader.ReadByte();
            g = reader.ReadByte();
            b = reader.ReadByte();
        }
    }
}

//Generate at 2020/6/9 22:04:51