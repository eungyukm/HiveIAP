using NetProtocol.Models.Actor.Features;
using System.Collections.Generic;

namespace NetProtocol.Models.Actor
{
    public class DPlayerActorForBroadCast
    {
        public long PlayerId;
     
        public string Name;
        
        public int Level;

        public string Face;
        public string Customize;
        
        public DActorProperty Property; 
        public DHp Hp;
        public DMp Mp;
        public DTransform Transform;
        
        // 길드
        public DGuild Guild = new();

        // 장비 외형 정보
        public DEquipment Equipment = new();

        public uint EquipPet = 0;
        public DRide Ride = new();
        public DCostume Costume = new();

        // 아바타 외형 정보

        // 타이틀 외형 정보
        public int Title = 0;

        // 전투 모드
        public bool IsBattleMode = false;
        // 버프 정보
        public List<DActorBuff> Buffs = new();

        // 길드 이름

        // 성향치
        public int KarmaPoint = 0;
        // 보라돌이 정보
        public bool PurpleActive = false;

        // 존 스테이트 정보
        public int ZoneState = 0;

        //공격, 이동, 시전 속도 등 서버 - 클라이언트 동기화 필요 스텟 정보
        public DActorSyncStat SyncStat;

        // 블러드 포그 정보
        public int Rank = 0;
    }
}