using System;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class RideAttachInvenExtendV2Res
    {
        public ErrorCode Result;
        public uint ItemIndex;
        public uint ItemCount;
        public int AttachInvenSize;
    }
}
