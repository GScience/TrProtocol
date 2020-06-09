using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg74AnglerQuest : INetObject
    {
        public const int ID = 74;
        /// <summary>
        /// 
        /// </summary>
        public byte quest = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public bool completed = default(bool);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(quest);
            writer.Write(completed);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            quest = reader.ReadByte();
            completed = reader.ReadBoolean();
        }
    }
}

//Json file changed at 2020/6/9 23:20:11