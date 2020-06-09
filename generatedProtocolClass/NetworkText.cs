using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class NetworkText : INetObject
    {
        /// <summary>
        /// 
        /// </summary>
        public byte mode = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public string text = default(string);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(mode);
            writer.Write(text);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            mode = reader.ReadByte();
            text = reader.ReadString();
        }
    }
}

//Generate at 2020/6/9 22:04:51