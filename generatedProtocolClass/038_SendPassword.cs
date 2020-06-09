using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg38SendPassword : INetObject
    {
        public const int ID = 38;
        /// <summary>
        /// 
        /// </summary>
        public string password = default(string);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(password);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            password = reader.ReadString();
        }
    }
}

//Json file changed at 2020/6/9 22:48:54