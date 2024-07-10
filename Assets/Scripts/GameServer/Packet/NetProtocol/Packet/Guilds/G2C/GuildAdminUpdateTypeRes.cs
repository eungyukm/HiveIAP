using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class GuildAdminUpdateTypeRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public GuildType Type = GuildType.Open;
    }
}