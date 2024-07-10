namespace NetProtocol.Packet
{
    public enum InteractState
    {
        None = 0,
        
        Start,
        End,
        Cancel,
        
        Touch,
    }
}