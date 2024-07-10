namespace NetProtocol.Packet.C2G
{
    // 로그인 서버에서 발급한 토킁을 여기를 통해 검증을 한다.
    public class AuthenticatePlayerCredentialReq
    {
        // Token
        // public long AccountId;
        public string Token;
        public string DeviceId;
    }
}