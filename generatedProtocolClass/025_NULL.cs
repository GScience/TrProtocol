using System.IO;
using System;
using System.Collections.Generic;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg25NULL : INetMessage
    {
        public const int ID = 25;

        public Side Side { get; set; }





        public void OnSerialize(BinaryWriter writer)
        {

        }

        public void OnDeserialize(BinaryReader reader)
        {

        }
    }
}

//Json file changed at 2020/6/9 21:16:31