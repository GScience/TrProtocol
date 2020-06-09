using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg61SpawnBoxxInvasion : INetObject
    {
        public const int ID = 61;
        /// <summary>
        /// 
        /// </summary>
        public short playerId = default(short);
        /// <summary>
        /// 
        /// </summary>
        public SpawnBossInvasionType type = default(SpawnBossInvasionType);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(playerId);
            writer.Write((short)type);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            playerId = reader.ReadInt16();
            type = (SpawnBossInvasionType)reader.ReadInt16();
        }
    }
}

//Json file changed at 2020/6/9 23:08:46