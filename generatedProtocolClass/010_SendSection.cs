using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg10SendSection : INetMessage
    {
        public const int ID = 10;

        public Side Side { get; set; }

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
        public Chest chests = new Chest();
        /// <summary>
        /// 
        /// </summary>
        public short signCount = default(short);
        /// <summary>
        /// 
        /// </summary>
        public Sign signs = new Sign();
        /// <summary>
        /// 
        /// </summary>
        public short tileEntityCount = default(short);
        /// <summary>
        /// 
        /// </summary>
        public Entity tileEntities = new Entity();



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

//Json file changed at 2020/6/9 23:47:05