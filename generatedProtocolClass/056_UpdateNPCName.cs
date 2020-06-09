using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg56UpdateNPCName : INetObject
    {
        public const int ID = 56;
        /// <summary>
        /// 
        /// </summary>
        public short npcId = default(short);        /// <summary>
        /// 
        /// </summary>
        public string name = default(string);        /// <summary>
        /// 
        /// </summary>
        public int townNpcVariationIndex = default(int);

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

//Json file changed at 2020/6/10 1:50:43