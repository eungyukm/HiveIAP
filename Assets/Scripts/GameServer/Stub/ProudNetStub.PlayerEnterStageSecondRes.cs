﻿using NetProtocol.Packet;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;
using Nettention.Proud;
using UnityEngine;

public partial class ProudNetStub
{
    private bool PlayerEnterStageSecondRes(HostID remote, RmiContext rmiContext, PlayerEnterStageSecondRes packet)
    {
        if (packet.Status != ErrorCode.Success)
        {
            return true;
        }
        
        SendPacket(new PlayerEnterStageThirdReq { PlayerId = WebServerContext.PlayerId });
        return true;
    }

}