using System.Numerics;

namespace NetProtocol.Packet.G2C
{
    public class PhaseFieldEndV2Res
    {
        public ErrorCode Err = ErrorCode.Success;
        public uint Index = 0;
        public PhaseFieldState State = PhaseFieldState.Success;
        public Vector3 Pos = Vector3.Zero;

    }
}