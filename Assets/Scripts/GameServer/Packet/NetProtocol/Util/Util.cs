using NetProtocol.Packet;

namespace NetProtocol
{
    static class Util
    {
        public static bool IsSuccess(this ErrorCode code) => code == ErrorCode.Success;
    }
}
