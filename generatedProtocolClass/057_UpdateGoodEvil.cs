using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg57UpdateGoodEvil : INetObject
    {
        public const int ID = 57;
        /// <summary>
        /// 
        /// </summary>
        public byte good = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public byte evil = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public byte crimson = default(byte);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(good);
            writer.Write(evil);
            writer.Write(crimson);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            good = reader.ReadByte();
            evil = reader.ReadByte();
            crimson = reader.ReadByte();
        }
    }
}

//Json file changed at 2020/6/9 23:03:50