using NetProtocol.Packet;

namespace NetProtocol.Models.etc
{
    
    public class WalletInfoV2
    {
        public long Free = 0;        // 무료
        public long Paid = 0;        // 유료
    }
    
    public class WalletUpdateInfoV2
    {
        public WalletType Type = WalletType.NONE;
        public WalletInfoV2 Previous = new();       // 이전값
        public WalletInfoV2 Current = new();        // 현재값
        public WalletInfoV2 Variance = new();       // 변화량
        public Trace FromTrace = Trace.None;
    }
}
