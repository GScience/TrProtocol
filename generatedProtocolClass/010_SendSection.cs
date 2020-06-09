using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class SendSection : INetObject
    {
        /// <summary>
        /// Terraria version
        /// </summary>
        public bool compressed = default(bool);
        /// <summary>
        /// 
        /// </summary>
        public int xStart = default(int);
        /// <summary>
        /// 
        /// </summary>
        public int yStart = default(int);
        /// <summary>
        /// 
        /// </summary>
        public short width = default(short);
        /// <summary>
        /// 
        /// </summary>
        public short height = default(short);
        /// <summary>
        /// 
        /// </summary>
        public WorldTile tiles = new WorldTile();
        /// <summary>
        /// 
        /// </summary>
        public short chestCount = default(short);
        /// <summary>
        /// 
        /// </summary>
        public  chests = new ();
        /// <summary>
        /// 
        /// </summary>
        public short signCount = default(short);
        /// <summary>
        /// 
        /// </summary>
        public  signs = new ();
        /// <summary>
        /// 
        /// </summary>
        public short tileEntityCount = default(short);
        /// <summary>
        /// 
        /// </summary>
        public  tileEntities = new ();

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(compressed);
            writer.Write(xStart);
            writer.Write(yStart);
            writer.Write(width);
            writer.Write(height);
            tiles.OnSerialize(writer);
            writer.Write(chestCount);
            chests.OnSerialize(writer);
            writer.Write(signCount);
            signs.OnSerialize(writer);
            writer.Write(tileEntityCount);
            tileEntities.OnSerialize(writer);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            compressed = reader.ReadBoolean();
            xStart = reader.ReadInt32();
            yStart = reader.ReadInt32();
            width = reader.ReadInt16();
            height = reader.ReadInt16();
            tiles.OnDeserialize(reader);
            chestCount = reader.ReadInt16();
            chests.OnDeserialize(reader);
            signCount = reader.ReadInt16();
            signs.OnDeserialize(reader);
            tileEntityCount = reader.ReadInt16();
            tileEntities.OnDeserialize(reader);
        }
    }
}

//Generate at 2020/6/9 22:04:50