using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg68ClientUUID : INetMessage
    {
        public const int ID = 68;

        public Side Side { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string uuid = default(string);



        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(uuid);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            uuid = reader.ReadString();
        }
    }
}

//Json file changed at 2020/6/9 23:14:37