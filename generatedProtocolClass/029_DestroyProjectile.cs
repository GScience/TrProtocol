using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg29DestroyProjectile : INetObject
    {
        public const int ID = 29;
        /// <summary>
        /// 
        /// </summary>
        public short projectileId = default(short);
        /// <summary>
        /// Player ID
        /// </summary>
        public short owner = default(short);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(projectileId);
            writer.Write(owner);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            projectileId = reader.ReadInt16();
            owner = reader.ReadInt16();
        }
    }
}

//Json file changed at 2020/6/9 22:37:58