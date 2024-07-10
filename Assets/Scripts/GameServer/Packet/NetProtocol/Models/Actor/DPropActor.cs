namespace NetProtocol.Models.Actor
{
    // 몬스터와 플레이어 Actor를제외한 여러 종류의 Actor들을 통칭해서 PropActor로 사용
    public class DPropActor : DActor
    {
        public long OwnerActorId = 0;
        public string OwnerName = string.Empty;
    }
}