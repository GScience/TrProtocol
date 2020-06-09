using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg13UpdatePlayer : INetObject
    {
        public const int ID = 13;
        /// <summary>
        /// Remote player ID
        /// </summary>
        public byte playerId = default(byte);        /// <summary>
        /// 
        /// </summary>
        public byte control = default(byte);        /// <summary>
        /// 
        /// </summary>
        public byte pulley = default(byte);        /// <summary>
        /// 
        /// </summary>
        public byte misc = default(byte);        /// <summary>
        /// 
        /// </summary>
        public byte sleepingInfo = default(byte);        /// <summary>
        /// 
        /// </summary>
        public byte selectedItem = default(byte);        /// <summary>
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
        /// 
        /// </summary>
        public float originalPositionX = default(float);        /// <summary>
        /// 
        /// </summary>
        public float originalPositionY = default(float);        /// <summary>
        /// 
        /// </summary>
        public float homePositionX = default(float);        /// <summary>
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
            
            if (((uint)pulley & (1 << 2)) > 0U)
            {
                writer.Write(velocityX);
                writer.Write(velocityY);
            }
            
            if (((uint)misc & (1 << 6)) > 0U)
            {
                writer.Write(originalPositionX);
                writer.Write(originalPositionY);
                writer.Write(homePositionX);
                writer.Write(homePositionY);
            }
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
            
            if (((uint)pulley & (1 << 2)) > 0U)
            {
                velocityX = reader.ReadSingle();
                velocityY = reader.ReadSingle();
            }
            
            if (((uint)misc & (1 << 6)) > 0U)
            {
                originalPositionX = reader.ReadSingle();
                originalPositionY = reader.ReadSingle();
                homePositionX = reader.ReadSingle();
                homePositionY = reader.ReadSingle();
            }
        }
    }
}

//Json file changed at 2020/6/10 0:40:27