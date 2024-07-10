using NetProtocol.Packet;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;
using Nettention.Proud;
using UnityEngine;

public partial class ProudNetStub
{
    private bool PlayerGameEnterRes(HostID remote, RmiContext rmiContext, PlayerGameEnterRes packet)
    {
        if (packet.Status != ErrorCode.Success)
        {
            return true;
        }

        Debug.Log("Player GameEnter Success");
        return true;
    }


}