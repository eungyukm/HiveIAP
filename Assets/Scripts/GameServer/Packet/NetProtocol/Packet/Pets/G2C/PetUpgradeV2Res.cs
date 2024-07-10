using System.Collections.Generic;
using NetProtocol.Models.Item;
using NetProtocol.Packet;

namespace NetProtocol.Packet.G2C
{
    public class PetUpgradeV2Res
    {
        public ErrorCode Result = ErrorCode.Success;
        public PetData Pet = new();
    }
}