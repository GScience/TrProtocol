using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg72TravellingMerchantInventory : INetObject
    {
        public const int ID = 72;
        /// <summary>
        /// Each short related to an item type NetID.
        /// </summary>
        public short[] items = new short[40];

        public void OnSerialize(BinaryWriter writer)
        {
            for (var i = 0; i < 40; ++i) writer.Write(items[i]);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            for (var i = 0; i < 40; ++i) items[i] = reader.ReadInt16();
        }
    }
}

//Json file changed at 2020/6/9 23:19:02