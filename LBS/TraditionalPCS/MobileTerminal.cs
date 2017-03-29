using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBS
{
    public class MobileTerminal
    {
        public string PhoneNumber { get; set; }
        public Cell ConnectedCell { get; set; }

        protected MobileTerminal() { }

        public MobileTerminal(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        public MobileTerminal(string phoneNumber, Cell cell)
        {
            PhoneNumber = phoneNumber;
            this.JoinCell(cell);
        }

        public virtual void JoinCell(Cell cell)
        {
            if (cell.ConnectedVLR != null)
            {
                cell.ConnectedVLR.delPhone(this.PhoneNumber);
            }
            if(cell.AddMT(this))
            {
                ConnectedCell = cell;
            }
        }

        public FindResult findPhoneCell(string phoneNumber)
        {
            Cell cellResult = null;

            int vlrStep = this.ConnectedCell.ConnectedVLR.findPhoneCell(phoneNumber, ref cellResult);
            int vlrCost = COST.PHONE_TO_VLR_COST + vlrStep * COST.PAGING_CELL_COST;

            if (cellResult != null)
            {
                return new FindResult()
                {
                    Cost = vlrCost,
                    Result = cellResult
                };
            }
            else
            {
                VLR vlrResult = null;
                int hlrStep = this.ConnectedCell.ConnectedVLR.ConnectedHLR.findPhoneVLR(phoneNumber, ref vlrResult);
                int hlrCost = COST.PHONE_TO_HLR_COST + (hlrStep * COST.PAGING_VLR_COST);

                if (vlrResult != null)
                {
                    vlrStep = vlrResult.findPhoneCell(phoneNumber, ref cellResult);
                    hlrCost += (vlrStep * COST.PAGING_CELL_COST);
                }

                return new FindResult()
                {
                    Cost = vlrCost + hlrCost,
                    Result = vlrResult
                };
            }
        }
    }
}
