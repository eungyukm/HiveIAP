using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class DungeonEnterV2Res
    {
        public ErrorCode Status = ErrorCode.Success;

        public uint DungeonIndex = 0;
        public uint Level = 0;
        public ChangeItemInfoV2 Changes = new ChangeItemInfoV2();
        public TicketInfo TicketChangeInfo = new TicketInfo();
    }
}