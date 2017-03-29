using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBS
{
    class VLR_Cache : VLR
    {
        Dictionary<string, List<Cell>> cellIdCaches = new Dictionary<string, List<Cell>>();

        public void getCache(string phoneNumber, List<Cell> cellsCache)
        {
            if (cellIdCaches.ContainsKey(phoneNumber))
            {
                cellIdCaches[phoneNumber] = cellsCache;
            }
            else
            {
                cellIdCaches.Add(phoneNumber, cellsCache);
            }
        }

        public void exchangeCellIdCaches(string phoneNumber, VLR_Cache vlrNew)
        {
            if (cellIdCaches.ContainsKey(phoneNumber))
            {
                vlrNew.getCache(phoneNumber, cellIdCaches[phoneNumber]);
                cellIdCaches.Remove(phoneNumber);
            }
        }

        public override int findPhoneCell(string phoneNumber, ref Cell cellResult)
        {
            int step = 0;

            if (cellIdCaches.ContainsKey(phoneNumber))
            {
                var listCache = cellIdCaches[phoneNumber];

                foreach (var cell in listCache)
                {
                    step += 1;
                    if (cell.hasPhoneNumber(phoneNumber))
                    {
                        cellResult = cell;
                        return step;
                    }
                }
            }

            return (step + base.findPhoneCell(phoneNumber, ref cellResult));
        }
    }
}
