using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg65PlayerNPCTeleport : INetObject
    {
        public const int ID = 65;
        /// <summary>
        /// 
        /// </summary>
        public BitsByte flags = new BitsByte();        /// <summary>
        /// 
        /// </summary>
        public short targetId = default(short);        /// <summary>
        /// 
        /// </summary>
        public float x = default(float);        /// <summary>
        /// 
        /// </summary>
        public float y = default(float);        /// <summary>
        /// 
        /// </summary>
        public byte style = default(byte);        /// <summary>
        /// 
        /// </summary>
        public int extraInfo = default(int);

        public void OnSerialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }

        public void OnDeserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}

//Json file changed at 2020/6/9 23:11:44