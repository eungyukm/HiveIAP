using NetProtocol.Models.Guild;

namespace NetProtocol.Packet.G2C
{
    public class GuildTerritorySetRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public TerritoryInfo Info = new TerritoryInfo();
    }
}