using System.IO;
using System;

namespace TrProtocol
{
    /// <summary>
    /// This packet is used once in the connecting phase and does the following:
1.Sends you the spawn section
2.Optionally, if spawn coords aren't -1 - sends you the sections of the selected position (which is the player's spawnpoint)
Synchronises all portals and sections around them
    /// </summary>
    public class RequestEssentialTiles : INetObject
    {
        /// <summary>
        /// Player spawn x
        /// </summary>
        public int x = default(int);
        /// <summary>
        /// Player spawn y
        /// </summary>
        public int y = default(int);

        public void OnSerialize(BinaryWriter writer)
        {
            writer.Write(x);
            writer.Write(y);
        }

        public void OnDeserialize(BinaryReader reader)
        {
            x = reader.ReadInt32();
            y = reader.ReadInt32();
        }
    }
}

//Generate at 2020/6/9 22:04:50