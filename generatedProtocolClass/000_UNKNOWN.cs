using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg0UNKNOWN : INetMessage
    {
        public const int ID = 0;

        public Side Side { get; set; }





        public void OnSerialize(BinaryWriter writer)
        {

        }

        public void OnDeserialize(BinaryReader reader)
        {

        }
    }
}

//Json file changed at 2020/6/9 19:44:16