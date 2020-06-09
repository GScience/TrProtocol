using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdatePlayer : INetObject
    {
        /// <summary>
        /// Remote player ID
        /// </summary>
        public byte playerId = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public byte control = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public byte pulley = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public byte misc = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public byte sleepingInfo = default(byte);
        /// <summary>
        /// 
        /// </summary>
        public byte selectedItem = default(byte);
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
        /// 
        /// </summary>
        public float originalPositionX = default(float);
        /// <summary>
        /// 
        /// </summary>
        public float originalPositionY = default(float);
        /// <summary>
        /// 
        /// </summary>
        public float homePositionX = default(float);
        /// <summary>
        /// 
        /// </summary>
        public float homePositionY = default(float);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(playerId);
            writer.Write(control);
            writer.Write(pulley);
            writer.Write(misc);
            writer.Write(sleepingInfo);
            writer.Write(selectedItem);
            writer.Write(positionX);
            writer.Write(positionY);
            writer.Write(velocityX);
            writer.Write(velocityY);
            writer.Write(originalPositionX);
            writer.Write(originalPositionY);
            writer.Write(homePositionX);
            writer.Write(homePositionY);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            playerId = reader.ReadByte();
            control = reader.ReadByte();
            pulley = reader.ReadByte();
            misc = reader.ReadByte();
            sleepingInfo = reader.ReadByte();
            selectedItem = reader.ReadByte();
            positionX = reader.ReadSingle();
            positionY = reader.ReadSingle();
            velocityX = reader.ReadSingle();
            velocityY = reader.ReadSingle();
            originalPositionX = reader.ReadSingle();
            originalPositionY = reader.ReadSingle();
            homePositionX = reader.ReadSingle();
            homePositionY = reader.ReadSingle();
        }
    }
}

//Generate at 2020/6/9 22:04:50