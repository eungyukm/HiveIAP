using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class CostumeConfirmAcceptRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public CostumeData Costume = new();
    }
}
