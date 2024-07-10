using System.Collections.Generic;

namespace NetProtocol.Packet.G2C
{
    public class RideInfosNoti
    {
        public uint EquipRideIndex;
        public bool EquipRideSit;
        public int AttachInvenSize;
        public List<RideData> Rides = new();
        public List<RideAttachData> RideAttaches = new();
    }
}