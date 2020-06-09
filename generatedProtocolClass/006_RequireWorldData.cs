using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// Require world data
    /// </summary>
    public class Msg6RequireWorldData : INetObject
    {
        public const int ID = 6;


        public void OnSerialize(BinaryWriter writer)
        {

        }

        public void OnDeserialize(BinaryReader reader)
        {

        }
    }
}

//Json file changed at 2020/6/9 19:48:03