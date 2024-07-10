using System.Collections.Generic;

namespace NetProtocol.Models.Item
{
    public class RideInfoExV2
    {
        public int RideTdId;
        public List<RideEquipItemExV2> EquipItem = new();
        public bool IsRegister = false; // 등록된 탈 것
        public bool IsMountState = false; // 탈 것 소환된 상태

        public void UpdateRegisterState()
        {
            if (IsRegister)
            {
                IsRegister = false;
            }
            else
            {
                IsRegister = true;
            }
        }

        public bool GetRegisterState() => IsRegister;

        public void UpdateMountState()
        {
            //IsMountState |= true;
            if (IsMountState)
            {
                IsMountState = false;
            }
            else
            {
                IsMountState = true;
            }
        }

        public bool GetRideState() => IsMountState;
    }
}