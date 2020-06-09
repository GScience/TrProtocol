using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Tile : INetObject
    {
        /// <summary>
        /// 
        /// </summary>
        public ushort type = default(ushort);
        /// <summary>
        /// 
        /// </summary>
        public ushort wall = default(ushort);
        /// <summary>
        /// 
        /// </summary>
        public byte liquid = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public short sTileHeader = default(short);
        /// <summary>
        /// 
        /// </summary>
        public byte bTileHeader = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public byte bTileHeader2 = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public byte bTileHeader3 = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public short frameX = default(short);
        /// <summary>
        /// 
        /// </summary>
        public short frameY = default(short);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(type);
            writer.Write(wall);
            writer.Write(liquid);
            writer.Write(sTileHeader);
            writer.Write(bTileHeader);
            writer.Write(bTileHeader2);
            writer.Write(bTileHeader3);
            writer.Write(frameX);
            writer.Write(frameY);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            type = reader.ReadUInt16();
            wall = reader.ReadUInt16();
            liquid = reader.ReadByte();
            sTileHeader = reader.ReadInt16();
            bTileHeader = reader.ReadByte();
            bTileHeader2 = reader.ReadByte();
            bTileHeader3 = reader.ReadByte();
            frameX = reader.ReadInt16();
            frameY = reader.ReadInt16();
        }
    }
}

//Json file changed at 2020/6/9 20:32:06