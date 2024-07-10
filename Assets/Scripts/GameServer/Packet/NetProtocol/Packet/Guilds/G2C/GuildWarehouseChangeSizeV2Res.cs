using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class GuildWarehouseChangeSizeV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public WarehouseType Type = WarehouseType.none;
        public short Size = 0;
        public byte ExtendCount = 0;
        public long GuildCron = 0;
    }
}