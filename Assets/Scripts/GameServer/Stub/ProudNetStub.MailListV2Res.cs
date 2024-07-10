using NetProtocol.Packet;
using NetProtocol.Packet.C2G;
using NetProtocol.Packet.G2C;
using Nettention.Proud;
using UnityEngine;

public partial class ProudNetStub
{
    private bool MailListV2Res(HostID remote, RmiContext rmiContext, MailListV2Res packet)
    {
        if (packet.Err != ErrorCode.Success)
        {
            Debug.LogError("MailListV2Res Error");
            return true;
        }
        
        Debug.Log("MailListV2Res Success");
        return true;
    }


}