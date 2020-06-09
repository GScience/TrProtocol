using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg78ReportInvasionProgress : INetObject
    {
        public const int ID = 78;
        /// <summary>
        /// 
        /// </summary>
        public int progress = default(int);
        /// <summary>
        /// 
        /// </summary>
        public int maxProgress = default(int);
        /// <summary>
        /// 
        /// </summary>
        public sbyte icon = default(sbyte);
        /// <summary>
        /// 
        /// </summary>
        public sbyte wave = default(sbyte);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(progress);
            writer.Write(maxProgress);
            writer.Write(icon);
            writer.Write(wave);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            progress = reader.ReadInt32();
            maxProgress = reader.ReadInt32();
            icon = reader.ReadSByte();
            wave = reader.ReadSByte();
        }
    }
}

//Json file changed at 2020/6/9 23:23:46