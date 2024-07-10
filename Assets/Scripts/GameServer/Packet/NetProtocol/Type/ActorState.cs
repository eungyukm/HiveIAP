namespace NetProtocol.Packet
{
    public enum ActorState
    {
        Idle = 0,
        Dead,       
        Attack,
        Mining,
        Gathering,
        Fishing,
        Return,     
        Spawn,
    }
}