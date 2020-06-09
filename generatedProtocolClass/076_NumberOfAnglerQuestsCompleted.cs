using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg76NumberOfAnglerQuestsCompleted : INetObject
    {
        public const int ID = 76;
        /// <summary>
        /// 
        /// </summary>
        public byte playerId = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public int anglerQuestsCompleted = default(int);
        /// <summary>
        /// 
        /// </summary>
        public int golferScore = default(int);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(playerId);
            writer.Write(anglerQuestsCompleted);
            writer.Write(golferScore);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            playerId = reader.ReadByte();
            anglerQuestsCompleted = reader.ReadInt32();
            golferScore = reader.ReadInt32();
        }
    }
}

//Json file changed at 2020/6/9 23:21:21