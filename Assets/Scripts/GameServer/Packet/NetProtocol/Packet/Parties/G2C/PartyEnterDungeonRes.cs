namespace NetProtocol.Packet.G2C
{
    public class PartyEnterDungeonRes
    {
        public ErrorCode Status = ErrorCode.Success;
        
        public uint DungeonIndex = 0;
        public uint Level = 0;
        public TicketInfo TicketChangeInfo = new TicketInfo();
    }
}