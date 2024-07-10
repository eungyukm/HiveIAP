using System;
using System.Collections.Generic;
using NetProtocol.Models.Actor.Features;
using NetProtocol.Packet;

namespace NetProtocol.Models.Actor
{
    public class DPlayerActor
    {
//        public long PlayerId = 0;

        public string Name = string.Empty;
        
        public int Level = 0;
        public long Exp = 0;
        
        public int Title = 0;
        
        public int ZoneDataId = 0;

        public string Face = string.Empty;
        public string Customize = string.Empty;

        public double[] Stats = Array.Empty<double>();
        public int StatPoints = 0;

        public DActorProperty Property = new(); 
        public DHp Hp = new();
        public DMp Mp = new();
        public DTransform Transform = new();
        
        // 길드
        public DGuild Guild = new();

        // 장비
        public DEquipment Equipment = new();
        
        public uint EquipPet = 0;
        public DRide Ride = new();
        public DCostume Costume = new();

        // 스킬
        public DActorSkill Skills = new();

        // 아바타

        // 퀘스트
        public List<QuestInfoV2> Quests = new();
        public int AcceptedDailyQuestCount = 0;
        public int RerollCount = 0;
        public bool IsOpenDailyQuest = false;

        // 성향치
        public int KarmaPoint = 0;

        // ZoneState 정보
        public int ZoneState = 0;

        // 전투력
        public long CombatCapability = 0;
        
        //공격, 이동, 시전 속도 등 서버 - 클라이언트 동기화 필요 스텟 정보
        public DActorSyncStat SyncStat;
    }
}