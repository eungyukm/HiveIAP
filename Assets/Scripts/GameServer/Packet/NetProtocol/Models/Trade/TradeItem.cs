
using NetProtocol.Models.Item;
using NetProtocol.Models.Stat;
using System.Collections.Generic;

namespace NetProtocol.Models.Trade
{
    public class TradeItem
    {
        public long ItemId = 0;    // 아이템 고유 번호
        public uint DataId = 0;
        public bool Belong = false;     // 귀속 여부
        public int Qty = 0;
        public int DownLevel = 0;
        public int Enchant = 0;
        public byte SocketCount = 0;
        public List<int> OptionList = new();
        public byte SkillCount = 0;
        public List<ItemSkillV2> SkillList = new();
        public List<StatData> SubStatList = new();
    }
}
