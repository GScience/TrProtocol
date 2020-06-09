using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class ConnectRequest : INetObject
    {
        /// <summary>
        /// Terraria version
        /// </summary>
        public string version = default(string);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(version);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            version = reader.ReadString();
        }
    }
}

//Generate at 2020/6/9 22:04:50