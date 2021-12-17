using System;

namespace NetworkContract
{
    [Serializable]
    public class Info
    {
        public short sender;
        public InfoType type;
        public byte[] bytes;
    }
}

