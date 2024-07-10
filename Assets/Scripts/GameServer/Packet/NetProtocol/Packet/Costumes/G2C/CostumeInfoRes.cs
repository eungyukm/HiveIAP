using System.Collections.Generic;
using NetProtocol.Models.Item;

namespace NetProtocol.Packet.G2C
{
    public class CostumeInfoRes
    {
        public ErrorCode Result = ErrorCode.Success;
        public uint HeadEquip;
        public bool HeadShow;
        public uint BodyEquip;
        public bool BodyShow;
        public List<CostumeData> Costumes = new();
        public List<CostumeCard> Cards = new();
    }
}
