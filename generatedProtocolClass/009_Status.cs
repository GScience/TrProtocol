using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Status : INetObject
    {
        /// <summary>
        /// Status only increases
        /// </summary>
        public int statusMax = default(int);
        /// <summary>
        /// Status only increases
        /// </summary>
        public NetworkText statusMax = new NetworkText();

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(statusMax);
            statusMax.OnSerialize(writer);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            statusMax = reader.ReadInt32();
            statusMax.OnDeserialize(reader);
        }
    }
}

//Generate at 2020/6/9 22:04:50