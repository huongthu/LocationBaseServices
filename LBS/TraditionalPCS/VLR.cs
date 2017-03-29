using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBS
{
    public class VLR
    {
        public HLR ConnectedHLR;

        //List<Cell> lstCell = new List<Cell>();
        Dictionary<string, Cell> phoneDic = new Dictionary<string, Cell>();

        public void addPhone(string phoneNumber, Cell cell)
        {
            phoneDic.Add(phoneNumber, cell);
            ConnectedHLR.addPhone(phoneNumber, this);
        }

        public virtual void delPhone(string phoneNumber)
        {
            if (phoneDic.Keys.Contains(phoneNumber))
            {
                phoneDic.Remove(phoneNumber);
                ConnectedHLR.delPhone(phoneNumber);
            }
        }

        public virtual int findPhoneCell(string phoneNumber, ref Cell cellResult)
        {
            int step = 0;

            foreach (var phone in phoneDic)
            {
                step += 1;
                if (phone.Key.Equals(phoneNumber))
                {
                    cellResult = phone.Value;
                    return step;
                }
            }
            
            cellResult = null;
            return step;
        }
    }
}
