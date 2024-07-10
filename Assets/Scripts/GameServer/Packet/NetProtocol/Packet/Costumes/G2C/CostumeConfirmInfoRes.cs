using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class CostumeConfirmInfoRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public List<CostumeConfirm> Confirms = new();
    }
}
