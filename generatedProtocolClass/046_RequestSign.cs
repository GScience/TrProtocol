using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg46RequestSign : INetObject
    {
        public const int ID = 46;
        /// <summary>
        /// 
        /// </summary>
        public short x = default(short);
        /// <summary>
        /// 
        /// </summary>
        public short y = default(short);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(x);
            writer.Write(y);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            x = reader.ReadInt16();
            y = reader.ReadInt16();
        }
    }
}

//Json file changed at 2020/6/9 22:53:41