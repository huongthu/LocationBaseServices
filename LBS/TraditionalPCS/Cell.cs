using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBS
{
    public class Cell
    {
        List<String> MobilePhone = new List<string>();
        public VLR ConnectedVLR;
        internal bool AddMT(MobileTerminal mobileTerminal)
        {
            if (MobilePhone.IndexOf(mobileTerminal.PhoneNumber) == -1) //MT not in this cell
            {
                MobilePhone.Add(mobileTerminal.PhoneNumber);
                ConnectedVLR.addPhone(mobileTerminal.PhoneNumber, this);
                return true;
            }
            else // MT alreaddy in this cell
            {
                return false;
            }
        }

        public bool hasPhoneNumber(string phoneNumber)
        {
            return MobilePhone.LastIndexOf(phoneNumber) != -1 ? true : false;
        }
    }
}
