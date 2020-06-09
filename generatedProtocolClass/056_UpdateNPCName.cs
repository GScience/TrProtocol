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
        public short npcId = default(short);
        /// <summary>
        /// 
        /// </summary>
        public string name = default(string);
        /// <summary>
        /// 
        /// </summary>
        public int townNpcVariationIndex = default(int);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(npcId);
            writer.Write(name);
            writer.Write(townNpcVariationIndex);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            npcId = reader.ReadInt16();
            name = reader.ReadString();
            townNpcVariationIndex = reader.ReadInt32();
        }
    }
}

//Json file changed at 2020/6/10 1:23:40