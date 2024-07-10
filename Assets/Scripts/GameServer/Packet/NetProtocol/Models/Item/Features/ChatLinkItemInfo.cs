namespace NetProtocol.Models.Item.Features
{
    public class ChatLinkItemInfo
    {
        // 챗에서 링크된 순서 ex) {아이템1}{아이템2} 두개가 링크될때 첫번쨰는 1, 두번째는 2
        public int LinkId = 0;

        public long ItemId = 0;
        // 링크된 아이템의 고유 아이디
        public long LinkedItemUniqueId = 0;
//        public uint ItemIndex = 0;
        // 클라에서 강화수치 & 컬러 정보까지 넣어서 보내면 ItemIndex가 필요 없을듯
        // public string ItemName = string.Empty;
    }
}