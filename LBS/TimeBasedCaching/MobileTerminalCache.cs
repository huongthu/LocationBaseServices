using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBS
{
    public class MobileTerminalCache : MobileTerminal
    {
        public MobileTerminalCache() : base() { }
        public MobileTerminalCache(string phoneNumber) : base(phoneNumber) { this.PhoneNumber = phoneNumber; }
        public MobileTerminalCache(string phoneNumber, Cell cell) : base(phoneNumber, cell)
        {
            this.PhoneNumber = phoneNumber;
            this.ConnectedCell = cell;
        }
        

        List<Cell> CellsCache = new List<Cell>();
        public override void JoinCell(Cell cell)
        {
            int cellIndex = CellsCache.IndexOf(cell);

            if (cellIndex == -1) //not in cache
            {
                CellsCache.Add(cell);
            }
            else //swap cell id
            {
                if (cellIndex != 0)
                {
                    Assist.Swap(CellsCache, cellIndex, cellIndex - 1);
                }
            }
            
            if (this.ConnectedCell != null)
            {
                if (cell.ConnectedVLR != this.ConnectedCell.ConnectedVLR) //enter new VLR
                {
                    VLR_Cache vlr = (VLR_Cache)this.ConnectedCell.ConnectedVLR;
                    vlr.exchangeCellIdCaches(PhoneNumber, vlr);
                }
            }
            
            base.JoinCell(cell);
        }

        public void sendCache()
        {
            var VLR = (VLR_Cache)(ConnectedCell.ConnectedVLR);
            VLR.getCache(PhoneNumber, CellsCache);
        }
    }
}
