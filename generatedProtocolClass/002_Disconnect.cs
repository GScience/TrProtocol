using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Disconnect : INetObject
    {
        /// <summary>
        /// Kick message
        /// </summary>
        public NetworkText kickMsg = new NetworkText();

        public void OnSerialize(BinaryWriter writer)
        {
            kickMsg.OnSerialize(writer);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            kickMsg.OnDeserialize(reader);
        }
    }
}

//Generate at 2020/6/9 22:04:50