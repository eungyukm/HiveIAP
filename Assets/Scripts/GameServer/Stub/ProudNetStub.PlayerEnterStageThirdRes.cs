using NetProtocol.Packet;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;
using Nettention.Proud;
using UnityEngine;

public partial class ProudNetStub
{
    private bool PlayerEnterStageThirdRes(HostID remote, RmiContext rmiContext, PlayerEnterStageThirdRes packet)
    {
        if (packet.Status != ErrorCode.Success)
        {
            return true;
        }
        
        SendPacket(new PlayerEnterStageFourthReq { PlayerId = WebServerContext.PlayerId });
        return true;
    }

}