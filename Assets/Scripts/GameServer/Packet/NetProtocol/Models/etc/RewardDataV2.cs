using System;
using System.Collections.Generic;
using System.Text;

namespace NetProtocol.Models.etc
{
    public class RewardData
    {
        public int RewardType = 0;      // enum REWARD_TYPE
        public uint ItemIndex = 0;      // Item dataId
        public int Value = 0;           // ItemCount or Value

    }
}
