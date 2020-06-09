using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg24StrikeNPCWithHeldItem : INetObject
    {
        public const int ID = 24;
        /// <summary>
        /// 
        /// </summary>
        public short  npcId = default(short);
        /// <summary>
        /// 
        /// </summary>
        public byte  playerId = default(byte);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write( npcId);
            writer.Write( playerId);
        }

        public void OnDeserialize(BinaryReader reader)
        {
             npcId = reader.ReadInt16();
             playerId = reader.ReadByte();
        }
    }
}

//Json file changed at 2020/6/9 22:29:15