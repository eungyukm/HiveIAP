namespace NetProtocol.Packet.G2C
{
    public class InteractNoti
    {
        public ErrorCode Status;
        public long ActorId;

        public long TargetActorId;
        public InteractState State = InteractState.None;
    }
}