using System;

namespace NetProtocol.Packet
{
    public class PlayerExpRecoveryInfo
    {
        public long UniqueId;
        public int Level;

        public long RecoverExp;
        public long ExpectCost;
        public long At; 
    }
}
