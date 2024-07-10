using NetProtocol.Packet;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;
using Nettention.Proud;
using UnityEngine;

public partial class ProudNetStub
{
    private bool PlayerEnterStageFourthRes(HostID remote, RmiContext rmiContext, PlayerEnterStageFourthRes packet)
    {
        if (packet.Status != ErrorCode.Success)
        {
            return true;
        }
        
        SendPacket(new PlayerEnterStageFifthReq { PlayerId = WebServerContext.PlayerId });
        return true;
    }
   
}