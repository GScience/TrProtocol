using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg27ProjectileUpdate : INetMessage
    {
        public const int ID = 27;

        public Side Side { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public short projectileId = default(short);
        /// <summary>
        /// 
        /// </summary>
        public float positionX = default(float);
        /// <summary>
        /// 
        /// </summary>
        public float positionY = default(float);
        /// <summary>
        /// 
        /// </summary>
        public float velocityX = default(float);
        /// <summary>
        /// 
        /// </summary>
        public float velocityY = default(float);
        /// <summary>
        /// Player ID
        /// </summary>
        public byte owner = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public short type = default(short);
        /// <summary>
        /// 
        /// </summary>
        public BitsByte projFlags = new BitsByte();
        /// <summary>
        /// Only sent if AI[0] flag is true
        /// </summary>
        public float AI0 = default(float);
        /// <summary>
        /// Only sent if AI[1] flag is true
        /// </summary>
        public float AI1 = default(float);
        /// <summary>
        /// Only sent if Damage flag is true
        /// </summary>
        public short Damage = default(short);
        /// <summary>
        /// Only sent if Knockback flag is true
        /// </summary>
        public float knockback = default(float);
        /// <summary>
        /// Only sent if OriginalDamage flag is true
        /// </summary>
        public short originalDamage = default(short);
        /// <summary>
        /// Only sent if ProjUUID flag is true
        /// </summary>
        public short projUUID = default(short);



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

//Json file changed at 2020/6/9 22:34:34