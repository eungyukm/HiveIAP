namespace NetProtocol.Packet.G2C
{
    public class PlayerBlackRosterGetPreferenceRes
    {
        public ErrorCode Status = ErrorCode.Success;
        public BlackRosterPreferenceInfo Info = new BlackRosterPreferenceInfo();
    }
}