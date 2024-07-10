namespace NetProtocol.Packet
{
    public enum ActorStateEffect
    {
        Normal = 0,

        Stun,       // 기절
        Taunt,      // 도발
        Restraint,  // 속박
        Silence,    // 침묵
        Freeze,     // 빙결
        Sleep,      // 수면
        KnockDown,  // 넉다운
        HideLv1,    // 은신 탐지 가능 
        HideLv2,    // 은신 탐지 불가
        
        // Hold,
        // Hide,
        // Grab,
        // KnockBack,
        // Stun,
        // Freeze,
    }
}