using NetProtocol.Packet;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;
using Nettention.Proud;
using UnityEngine;

public partial class ProudNetStub
{
    private bool PlayerSelectRes(HostID remote, RmiContext rmiContext, PlayerSelectRes packet)
    {
        if (packet.Err != ErrorCode.Success)
        {
            return true;
        }
        
        SendPacket(new PlayerEnterStageFirstReq { PlayerId = WebServerContext.PlayerId });
        return true;
    }

}