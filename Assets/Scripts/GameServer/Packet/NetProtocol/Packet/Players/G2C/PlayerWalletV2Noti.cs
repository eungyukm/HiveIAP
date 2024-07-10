
using NetProtocol.Models.etc;
using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class PlayerWalletV2Noti
    {
        public Dictionary<WalletType, WalletInfoV2> WalletList = new();
    }
}