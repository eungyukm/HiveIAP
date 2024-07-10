namespace NetProtocol.Models.Item
{
    public class ItemV2
    {
        public long Id = 0;
        public uint DataId = 0;
        public int Count = 0;               // 아이템  갯수

        public bool IsFixedOwner = false;
        public bool IsLocked = false;           // 아이템 잠금

        public ItemV2() { }
    
        public ItemV2(ItemV2 item)
        {
            Id = item.Id;
            DataId = item.DataId;
            Count = item.Count;
            IsFixedOwner = item.IsFixedOwner;
            IsLocked = item.IsLocked;
        }
        
    }

    

}
