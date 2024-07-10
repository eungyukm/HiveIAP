using NetProtocol.Models.Zone;

namespace NetProtocol.Packet.G2C
{
    public class ZoneStatusRes
    {
        public ErrorCode Status = ErrorCode.Success;

        public DZoneOverview ZoneOverview = new DZoneOverview();
    }
}