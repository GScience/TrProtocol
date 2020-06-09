using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg23NPCUpdate : INetObject
    {
        public const int ID = 23;
        /// <summary>
        /// 
        /// </summary>
        public short npcId = default(short);        /// <summary>
        /// 
        /// </summary>
        public float positionX = default(float);        /// <summary>
        /// 
        /// </summary>
        public float positionY = default(float);        /// <summary>
        /// 
        /// </summary>
        public float velocityX = default(float);        /// <summary>
        /// 
        /// </summary>
        public float velocityY = default(float);        /// <summary>
        /// Player ID
        /// </summary>
        public ushort target = default(ushort);        /// <summary>
        /// 
        /// </summary>
        public byte npcFlags1 = default(byte);        /// <summary>
        /// 
        /// </summary>
        public byte npcFlags2 = default(byte);        /// <summary>
        /// 
        /// </summary>
        public AI ai = new AI();        /// <summary>
        /// 
        /// </summary>
        public short npcNetID = default(short);        /// <summary>
        /// 
        /// </summary>
        public byte playerCountForMultiplayerDifficultyOverride = default(byte);        /// <summary>
        /// 
        /// </summary>
        public float strengthMultiplier = default(float);        /// <summary>
        /// 
        /// </summary>
        public byte lifeBytes = default(byte);        /// <summary>
        /// 
        /// </summary>
        public Variable life = new Variable();        /// <summary>
        /// 
        /// </summary>
        public Byte releaseOwner = new Byte();

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

//Json file changed at 2020/6/9 22:28:19