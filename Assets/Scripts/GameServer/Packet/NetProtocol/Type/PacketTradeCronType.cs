namespace NetProtocol.Packet
{
    public enum PacketTradeCronType
    {
        None = 0,
        SalesRegistration,
        Buy,
        Sold,
        Settled,
        Cancel,
        ReclaimExpired,
    }
}