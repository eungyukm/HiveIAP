namespace NetProtocol.Packet.G2C
{
    public class GuildAdminMasterChangeRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public long AccountIdNewMaster;
    }
}