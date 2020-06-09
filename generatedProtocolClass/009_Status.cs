using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg9Status : INetObject
    {
        public const int ID = 9;
        /// <summary>
        /// Status only increases
        /// </summary>
        public int statusMax = default(int);
        /// <summary>
        /// 
        /// </summary>
        public NetworkText statusText = new NetworkText();
        /// <summary>
        /// 
        /// </summary>
        public byte statusTextFlags = default(byte);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(statusMax);
            statusText.OnSerialize(writer);
            writer.Write(statusTextFlags);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            statusMax = reader.ReadInt32();
            statusText.OnDeserialize(reader);
            statusTextFlags = reader.ReadByte();
        }
    }
}

//Json file changed at 2020/6/9 23:51:19