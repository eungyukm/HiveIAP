
namespace NetProtocol.Models.Item.Features
{

    public record SimpleItemKey
    {
        public uint ItemIndex = 0;
        public bool Belong = true;      // 귀속 여부
    }

    public class SimpleItem
    {
        public uint ItemIndex = 0;
        public int Count = 0;
        public bool Belong = true;      // 귀속 여부
    }
}
