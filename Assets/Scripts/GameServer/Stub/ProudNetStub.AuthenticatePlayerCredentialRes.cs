using NetProtocol.Packet;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;
using Nettention.Proud;

public partial class ProudNetStub
{
    private bool AuthenticatePlayerCredentialRes(HostID remote, RmiContext rmiContext, AuthenticatePlayerCredentialRes packet)
    {
        if (packet.Err != ErrorCode.Success)
        {
            return true;
        }

        SendPacket(new PlayerSelectReq { PlayerId = WebServerContext.PlayerId });
        return true;
    }
}