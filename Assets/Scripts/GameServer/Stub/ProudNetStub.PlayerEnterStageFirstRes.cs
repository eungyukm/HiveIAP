using NetProtocol.Packet;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;
using Nettention.Proud;
using UnityEngine;

public partial class ProudNetStub
{
    private bool PlayerEnterStageFirstRes(HostID remote, RmiContext rmiContext, PlayerEnterStageFirstRes packet)
    {
        if (packet.Status != ErrorCode.Success)
        {
            return true;
        }

        SendPacket(new PlayerEnterStageSecondReq { PlayerId = WebServerContext.PlayerId });
        return true;
    }

}