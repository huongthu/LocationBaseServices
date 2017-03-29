using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBS
{
    public class HLR
    {
        //List<VLR> lstVLR = new List<VLR>();
        Dictionary<string, VLR> vlrDic = new Dictionary<string, VLR>();

        public void addPhone(string phoneNumber, VLR vlr)
        {
            if (vlrDic.ContainsKey(phoneNumber))
            {
                vlrDic[phoneNumber] = vlr;
            }
            else
            {
                vlrDic.Add(phoneNumber, vlr);
            }
        }

        public void delPhone(string phoneNumber)
        {
            if (vlrDic.Keys.Contains(phoneNumber))
            {
                vlrDic.Remove(phoneNumber);
            }
        }

        public int findPhoneVLR(string phoneNumber, ref VLR vlrResult)
        {
            int step = 0;

            foreach (var vlr in vlrDic)
            {
                step += 1;
                if (vlr.Key.Equals(phoneNumber))
                {
                    vlrResult = vlr.Value;
                    return step;
                }
            }

            vlrResult = null;
            return step;
        }
    }
}
