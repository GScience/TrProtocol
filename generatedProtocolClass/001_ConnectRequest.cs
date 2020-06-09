using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg1ConnectRequest : INetObject
    {
        public const int ID = 1;
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

//Json file changed at 2020/6/9 19:45:21