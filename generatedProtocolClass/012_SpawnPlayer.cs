using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class SpawnPlayer : INetObject
    {
        /// <summary>
        /// Remote player ID
        /// </summary>
        public byte playerId = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public short spawnX = default(short);
        /// <summary>
        /// 
        /// </summary>
        public short spawnY = default(short);
        /// <summary>
        /// 
        /// </summary>
        public int respawnTimeRemain = default(int);
        /// <summary>
        /// 
        /// </summary>
        public  playerSpawnContext = ;

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(playerId);
            writer.Write(spawnX);
            writer.Write(spawnY);
            writer.Write(respawnTimeRemain);
            writer.Write((byte)playerSpawnContext);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            playerId = reader.ReadByte();
            spawnX = reader.ReadInt16();
            spawnY = reader.ReadInt16();
            respawnTimeRemain = reader.ReadInt32();
            playerSpawnContext = (PlayerSpawnContext)reader.ReadByte();
        }
    }
}

//Generate at 2020/6/9 22:04:50