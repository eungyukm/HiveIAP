using System.Collections.Generic;
using NetProtocol.Models.Account;
using NetProtocol.Models.Player;

namespace NetProtocol.Packet.G2C
{
    public class AuthenticatePlayerCredentialRes
    {
        public ErrorCode Err;

        public WorldAccount WorldAccount = new();
        public List<LobbyPlayerV2> Players = new();

        public AccountProfile Profile = new();
        
        public static AuthenticatePlayerCredentialRes Error(ErrorCode errorCode)
        {
            return new AuthenticatePlayerCredentialRes()
            {
                Err = errorCode,
            };
        }
    }
}