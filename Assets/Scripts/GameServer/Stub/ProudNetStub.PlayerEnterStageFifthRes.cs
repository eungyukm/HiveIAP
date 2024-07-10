using NetProtocol.Packet;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;
using Nettention.Proud;
using UnityEngine;

public partial class ProudNetStub
{
    private bool PlayerEnterStageFifthRes(HostID remote, RmiContext rmiContext, PlayerEnterStageFifthRes packet)
    {
        if (packet.Status != ErrorCode.Success)
        {
            return true;
        }

        SendPacket(new PlayerGameEnterReq { PlayerId = WebServerContext.PlayerId });
        return true;
    }


}