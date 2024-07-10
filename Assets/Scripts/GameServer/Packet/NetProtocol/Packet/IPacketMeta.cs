using System;

namespace NetProtocol.Packet
{
    public interface IPacketMeta
    {
        public int StartId { get; }
        public Type[] Types { get; }
    }
}