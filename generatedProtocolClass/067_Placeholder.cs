using System.IO;
using System;
using System.Collections.Generic;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg67Placeholder : INetMessage
    {
        public const int ID = 67;

        public Side Side { get; set; }





        public void OnSerialize(BinaryWriter writer)
        {

        }

        public void OnDeserialize(BinaryReader reader)
        {

        }
    }
}

//Json file changed at 2020/6/9 23:12:45