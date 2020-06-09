using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class BitsByte : INetObject
    {
        /// <summary>
        /// Data
        /// </summary>
        public byte data = default(byte);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(data);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            data = reader.ReadByte();
        }
    }
}

//Generate at 2020/6/9 22:04:51