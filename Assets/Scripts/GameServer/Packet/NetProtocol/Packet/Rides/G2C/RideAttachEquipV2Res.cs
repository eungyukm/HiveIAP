namespace NetProtocol.Packet.G2C
{
    public class RideAttachEquipV2Res
    {
        public ErrorCode Result;
        public uint RideIndex;
        public long AttachID;
        public byte AttachPart;
    }
}
