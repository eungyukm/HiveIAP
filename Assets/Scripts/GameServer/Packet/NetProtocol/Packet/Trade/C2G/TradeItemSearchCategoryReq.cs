namespace NetProtocol.Packet.C2G
{
    public class TradeItemSearchCategoryReq
    {
        public int MainCategory = 0;        // Td_Sub_Category.ITEM_MID_TYPE_CODE  (ITEM_MID_TYPE)
        public int SubCategory = 0;         // Td_Sub_Category.ITEM_SUB_TYPE_CODE  (ITEM_SUB_TYPE)
    }
}
