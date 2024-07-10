
namespace NetProtocol.Packet
{
    public enum WhereType
    {
        None = 0,           // 없음
        Map = 1,            // 맵
        Item = 2,           // 아이템
        Party = 3,          // 파티 아이템획득
        ItemCombine = 4,    // 아이템 조합
        ItemProduct = 5,    // 아이템 제작
        PetMix = 6,         // 펫 합성
        RideMix = 7,        // 탈것 합성
        CostumeOpen = 8,    // 코스튬 제작
        ItemInherit = 9,    // 아이템 계승
        Max,
    }

    public enum WhatType
    {
        None = 0,           // 없음
        Item = 1,           // 아이템
        Pet = 2,            // 펫
        Ride = 3,           // 탈것
        Costume = 4,        // 코스튬
        Max,
    }
    
}
