using System.IO;
using System;
using System.Collections.Generic;

namespace TrProtocol
{
    /// <summary>
    /// 
    /// </summary>
    public class Msg37RequestPassword : INetMessage
    {
        public const int ID = 37;

        public Side Side { get; set; }





        public void OnSerialize(BinaryWriter writer)
        {

        }

        public void OnDeserialize(BinaryReader reader)
        {

        }
    }
}

//Json file changed at 2020/6/9 22:47:58